namespace Music_App
{
    partial class MusicHistoryForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.Label lblPlaylists;
        private System.Windows.Forms.FlowLayoutPanel flowSongs;
        private System.Windows.Forms.FlowLayoutPanel flowPlaylists;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblSongs = new Label();
            lblPlaylists = new Label();
            flowSongs = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBoxMusicCard = new PictureBox();
            NameOfSongMusicCard = new Label();
            ArtistNameMusicCard = new Label();
            flowPlaylists = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBoxPlaylist = new PictureBox();
            PlaylistName = new Label();
            label1 = new Label();
            label2 = new Label();
            btnSongsLeft = new Button();
            btnSongsRight = new Button();
            btnSongsLeftPlaylist = new Button();
            btnSongsRightPlaylist = new Button();
            panel2 = new Panel();
            MaxSongTimeLabel = new Label();
            CurrSongTimeLabel = new Label();
            SongTrackBar = new TrackBar();
            NextBtn = new Button();
            PreviousBtn = new Button();
            Play_PauseBtn = new Button();
            SongAuthorLabel = new Label();
            SongNameLabel = new Label();
            SongPicBox = new PictureBox();
            BackGround = new FlowLayoutPanel();
            flowSongs.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMusicCard).BeginInit();
            flowPlaylists.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlaylist).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SongTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SongPicBox).BeginInit();
            BackGround.SuspendLayout();
            SuspendLayout();
            // 
            // lblSongs
            // 
            lblSongs.AutoSize = true;
            lblSongs.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSongs.ForeColor = Color.White;
            lblSongs.Location = new Point(91, 58);
            lblSongs.Name = "lblSongs";
            lblSongs.Size = new Size(226, 25);
            lblSongs.TabIndex = 0;
            lblSongs.Text = "Recently Listened Songs";
            // 
            // lblPlaylists
            // 
            lblPlaylists.AutoSize = true;
            lblPlaylists.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPlaylists.ForeColor = Color.White;
            lblPlaylists.Location = new Point(92, 301);
            lblPlaylists.Name = "lblPlaylists";
            lblPlaylists.Size = new Size(241, 25);
            lblPlaylists.TabIndex = 2;
            lblPlaylists.Text = "Recently Listened Playlists";
            // 
            // flowSongs
            // 
            flowSongs.AutoScroll = true;
            flowSongs.BackColor = Color.FromArgb(35, 35, 35);
            flowSongs.Controls.Add(flowLayoutPanel1);
            flowSongs.Location = new Point(92, 93);
            flowSongs.Margin = new Padding(3, 2, 3, 2);
            flowSongs.Name = "flowSongs";
            flowSongs.Size = new Size(665, 169);
            flowSongs.TabIndex = 1;
            flowSongs.WrapContents = false;
            flowSongs.Paint += flowSongs_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(30, 30, 30);
            flowLayoutPanel1.Controls.Add(pictureBoxMusicCard);
            flowLayoutPanel1.Controls.Add(NameOfSongMusicCard);
            flowLayoutPanel1.Controls.Add(ArtistNameMusicCard);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(116, 162);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxMusicCard
            // 
            pictureBoxMusicCard.Image = Properties.Resources.images;
            pictureBoxMusicCard.Location = new Point(3, 3);
            pictureBoxMusicCard.Name = "pictureBoxMusicCard";
            pictureBoxMusicCard.Size = new Size(110, 110);
            pictureBoxMusicCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMusicCard.TabIndex = 0;
            pictureBoxMusicCard.TabStop = false;
            // 
            // NameOfSongMusicCard
            // 
            NameOfSongMusicCard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameOfSongMusicCard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameOfSongMusicCard.ForeColor = Color.White;
            NameOfSongMusicCard.Location = new Point(3, 119);
            NameOfSongMusicCard.Margin = new Padding(3, 3, 3, 0);
            NameOfSongMusicCard.Name = "NameOfSongMusicCard";
            NameOfSongMusicCard.Size = new Size(112, 23);
            NameOfSongMusicCard.TabIndex = 1;
            NameOfSongMusicCard.Text = "SONG NAME";
            NameOfSongMusicCard.TextAlign = ContentAlignment.MiddleCenter;
            NameOfSongMusicCard.Click += label3_Click;
            // 
            // ArtistNameMusicCard
            // 
            ArtistNameMusicCard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ArtistNameMusicCard.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ArtistNameMusicCard.ForeColor = Color.DimGray;
            ArtistNameMusicCard.Location = new Point(3, 142);
            ArtistNameMusicCard.Name = "ArtistNameMusicCard";
            ArtistNameMusicCard.Size = new Size(111, 14);
            ArtistNameMusicCard.TabIndex = 2;
            ArtistNameMusicCard.Text = "ARTIST NAME";
            ArtistNameMusicCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowPlaylists
            // 
            flowPlaylists.AutoScroll = true;
            flowPlaylists.BackColor = Color.FromArgb(35, 35, 35);
            flowPlaylists.Controls.Add(flowLayoutPanel2);
            flowPlaylists.Location = new Point(92, 339);
            flowPlaylists.Margin = new Padding(3, 2, 3, 2);
            flowPlaylists.Name = "flowPlaylists";
            flowPlaylists.Size = new Size(665, 169);
            flowPlaylists.TabIndex = 3;
            flowPlaylists.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(30, 30, 30);
            flowLayoutPanel2.Controls.Add(pictureBoxPlaylist);
            flowLayoutPanel2.Controls.Add(PlaylistName);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(116, 162);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // pictureBoxPlaylist
            // 
            pictureBoxPlaylist.Image = Properties.Resources.images;
            pictureBoxPlaylist.Location = new Point(3, 3);
            pictureBoxPlaylist.Name = "pictureBoxPlaylist";
            pictureBoxPlaylist.Size = new Size(110, 110);
            pictureBoxPlaylist.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlaylist.TabIndex = 0;
            pictureBoxPlaylist.TabStop = false;
            // 
            // PlaylistName
            // 
            PlaylistName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlaylistName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PlaylistName.ForeColor = Color.White;
            PlaylistName.Location = new Point(3, 119);
            PlaylistName.Margin = new Padding(3, 3, 3, 0);
            PlaylistName.Name = "PlaylistName";
            PlaylistName.Size = new Size(112, 23);
            PlaylistName.TabIndex = 1;
            PlaylistName.Text = "SONG NAME";
            PlaylistName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(92, 277);
            label1.Name = "label1";
            label1.Size = new Size(662, 15);
            label1.TabIndex = 4;
            label1.Text = "___________________________________________________________________________________________________________________________________";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(40, 0);
            label2.Margin = new Padding(40, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 47);
            label2.TabIndex = 5;
            label2.Text = "History";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSongsLeft
            // 
            btnSongsLeft.BackColor = Color.FromArgb(255, 128, 0);
            btnSongsLeft.FlatAppearance.BorderSize = 0;
            btnSongsLeft.FlatStyle = FlatStyle.Flat;
            btnSongsLeft.ForeColor = Color.White;
            btnSongsLeft.Location = new Point(30, 150);
            btnSongsLeft.Name = "btnSongsLeft";
            btnSongsLeft.Size = new Size(40, 40);
            btnSongsLeft.TabIndex = 6;
            btnSongsLeft.Text = "<";
            btnSongsLeft.UseVisualStyleBackColor = false;
            // 
            // btnSongsRight
            // 
            btnSongsRight.BackColor = Color.FromArgb(255, 128, 0);
            btnSongsRight.FlatAppearance.BorderSize = 0;
            btnSongsRight.FlatStyle = FlatStyle.Flat;
            btnSongsRight.ForeColor = Color.White;
            btnSongsRight.Location = new Point(781, 150);
            btnSongsRight.Name = "btnSongsRight";
            btnSongsRight.Size = new Size(40, 40);
            btnSongsRight.TabIndex = 7;
            btnSongsRight.Text = ">";
            btnSongsRight.UseVisualStyleBackColor = false;
            // 
            // btnSongsLeftPlaylist
            // 
            btnSongsLeftPlaylist.BackColor = Color.FromArgb(255, 128, 0);
            btnSongsLeftPlaylist.FlatAppearance.BorderSize = 0;
            btnSongsLeftPlaylist.FlatStyle = FlatStyle.Flat;
            btnSongsLeftPlaylist.ForeColor = Color.White;
            btnSongsLeftPlaylist.Location = new Point(30, 397);
            btnSongsLeftPlaylist.Name = "btnSongsLeftPlaylist";
            btnSongsLeftPlaylist.Size = new Size(40, 40);
            btnSongsLeftPlaylist.TabIndex = 8;
            btnSongsLeftPlaylist.Text = "<";
            btnSongsLeftPlaylist.UseVisualStyleBackColor = false;
            // 
            // btnSongsRightPlaylist
            // 
            btnSongsRightPlaylist.BackColor = Color.FromArgb(255, 128, 0);
            btnSongsRightPlaylist.FlatAppearance.BorderSize = 0;
            btnSongsRightPlaylist.FlatStyle = FlatStyle.Flat;
            btnSongsRightPlaylist.ForeColor = Color.White;
            btnSongsRightPlaylist.Location = new Point(781, 397);
            btnSongsRightPlaylist.Name = "btnSongsRightPlaylist";
            btnSongsRightPlaylist.Size = new Size(40, 40);
            btnSongsRightPlaylist.TabIndex = 9;
            btnSongsRightPlaylist.Text = ">";
            btnSongsRightPlaylist.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 24, 24);
            panel2.Controls.Add(MaxSongTimeLabel);
            panel2.Controls.Add(CurrSongTimeLabel);
            panel2.Controls.Add(SongTrackBar);
            panel2.Controls.Add(NextBtn);
            panel2.Controls.Add(PreviousBtn);
            panel2.Controls.Add(Play_PauseBtn);
            panel2.Controls.Add(SongAuthorLabel);
            panel2.Controls.Add(SongNameLabel);
            panel2.Controls.Add(SongPicBox);
            panel2.ForeColor = Color.FromArgb(15, 15, 15);
            panel2.Location = new Point(0, 512);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 114);
            panel2.TabIndex = 10;
            // 
            // MaxSongTimeLabel
            // 
            MaxSongTimeLabel.AutoSize = true;
            MaxSongTimeLabel.ForeColor = Color.White;
            MaxSongTimeLabel.Location = new Point(592, 70);
            MaxSongTimeLabel.Name = "MaxSongTimeLabel";
            MaxSongTimeLabel.Size = new Size(34, 15);
            MaxSongTimeLabel.TabIndex = 8;
            MaxSongTimeLabel.Text = "99:99";
            // 
            // CurrSongTimeLabel
            // 
            CurrSongTimeLabel.AutoSize = true;
            CurrSongTimeLabel.BackColor = Color.FromArgb(20, 20, 20);
            CurrSongTimeLabel.ForeColor = Color.White;
            CurrSongTimeLabel.Location = new Point(258, 70);
            CurrSongTimeLabel.Name = "CurrSongTimeLabel";
            CurrSongTimeLabel.Size = new Size(34, 15);
            CurrSongTimeLabel.TabIndex = 7;
            CurrSongTimeLabel.Text = "00:00";
            // 
            // SongTrackBar
            // 
            SongTrackBar.Location = new Point(307, 65);
            SongTrackBar.Margin = new Padding(3, 2, 3, 2);
            SongTrackBar.Name = "SongTrackBar";
            SongTrackBar.Size = new Size(280, 45);
            SongTrackBar.TabIndex = 6;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(20, 20, 20);
            NextBtn.Cursor = Cursors.Hand;
            NextBtn.FlatAppearance.BorderSize = 0;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.Font = new Font("Segoe UI Symbol", 16F);
            NextBtn.ForeColor = Color.FromArgb(255, 128, 0);
            NextBtn.Location = new Point(481, 15);
            NextBtn.Margin = new Padding(3, 2, 3, 2);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(25, 35);
            NextBtn.TabIndex = 5;
            NextBtn.Text = "⏭";
            NextBtn.UseVisualStyleBackColor = false;
            // 
            // PreviousBtn
            // 
            PreviousBtn.BackColor = Color.FromArgb(20, 20, 20);
            PreviousBtn.Cursor = Cursors.Hand;
            PreviousBtn.FlatAppearance.BorderSize = 0;
            PreviousBtn.FlatStyle = FlatStyle.Flat;
            PreviousBtn.Font = new Font("Segoe UI Symbol", 16F);
            PreviousBtn.ForeColor = Color.FromArgb(255, 128, 0);
            PreviousBtn.Location = new Point(386, 14);
            PreviousBtn.Margin = new Padding(0);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new Size(24, 37);
            PreviousBtn.TabIndex = 4;
            PreviousBtn.Text = "⏮";
            PreviousBtn.UseVisualStyleBackColor = false;
            // 
            // Play_PauseBtn
            // 
            Play_PauseBtn.BackColor = Color.FromArgb(255, 128, 0);
            Play_PauseBtn.Cursor = Cursors.Hand;
            Play_PauseBtn.FlatAppearance.BorderSize = 0;
            Play_PauseBtn.FlatStyle = FlatStyle.Flat;
            Play_PauseBtn.Font = new Font("Arial", 18F, FontStyle.Bold);
            Play_PauseBtn.ForeColor = Color.Black;
            Play_PauseBtn.Location = new Point(418, 10);
            Play_PauseBtn.Margin = new Padding(0);
            Play_PauseBtn.Name = "Play_PauseBtn";
            Play_PauseBtn.Size = new Size(52, 45);
            Play_PauseBtn.TabIndex = 3;
            Play_PauseBtn.Text = " ▶";
            Play_PauseBtn.UseVisualStyleBackColor = false;
            // 
            // SongAuthorLabel
            // 
            SongAuthorLabel.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SongAuthorLabel.ForeColor = SystemColors.ControlDark;
            SongAuthorLabel.Location = new Point(101, 39);
            SongAuthorLabel.Name = "SongAuthorLabel";
            SongAuthorLabel.Size = new Size(201, 32);
            SongAuthorLabel.TabIndex = 2;
            SongAuthorLabel.Text = "Song Author";
            // 
            // SongNameLabel
            // 
            SongNameLabel.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SongNameLabel.ForeColor = SystemColors.Control;
            SongNameLabel.Location = new Point(101, 10);
            SongNameLabel.Name = "SongNameLabel";
            SongNameLabel.Size = new Size(201, 29);
            SongNameLabel.TabIndex = 1;
            SongNameLabel.Text = "Song Name";
            // 
            // SongPicBox
            // 
            SongPicBox.Location = new Point(10, 10);
            SongPicBox.Margin = new Padding(3, 2, 3, 2);
            SongPicBox.Name = "SongPicBox";
            SongPicBox.Size = new Size(85, 61);
            SongPicBox.TabIndex = 0;
            SongPicBox.TabStop = false;
            // 
            // BackGround
            // 
            BackGround.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackGround.BackColor = Color.FromArgb(24, 24, 24);
            BackGround.Controls.Add(label2);
            BackGround.FlowDirection = FlowDirection.TopDown;
            BackGround.Location = new Point(0, -1);
            BackGround.Name = "BackGround";
            BackGround.Size = new Size(884, 52);
            BackGround.TabIndex = 11;
            // 
            // MusicHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(879, 623);
            Controls.Add(BackGround);
            Controls.Add(panel2);
            Controls.Add(btnSongsRightPlaylist);
            Controls.Add(btnSongsLeftPlaylist);
            Controls.Add(label1);
            Controls.Add(lblSongs);
            Controls.Add(flowSongs);
            Controls.Add(lblPlaylists);
            Controls.Add(flowPlaylists);
            Controls.Add(btnSongsLeft);
            Controls.Add(btnSongsRight);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MusicHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            Load += MusicHistoryForm_Load;
            flowSongs.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMusicCard).EndInit();
            flowPlaylists.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlaylist).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SongTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)SongPicBox).EndInit();
            BackGround.ResumeLayout(false);
            BackGround.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


        }


        #endregion

        private Label label1;
        private Label label2;
        private Button btnSongsLeft;
        private Button btnSongsRight;
        private Button btnSongsLeftPlaylist;
        private Button btnSongsRightPlaylist;
        private Panel panel2;
        private Label MaxSongTimeLabel;
        private Label CurrSongTimeLabel;
        private TrackBar SongTrackBar;
        private Button NextBtn;
        private Button PreviousBtn;
        private Button Play_PauseBtn;
        private Label SongAuthorLabel;
        private Label SongNameLabel;
        private PictureBox SongPicBox;
        private FlowLayoutPanel BackGround;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBoxMusicCard;
        private Label NameOfSongMusicCard;
        private Label ArtistNameMusicCard;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBoxPlaylist;
        private Label PlaylistName;
    }
}