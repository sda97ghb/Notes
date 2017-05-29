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
    public partial class SettingsControl : UserControl
    {
        NotesForm notesForm = null;

        public SettingsControl(NotesForm notesForm)
        {
            InitializeComponent();

            this.notesForm = notesForm;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            notesForm.loadNotesFromFile();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            notesForm.saveNotesToFile();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            (new AboutForm()).ShowDialog();
        }
    }
}
