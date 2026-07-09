using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Music_App.Forms
{
    public partial class SongCreationForm : Form
    {
        public SongCreationForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string genre = txtGenre.Text.Trim();
            string dateInput = txtDate.Text.Trim();

            // валідація на порожні поля
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(dateInput))
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // валідація формату дати (я використав TextBox)
            if (!DateTime.TryParseExact(dateInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                MessageBox.Show("Please enter the date in the correct format: DD.MM.YYYY", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // поки просто вивід про успіх перед відправкою
            MessageBox.Show($"Song '{title}' ({genre}) created successfully for {parsedDate.ToShortDateString()}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                songTitleLabel.Text = "Song Title";
            }
            else
            {
                songTitleLabel.Text = txtTitle.Text;
            }
        }

        private void txtGenre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                songGenreLabel.Text = "Genre";
            }
            else
            {
                songGenreLabel.Text = txtGenre.Text;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
