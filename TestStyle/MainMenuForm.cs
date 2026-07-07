using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestStyle
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void signinButton_MouseEnter(object sender, EventArgs e)
        {
            signinButton.ForeColor = Color.BlueViolet;
        }

        private void signinButton_MouseLeave(object sender, EventArgs e)
        {
            signinButton.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            // open signin form
        }

        private void signupButton_MouseEnter(object sender, EventArgs e)
        {
            signupButton.ForeColor = Color.BlueViolet;
        }

        private void signupButton_MouseLeave(object sender, EventArgs e)
        {
            signupButton.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            // open signup form
        }
    }
}
