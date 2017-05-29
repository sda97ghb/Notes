using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Notes
{
    class NotesOfflineModel : NotesModel
    {
        public NotesOfflineModel()
        {
            ;
        }

        public void loadFromFile(string filename)
        {
            this.notes.Clear();

            Console.WriteLine("Load file " + filename);
            
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            writer.Formatting = Formatting.Indented;
            //doc.WriteTo(writer);
            //writer.Flush();
            //Console.WriteLine();

            XmlElement notes = (XmlElement)doc.GetElementsByTagName("notes")[0];
            if (notes == null)
                throw new Exception("Incorrect save file format");

            foreach (XmlElement category in notes.GetElementsByTagName("category"))
            {
                string categoryName = category.GetAttribute("name");

                foreach (XmlElement note in category.GetElementsByTagName("note"))
                {
                    string id = note.GetAttribute("id");
                    string text = note.GetElementsByTagName("text")[0].InnerText;
                    
                    addNote(id, categoryName, text);
                }
            }
        }

        public void saveToFile(string filename)
        {
            Console.WriteLine("Save to file " + filename);

            XmlDocument doc = new XmlDocument();

            var notes = doc.CreateElement("notes");
            doc.AppendChild(notes);

            foreach (string category in Categories)
            {
                var categoryElem = doc.CreateElement("category");
                categoryElem.SetAttribute("name", category);
                notes.AppendChild(categoryElem);

                foreach (Note note in getNotesWithCategory(category))
                {
                    var noteElem = doc.CreateElement("note");
                    noteElem.SetAttribute("id", note.id);
                    categoryElem.AppendChild(noteElem);

                    var textElem = doc.CreateElement("text");
                    textElem.InnerText = note.text;
                    noteElem.AppendChild(textElem);
                }
            }

            doc.Save(filename);
        }

        public override void addNote(string category)
        {
            string id = getNewId();
            addNote(id, category, "");
        }

        public override void addNote(string category, string text)
        {
            string id = getNewId();
            addNote(id, category, text);
        }

        override public void addNote(string id, string category, string text)
        {
            string template = "Create new note {{id:\"{0}\", category:\"{1}\", text:\"{2}}}";
            Console.WriteLine(String.Format(template, id, category, text));

            notes.Add(new Note() { id = id, category = category, text = text });
        }

        public override void updateNote(string id, string text)
        {
            //Console.WriteLine(String.Format("Update note {id:\"{id}\", text:\"{text}\"", id, text));
            foreach (Note note in notes)
            {
                if (note.id != id)
                    continue;
                note.text = text;
                return;
            }
        }

        public override void deleteNote(string id)
        {
            Console.WriteLine(String.Format("Delete note {id:\"{id}\"}", id));
        }

        string getNewId()
        {
            List<int> ids = (from note in notes select Convert.ToInt32(note.id)).ToList();
            if (ids.Count == 0)
                return "1";
            ids.Sort();
            return (ids.Last() + 1).ToString();
        }
    }
}
