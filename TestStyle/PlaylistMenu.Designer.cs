namespace Music_App
{
    partial class PlaylistMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistMenu));
            panelSongs = new FlowLayoutPanel();
            pnlSong1 = new Panel();
            PlsongGenreLabel1 = new Label();
            PlsongLengthLabel1 = new Label();
            PlsongPictureBox1 = new PictureBox();
            PlsongTitleLabel1 = new Label();
            PlsongAuthorLabel1 = new Label();
            PlaylistLabel = new Label();
            panelSongs.SuspendLayout();
            pnlSong1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlsongPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSongs
            // 
            panelSongs.AutoScroll = true;
            panelSongs.BorderStyle = BorderStyle.FixedSingle;
            panelSongs.Controls.Add(pnlSong1);
            panelSongs.FlowDirection = FlowDirection.TopDown;
            panelSongs.Location = new Point(39, 66);
            panelSongs.Name = "panelSongs";
            panelSongs.Size = new Size(606, 595);
            panelSongs.TabIndex = 0;
            panelSongs.WrapContents = false;
            // 
            // pnlSong1
            // 
            pnlSong1.Controls.Add(PlsongGenreLabel1);
            pnlSong1.Controls.Add(PlsongLengthLabel1);
            pnlSong1.Controls.Add(PlsongPictureBox1);
            pnlSong1.Controls.Add(PlsongTitleLabel1);
            pnlSong1.Controls.Add(PlsongAuthorLabel1);
            pnlSong1.Location = new Point(3, 3);
            pnlSong1.Name = "pnlSong1";
            pnlSong1.Size = new Size(589, 103);
            pnlSong1.TabIndex = 0;
            pnlSong1.Click += pnlSong1_Click;
            // 
            // PlsongGenreLabel1
            // 
            PlsongGenreLabel1.Font = new Font("Sitka Banner", 12F);
            PlsongGenreLabel1.ForeColor = SystemColors.ControlDark;
            PlsongGenreLabel1.Location = new Point(265, 52);
            PlsongGenreLabel1.Name = "PlsongGenreLabel1";
            PlsongGenreLabel1.Size = new Size(189, 35);
            PlsongGenreLabel1.TabIndex = 10;
            PlsongGenreLabel1.Text = "Genre";
            // 
            // PlsongLengthLabel1
            // 
            PlsongLengthLabel1.Font = new Font("Sitka Banner", 14F);
            PlsongLengthLabel1.ForeColor = SystemColors.ControlDark;
            PlsongLengthLabel1.Location = new Point(460, 52);
            PlsongLengthLabel1.Name = "PlsongLengthLabel1";
            PlsongLengthLabel1.Size = new Size(62, 37);
            PlsongLengthLabel1.TabIndex = 9;
            PlsongLengthLabel1.Text = "99:99";
            // 
            // PlsongPictureBox1
            // 
            PlsongPictureBox1.Image = (Image)resources.GetObject("PlsongPictureBox1.Image");
            PlsongPictureBox1.Location = new Point(8, 13);
            PlsongPictureBox1.Name = "PlsongPictureBox1";
            PlsongPictureBox1.Size = new Size(69, 74);
            PlsongPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PlsongPictureBox1.TabIndex = 6;
            PlsongPictureBox1.TabStop = false;
            // 
            // PlsongTitleLabel1
            // 
            PlsongTitleLabel1.AutoEllipsis = true;
            PlsongTitleLabel1.Font = new Font("Sylfaen", 16F);
            PlsongTitleLabel1.ForeColor = SystemColors.ButtonShadow;
            PlsongTitleLabel1.Location = new Point(83, 13);
            PlsongTitleLabel1.Name = "PlsongTitleLabel1";
            PlsongTitleLabel1.Size = new Size(384, 39);
            PlsongTitleLabel1.TabIndex = 7;
            PlsongTitleLabel1.Text = "Song Title";
            // 
            // PlsongAuthorLabel1
            // 
            PlsongAuthorLabel1.Font = new Font("Sitka Banner", 12F);
            PlsongAuthorLabel1.ForeColor = SystemColors.ControlDark;
            PlsongAuthorLabel1.Location = new Point(83, 52);
            PlsongAuthorLabel1.Name = "PlsongAuthorLabel1";
            PlsongAuthorLabel1.Size = new Size(343, 35);
            PlsongAuthorLabel1.TabIndex = 8;
            PlsongAuthorLabel1.Text = "Song Author";
            // 
            // PlaylistLabel
            // 
            PlaylistLabel.AutoSize = true;
            PlaylistLabel.BackColor = Color.Transparent;
            PlaylistLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlaylistLabel.ForeColor = Color.FromArgb(255, 128, 0);
            PlaylistLabel.Location = new Point(265, 9);
            PlaylistLabel.Name = "PlaylistLabel";
            PlaylistLabel.Size = new Size(109, 41);
            PlaylistLabel.TabIndex = 9;
            PlaylistLabel.Text = "Playlist";
            PlaylistLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PlaylistMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(674, 686);
            Controls.Add(PlaylistLabel);
            Controls.Add(panelSongs);
            Name = "PlaylistMenu";
            Text = "PlaylistMenu";
            panelSongs.ResumeLayout(false);
            pnlSong1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PlsongPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelSongs;
        private Panel pnlSong1;
        private Label PlsongTitleLabel1;
        private Label PlsongAuthorLabel1;
        private Label PlsongGenreLabel1;
        private PictureBox PlsongPictureBox1;
        private Label PlsongLengthLabel1;
        private Label PlaylistLabel;
    }
}