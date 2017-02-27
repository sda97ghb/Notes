using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notes
{
    public partial class NotesForm : Form
    {
        List<NoteControl> notes = new List<NoteControl>();
        public NotesForm()
        {
            InitializeComponent();
        }

        private void NotesForm_Resize(object sender, EventArgs e)
        {
            NotesArea.BackColor = this.BackColor;
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            NoteControl note = new NoteControl();
            note.Name = "Note";
            notes.Add(note);
            NotesArea.Controls.Add(note);

            placeNoteControls(NotesAreaScrollbar.Value);

            calculateScrollingMax();
        }

        void placeNoteControls(int deltaY)
        {
            // TODO n==0 problem

            const int min = 340;
            int numberOfColumns = NotesArea.Width / min;
            int d = (NotesArea.Width - 20) - min * numberOfColumns - 20 * (numberOfColumns - 1) - 40;
            d /= numberOfColumns+1;
            int columnWidth = min + d;
            const int magicNumber = 300;

            for (int i = 0; i < notes.Count; ++i)
            {
                notes[i].Width = columnWidth;
                notes[i].Left = 20 + (columnWidth + 20) * (i % numberOfColumns);
                notes[i].Top = 20 + magicNumber * (i / numberOfColumns) - deltaY;
            }
        }

        void calculateScrollingMax()
        {
            int max = 0;
            foreach (NoteControl note in notes)
                if (max < note.Top + note.Height)
                    max = note.Top + note.Height;
            max -= NotesArea.Height;
            NotesAreaScrollbar.Maximum = max > 0 ? max : 0;
        }

        private void NotesAreaScrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            placeNoteControls(NotesAreaScrollbar.Value);

        }

        private void NotesForm_Resize_1(object sender, EventArgs e)
        {
            placeNoteControls(NotesAreaScrollbar.Value);
            calculateScrollingMax();
        }
    }
}
