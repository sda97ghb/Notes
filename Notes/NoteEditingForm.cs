using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class NoteEditingForm : Form
    {
        public string text
        {
            get
            {
                return NoteText.Text;
            }
            set
            {
                NoteText.Text = value;
            }
        }

        public NoteEditingForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
