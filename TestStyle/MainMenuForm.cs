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

        private void SigninButton_Click(object sender, EventArgs e)
        {
            SigninForm loginForm = new SigninForm();
            loginForm.ShowDialog();
        }

        

        private void SearchBtnRMM_Click(object sender, EventArgs e)
        {

        }
        private void PlaylistsBtnRMM_Click(object sender, EventArgs e)
        {
            PlaylistsForm playlistForm = new PlaylistsForm();
            playlistForm.Show();
        }

        private void HistoryBtnRMM_Click(object sender, EventArgs e)
        {

        }

        private void CreateSongBtnRMM_Click(object sender, EventArgs e)
        {

        }
    }
}
