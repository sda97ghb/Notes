using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Notes
{
    public partial class NotesForm : Form
    {
        NotesModel model;

        MainMenu mainMenu = null;
        SettingsControl settings = null;

        const int distanceX = 40; ///< distance between notes
        const int distanceY = 40; ///< distance between notes
        const int minWidth = 250; ///< single note width
        const int minHeight = 213;///< single note height

        List<NoteControl> notes = new List<NoteControl>();

        public NotesForm()
        {
            InitializeComponent();

            mainMenu = new MainMenu(this);
            mainMenu.Hide();
            mainMenu.Dock = DockStyle.Left;
            Controls.Add(mainMenu);

            settings = new SettingsControl(this);
            settings.Hide();
            settings.Dock = DockStyle.Right;
            Controls.Add(settings);

            placeCategories();
        }

        public void init()
        {
            HelloForm welcomeForm = new HelloForm();
            welcomeForm.ShowDialog();
            switch (welcomeForm.mode)
            {
                case HelloForm.ModeType.offline:
                    runOffline();
                    break;
                case HelloForm.ModeType.online:
                    runOnline();
                    break;
            }
        }

        private void runOnline()
        {
            AuthorizationForm auth = new AuthorizationForm();
            auth.ShowDialog();

            if (auth.isBackwardPressed)
            {
                auth.isBackwardPressed = false;
                init();
                return;
            }

            if (!auth.isDataEntered)
            {
                var res = MessageBox.Show("You can't be authorized without login and password. Retry?",
                                          "Oops! Are you shure?", MessageBoxButtons.RetryCancel);
                if (res == DialogResult.Cancel)
                    System.Environment.Exit(0);
                if (res == DialogResult.Retry)
                    auth.ShowDialog();
            }
            if (auth.isBackwardPressed)
            {
                auth.isBackwardPressed = false;
                init();
                return;
            }
            if (!auth.isDataEntered)
                System.Environment.Exit(0);

            model = new NotesSqlModel(auth.login, auth.password);
            
            (model as NotesSqlModel).loadNotes();

            showNotes();
        }

        private void runOffline()
        {
            model = new NotesOfflineModel();

            showNotes();
        }

        private void showNotes()
        {
            NotesArea.Controls.Clear();
            notes.Clear();

            foreach (NotesModel.Note note in model.notes)//getNotesWithCategory(currentCategory))
            {
                NoteControl noteControl = new NoteControl(this, model, note);
                noteControl.Name = "Note";
                noteControl.text = note.text;
                notes.Add(noteControl);
                NotesArea.Controls.Add(noteControl);
            }

            placeNoteControls(NotesAreaScrollbar.Value);

            calculateScrollingMax();
        }

        public void loadNotesFromFile()
        {
            if (model is NotesSqlModel)
            {
                MessageBox.Show("Can't load notes until online mode is enabled");
                return;
            }

            OpenFileDialog.ShowDialog();
            (model as NotesOfflineModel).loadFromFile(OpenFileDialog.FileName);

            NotesArea.Controls.Clear();

            showNotes();
            placeCategories();
        }

        public void saveNotesToFile()
        {
            if (model is NotesSqlModel)
            {
                MessageBox.Show("Can't save notes to file until online mode is enabled");
                return;
            }

            SaveFileDialog.ShowDialog();
            (model as NotesOfflineModel).saveToFile(SaveFileDialog.FileName);
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            addNewNote();
        }

        public void addNewNote()
        {
            model.addNote("My notes");

            showNotes();

            //NoteControl note = new NoteControl(this);
            //note.Name = "Note";
            //notes.Add(note);
            //NotesArea.Controls.Add(note);

            //placeNoteControls(NotesAreaScrollbar.Value);

            //calculateScrollingMax();
        }

        public void placeNoteControls()
        {
            calculateScrollingMax();
            placeNoteControls(NotesAreaScrollbar.Value);
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

            repairTransparance();
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

        private void MenuButton_Click(object sender, EventArgs e)
        {
            expandMenu();
        }

        public void expandMenu()
        {
            mainMenu.Show();
            mainMenu.BringToFront();
            CategoriesPanel.Hide();
        }

        public void shrinkMenu()
        {
            mainMenu.Hide();
            CategoriesPanel.Show();
            CategoriesPanel.BringToFront();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            repairTransparance();
        }

        public void repairTransparance()
        {
            GraphicsPath gr = new GraphicsPath();
            foreach (Control c in NotesArea.Controls)
            {
                gr.AddRectangle(new Rectangle(c.Location, c.Size));
            }
            NotesArea.Region = new Region(gr);
        }

        public void shrinkAllNotes()
        {
            foreach (NoteControl note in notes)
                note.shrink();
        }

        private void NotesForm_Resize(object sender, EventArgs e)
        {
            placeNoteControls();
        }

        public void placeCategories()
        {
            NoteGroups.Controls.Clear();

            if (model == null)
                return;

            List<string> categories = model.Categories;
            if (categories == null)
                return;

            for (int i = categories.Count - 1; i >= 0; --i)
            {
                var categoryButton = new Button();
                categoryButton.Height = 30;
                categoryButton.Dock = DockStyle.Top;
                categoryButton.FlatStyle = FlatStyle.Flat;
                categoryButton.FlatAppearance.BorderSize = 0;
                categoryButton.Name = "Category" + i;
                categoryButton.Tag = i;
                categoryButton.Click += new EventHandler(this.handleCategory);
                categoryButton.Text = categories[i];
                //if (i == currentCategoryIndex)
                    //categoryButton.BackColor = System.Drawing.Color.FromArgb(113, 113, 114);
                NoteGroups.Controls.Add(categoryButton);
            }
        }

        private void handleCategory(object sender, EventArgs e)
        {
            int wantedCategoryIndex = Convert.ToInt32((sender as Button).Tag);
            selectCategory(wantedCategoryIndex);
        }

        public void selectCategory(int index)
        {
            //currentCategoryIndex = index;
            placeCategories();
            placeNoteControls();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (isSettingsShowed())
                hideSettings();
            else
                showSettings();
        }

        public void showSettings()
        {
            settings.Show();
            settings.BringToFront();
        }

        public void hideSettings()
        {
            settings.Hide();
        }

        public bool isSettingsShowed()
        {
            return settings.Visible;
        }
    }
}

//savva.rost @gmail.com
