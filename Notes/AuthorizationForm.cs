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
    public partial class AuthorizationForm : Form
    {
        public string login { get { return loginTextBox.Text; } }
        public string password { get { return passwordTextBox.Text; } }
        public bool isDataEntered { get; private set; } = false;
        public bool isBackwardPressed { get; set; } = false;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            isDataEntered = true;
            this.Close();
        }

        private void BackwardButton_Click(object sender, EventArgs e)
        {
            isBackwardPressed = true;
            this.Close();
        }
    }
}
