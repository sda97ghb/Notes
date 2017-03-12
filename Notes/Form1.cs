using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notes
{
    public partial class NotesForm : Form
    {
        const int distanceX = 40; ///< distance between notes
        const int distanceY = 40; ///< distance between notes
        const int minWidth = 250; ///< single note width
        const int minHeight = 200;///< single note height

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

        void placeNoteControls(int offsetY)
        {
            int numberOfColumns = (NotesArea.Width - distanceX) / (minWidth + distanceX);
            int offsetX;
            if (notes.Count < numberOfColumns)
                offsetX = (NotesArea.Width - ((minWidth + distanceX) * notes.Count + distanceX)) / 2;
            else
                offsetX = (NotesArea.Width - ((minWidth + distanceX) * numberOfColumns + distanceX)) / 2;

            for (int i = 0; i < notes.Count; ++i)
            {
                notes[i].Width = minWidth;
                notes[i].Height = minHeight;
                notes[i].Left = offsetX + distanceX + (minWidth + distanceX) * (i % numberOfColumns);
                notes[i].Top = distanceY + (minHeight + distanceY) * (i / numberOfColumns) - offsetY;
            }
        }

        void calculateScrollingMax()
        {
            int max = 0;
            foreach (NoteControl note in notes)
                if (max < note.Top + note.Height)
                    max = note.Top + note.Height;
            max -= NotesArea.Height;
            max += distanceY;
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
