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
    public partial class MainMenu : UserControl
    {
        //bool isOpened = false;

        NotesForm notesForm = null;

        public MainMenu(NotesForm notesForm)
        {
            InitializeComponent();

            this.notesForm = notesForm;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            //isOpened = !isOpened;
            //if (isOpened)
            //{
            //    this.Width = 270;
            //    MyNotesButton.Text = "  My notes";
            //    FriendsButton.Text = "  Friends";
            //    NewNoteButton.Text = "  New note";
            //    SettingsButton.Text = "  Settings";
            //}
            //else
            //{
            //    this.Width = 60;
            //    MyNotesButton.Text = "";
            //    FriendsButton.Text = "";
            //    NewNoteButton.Text = "";
            //    SettingsButton.Text = "";
            //}
            //this.Hide();
            notesForm.shrinkMenu();
        }

        private void MyNotesButton_Click(object sender, EventArgs e)
        {
            ;
        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            ;
        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            notesForm.addNewNote();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (notesForm.isSettingsShowed())
                notesForm.hideSettings();
            else
                notesForm.showSettings();
        }
    }
}
