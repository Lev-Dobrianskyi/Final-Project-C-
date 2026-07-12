namespace Music_App.Forms
{
    partial class SongCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongCreationForm));
            panel1 = new Panel();
            ProgramPic = new PictureBox();
            HomeBtn = new Button();
            userImg = new PictureBox();
            SCFLbl = new Label();
            panel2 = new Panel();
            txtDate = new TextBox();
            txtGenre = new TextBox();
            txtTitle = new TextBox();
            pnlDynamicContent = new Panel();
            songBox = new Panel();
            songGenreLabel = new Label();
            songPictureBox = new PictureBox();
            songLengthLabel = new Label();
            songAuthorLabel = new Label();
            songTitleLabel = new Label();
            panel3 = new Panel();
            btnCreate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProgramPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userImg).BeginInit();
            panel2.SuspendLayout();
            pnlDynamicContent.SuspendLayout();
            songBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)songPictureBox).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ProgramPic);
            panel1.Controls.Add(HomeBtn);
            panel1.Controls.Add(userImg);
            panel1.Controls.Add(SCFLbl);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1340, 125);
            panel1.TabIndex = 0;
            // 
            // ProgramPic
            // 
            ProgramPic.Image = (Image)resources.GetObject("ProgramPic.Image");
            ProgramPic.Location = new Point(417, 25);
            ProgramPic.Name = "ProgramPic";
            ProgramPic.Size = new Size(64, 64);
            ProgramPic.SizeMode = PictureBoxSizeMode.StretchImage;
            ProgramPic.TabIndex = 12;
            ProgramPic.TabStop = false;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.FromArgb(25, 25, 25);
            HomeBtn.FlatStyle = FlatStyle.Popup;
            HomeBtn.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = Color.FromArgb(255, 128, 0);
            HomeBtn.Location = new Point(1089, 35);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(120, 40);
            HomeBtn.TabIndex = 11;
            HomeBtn.Text = "HOME";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // userImg
            // 
            userImg.Image = (Image)resources.GetObject("userImg.Image");
            userImg.Location = new Point(1233, 25);
            userImg.Name = "userImg";
            userImg.Size = new Size(64, 64);
            userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            userImg.TabIndex = 10;
            userImg.TabStop = false;
            // 
            // SCFLbl
            // 
            SCFLbl.AutoSize = true;
            SCFLbl.Font = new Font("Tempus Sans ITC", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SCFLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SCFLbl.Location = new Point(25, 25);
            SCFLbl.Name = "SCFLbl";
            SCFLbl.Size = new Size(362, 49);
            SCFLbl.TabIndex = 0;
            SCFLbl.Text = "Song Creation Menu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 23, 23);
            panel2.Controls.Add(txtDate);
            panel2.Controls.Add(txtGenre);
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(pnlDynamicContent);
            panel2.Location = new Point(12, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(1340, 332);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.FromArgb(25, 25, 25);
            txtDate.BorderStyle = BorderStyle.FixedSingle;
            txtDate.ForeColor = Color.FromArgb(255, 128, 0);
            txtDate.Location = new Point(23, 122);
            txtDate.Name = "txtDate";
            txtDate.PlaceholderText = "DD.MM.YYYY";
            txtDate.Size = new Size(250, 27);
            txtDate.TabIndex = 4;
            // 
            // txtGenre
            // 
            txtGenre.BackColor = Color.FromArgb(25, 25, 25);
            txtGenre.BorderStyle = BorderStyle.FixedSingle;
            txtGenre.ForeColor = Color.FromArgb(255, 128, 0);
            txtGenre.Location = new Point(23, 69);
            txtGenre.Name = "txtGenre";
            txtGenre.PlaceholderText = "Genre";
            txtGenre.Size = new Size(250, 27);
            txtGenre.TabIndex = 2;
            txtGenre.TextChanged += txtGenre_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(25, 25, 25);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.ForeColor = Color.FromArgb(255, 128, 0);
            txtTitle.Location = new Point(23, 17);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Name";
            txtTitle.Size = new Size(250, 27);
            txtTitle.TabIndex = 1;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // pnlDynamicContent
            // 
            pnlDynamicContent.BackColor = Color.FromArgb(27, 27, 27);
            pnlDynamicContent.Controls.Add(songBox);
            pnlDynamicContent.Location = new Point(279, 17);
            pnlDynamicContent.Name = "pnlDynamicContent";
            pnlDynamicContent.Size = new Size(1038, 284);
            pnlDynamicContent.TabIndex = 0;
            // 
            // songBox
            // 
            songBox.BorderStyle = BorderStyle.FixedSingle;
            songBox.Controls.Add(songGenreLabel);
            songBox.Controls.Add(songPictureBox);
            songBox.Controls.Add(songLengthLabel);
            songBox.Controls.Add(songAuthorLabel);
            songBox.Controls.Add(songTitleLabel);
            songBox.Cursor = Cursors.Hand;
            songBox.Location = new Point(15, 15);
            songBox.Margin = new Padding(3, 4, 3, 4);
            songBox.Name = "songBox";
            songBox.Size = new Size(976, 77);
            songBox.TabIndex = 11;
            // 
            // songGenreLabel
            // 
            songGenreLabel.Font = new Font("Sitka Banner", 12F);
            songGenreLabel.ForeColor = SystemColors.ControlDark;
            songGenreLabel.Location = new Point(415, 39);
            songGenreLabel.Name = "songGenreLabel";
            songGenreLabel.Size = new Size(343, 35);
            songGenreLabel.TabIndex = 9;
            songGenreLabel.Text = "Genre";
            // 
            // songPictureBox
            // 
            songPictureBox.Image = (Image)resources.GetObject("songPictureBox.Image");
            songPictureBox.Location = new Point(8, 12);
            songPictureBox.Name = "songPictureBox";
            songPictureBox.Size = new Size(51, 51);
            songPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            songPictureBox.TabIndex = 5;
            songPictureBox.TabStop = false;
            // 
            // songLengthLabel
            // 
            songLengthLabel.Font = new Font("Sitka Banner", 14F);
            songLengthLabel.ForeColor = SystemColors.ControlDark;
            songLengthLabel.Location = new Point(906, 12);
            songLengthLabel.Name = "songLengthLabel";
            songLengthLabel.Size = new Size(62, 37);
            songLengthLabel.TabIndex = 8;
            songLengthLabel.Text = "99:99";
            // 
            // songAuthorLabel
            // 
            songAuthorLabel.Font = new Font("Sitka Banner", 12F);
            songAuthorLabel.ForeColor = SystemColors.ControlDark;
            songAuthorLabel.Location = new Point(65, 39);
            songAuthorLabel.Name = "songAuthorLabel";
            songAuthorLabel.Size = new Size(343, 35);
            songAuthorLabel.TabIndex = 7;
            songAuthorLabel.Text = "Song Author";
            // 
            // songTitleLabel
            // 
            songTitleLabel.AutoEllipsis = true;
            songTitleLabel.Font = new Font("Sylfaen", 16F);
            songTitleLabel.ForeColor = SystemColors.ButtonShadow;
            songTitleLabel.Location = new Point(65, 3);
            songTitleLabel.Name = "songTitleLabel";
            songTitleLabel.Size = new Size(562, 40);
            songTitleLabel.TabIndex = 6;
            songTitleLabel.Text = "Song Title";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCreate);
            panel3.Location = new Point(12, 481);
            panel3.Name = "panel3";
            panel3.Size = new Size(1340, 150);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(30, 30, 30);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold);
            btnCreate.ForeColor = Color.FromArgb(255, 128, 0);
            btnCreate.Location = new Point(658, 45);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 60);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // SongCreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1364, 643);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SongCreationForm";
            Text = "SongCreationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProgramPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)userImg).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlDynamicContent.ResumeLayout(false);
            songBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)songPictureBox).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label SCFLbl;
        private Panel panel2;
        private Panel panel3;
        private Panel pnlDynamicContent;
        private Panel songBox;
        private Label songGenreLabel;
        private PictureBox songPictureBox;
        private Label songLengthLabel;
        private Label songAuthorLabel;
        private Label songTitleLabel;
        private TextBox txtGenre;
        private TextBox txtTitle;
        private TextBox txtDate;
        private Button btnCreate;
        private Button HomeBtn;
        private PictureBox userImg;
        private PictureBox ProgramPic;
    }
}