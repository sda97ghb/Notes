using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class NoteControl : UserControl
    {
        bool isExpanded = false;

        public string text
        {
            get
            {
                return NoteText.Text;
            }
            set
            {
                NoteText.Text = value;
                if (NoteText.Height > 217)
                    ExpandButton.Show();
                else
                {
                    shrink();
                    ExpandButton.Hide();
                }
            }
        }

        NotesForm notesForm = null;
        NotesModel model = null;
        NotesModel.Note note = null;

        public NoteControl(NotesForm notesForm, NotesModel model, NotesModel.Note note)
        {
            InitializeComponent();

            this.notesForm = notesForm;
            this.model = model;
            this.note = note;
        }

        private void Text_Click(object sender, EventArgs e)
        {
            ;
        }

        private void NoteControl_Resize(object sender, EventArgs e)
        {
            ;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            NoteEditingForm editing = new NoteEditingForm();
            editing.text = text;
            editing.ShowDialog();
            text = editing.text;
            model.updateNote(note.id, text);

            if (isExpanded)
                expand(); // set correct new height
        }

        private void ExpandButton_Click(object sender, EventArgs e)
        {
            bool expandness = isExpanded;

            notesForm.shrinkAllNotes();

            if (expandness)
                shrink();
            else
                expand();
        }

        void expand()
        {
            isExpanded = true;
            this.Height = NoteText.Height + 5;
            this.BringToFront();

            notesForm.repairTransparance();
        }

        public void shrink()
        {
            isExpanded = false;
            this.Height = 213;

            notesForm.repairTransparance();
        }
    }
}
