namespace Music_App
{
    partial class SongMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongMenu));
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
            songTimer = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SongTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SongPicBox).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 20);
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
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 97);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // MaxSongTimeLabel
            // 
            MaxSongTimeLabel.AutoSize = true;
            MaxSongTimeLabel.BackColor = Color.FromArgb(20, 20, 20);
            MaxSongTimeLabel.ForeColor = Color.White;
            MaxSongTimeLabel.Location = new Point(592, 70);
            MaxSongTimeLabel.Name = "MaxSongTimeLabel";
            MaxSongTimeLabel.Size = new Size(28, 15);
            MaxSongTimeLabel.TabIndex = 8;
            MaxSongTimeLabel.Text = "2:56";
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
            SongTrackBar.Maximum = 100;
            SongTrackBar.Name = "SongTrackBar";
            SongTrackBar.Size = new Size(280, 45);
            SongTrackBar.TabIndex = 6;
            SongTrackBar.Scroll += SongTrackBar_Scroll;
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
            NextBtn.Click += NextBtn_Click;
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
            PreviousBtn.Click += PreviousBtn_Click;
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
            Play_PauseBtn.Click += Play_PauseBtn_Click;
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
            SongPicBox.ErrorImage = Properties.Resources.img2;
            SongPicBox.Image = Properties.Resources.img2;
            SongPicBox.InitialImage = Properties.Resources.img2;
            SongPicBox.Location = new Point(10, 10);
            SongPicBox.Margin = new Padding(3, 2, 3, 2);
            SongPicBox.Name = "SongPicBox";
            SongPicBox.Size = new Size(75, 75);
            SongPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SongPicBox.TabIndex = 0;
            SongPicBox.TabStop = false;
            // 
            // songTimer
            // 
            songTimer.Interval = 500;
            songTimer.Tick += songTimer_Tick;
            // 
            // SongMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 97);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SongMenu";
            Text = "SongMenu";
            FormClosing += SongMenu_FormClosing;
            Load += SongMenu_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SongTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)SongPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

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
        private System.Windows.Forms.Timer songTimer;
    }
}