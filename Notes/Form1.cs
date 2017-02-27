using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notes
{
    public partial class NotesForm : Form
    {
        List<NoteControl1> notes = new List<NoteControl1>();
        public NotesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NoteControl1 control = new NoteControl1();
            control.Name = "Note";
            control.Left = 60;
            if (notes.Count == 0)
                control.Top = 0;
            else
                control.Top = notes[notes.Count - 1].Top + 200;
            notes.Add(control);
            Controls.Add(control);
        }

        private void NotesForm_Resize(object sender, EventArgs e)
        {
            AddNoteButton.Left = this.Width - AddNoteButton.Size.Width - 15;
            AddNoteButton.Top = 0;
        }
    }
}
