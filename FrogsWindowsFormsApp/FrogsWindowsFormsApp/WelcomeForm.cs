using System;
using System.Windows.Forms;

namespace FrogsWindowsFormsApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
