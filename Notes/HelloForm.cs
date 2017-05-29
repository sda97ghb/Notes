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
    public partial class HelloForm : Form
    {
        public enum ModeType
        {
            online,
            offline
        }

        public ModeType mode { get; private set; } = ModeType.offline;

        public HelloForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            mode = ModeType.online;
            this.Hide();
        }

        private void GoOfflineButton_Click(object sender, EventArgs e)
        {
            mode = ModeType.offline;
            this.Hide();
        }

        private void HelloForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
