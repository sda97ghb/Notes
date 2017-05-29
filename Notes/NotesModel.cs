using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    abstract public class NotesModel
    {
        public class Note
        {
            public string id;
            public string text;
            public string category;
        }

        public List<Note> notes { get; } = new List<Note>();

        abstract public void addNote(string category);
        abstract public void addNote(string category, string text);
        abstract public void addNote(string id, string category, string text);
        abstract public void updateNote(string id, string text);
        abstract public void deleteNote(string id);

        public List<string> Categories
        {
            get
            {
                return (from note in notes select note.category).Distinct().ToList();
            }
        }

        public List<Note> getNotesWithCategory(string category)
        {
            return (from note in notes where note.category == category select note).ToList();
        }
    }
}
