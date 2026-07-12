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
            panel1.Controls.Add(HomeBtn);
            panel1.Controls.Add(userImg);
            panel1.Controls.Add(SCFLbl);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 94);
            panel1.TabIndex = 0;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.FromArgb(25, 25, 25);
            HomeBtn.FlatStyle = FlatStyle.Popup;
            HomeBtn.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = Color.FromArgb(255, 128, 0);
            HomeBtn.Location = new Point(953, 26);
            HomeBtn.Margin = new Padding(3, 2, 3, 2);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(105, 30);
            HomeBtn.TabIndex = 11;
            HomeBtn.Text = "HOME";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // userImg
            // 
            userImg.BorderStyle = BorderStyle.FixedSingle;
            userImg.Image = (Image)resources.GetObject("userImg.Image");
            userImg.Location = new Point(1087, 9);
            userImg.Margin = new Padding(3, 2, 3, 2);
            userImg.Name = "userImg";
            userImg.Size = new Size(75, 75);
            userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            userImg.TabIndex = 10;
            userImg.TabStop = false;
            // 
            // SCFLbl
            // 
            SCFLbl.AutoSize = true;
            SCFLbl.Font = new Font("Tempus Sans ITC", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SCFLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SCFLbl.Location = new Point(22, 19);
            SCFLbl.Name = "SCFLbl";
            SCFLbl.Size = new Size(298, 39);
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
            panel2.Location = new Point(10, 107);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1172, 249);
            panel2.TabIndex = 1;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.FromArgb(25, 25, 25);
            txtDate.BorderStyle = BorderStyle.FixedSingle;
            txtDate.ForeColor = Color.FromArgb(255, 128, 0);
            txtDate.Location = new Point(20, 92);
            txtDate.Margin = new Padding(3, 2, 3, 2);
            txtDate.Name = "txtDate";
            txtDate.PlaceholderText = "DD.MM.YYYY";
            txtDate.Size = new Size(219, 23);
            txtDate.TabIndex = 4;
            // 
            // txtGenre
            // 
            txtGenre.BackColor = Color.FromArgb(25, 25, 25);
            txtGenre.BorderStyle = BorderStyle.FixedSingle;
            txtGenre.ForeColor = Color.FromArgb(255, 128, 0);
            txtGenre.Location = new Point(20, 52);
            txtGenre.Margin = new Padding(3, 2, 3, 2);
            txtGenre.Name = "txtGenre";
            txtGenre.PlaceholderText = "Genre";
            txtGenre.Size = new Size(219, 23);
            txtGenre.TabIndex = 2;
            txtGenre.TextChanged += txtGenre_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(25, 25, 25);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.ForeColor = Color.FromArgb(255, 128, 0);
            txtTitle.Location = new Point(20, 13);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Name";
            txtTitle.Size = new Size(219, 23);
            txtTitle.TabIndex = 1;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // pnlDynamicContent
            // 
            pnlDynamicContent.BackColor = Color.FromArgb(27, 27, 27);
            pnlDynamicContent.Controls.Add(songBox);
            pnlDynamicContent.Location = new Point(244, 13);
            pnlDynamicContent.Margin = new Padding(3, 2, 3, 2);
            pnlDynamicContent.Name = "pnlDynamicContent";
            pnlDynamicContent.Size = new Size(908, 213);
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
            songBox.Location = new Point(13, 11);
            songBox.Name = "songBox";
            songBox.Size = new Size(854, 58);
            songBox.TabIndex = 11;
            // 
            // songGenreLabel
            // 
            songGenreLabel.Font = new Font("Sitka Banner", 12F);
            songGenreLabel.ForeColor = SystemColors.ControlDark;
            songGenreLabel.Location = new Point(363, 29);
            songGenreLabel.Name = "songGenreLabel";
            songGenreLabel.Size = new Size(300, 26);
            songGenreLabel.TabIndex = 9;
            songGenreLabel.Text = "Genre";
            // 
            // songPictureBox
            // 
            songPictureBox.BorderStyle = BorderStyle.FixedSingle;
            songPictureBox.Image = (Image)resources.GetObject("songPictureBox.Image");
            songPictureBox.Location = new Point(8, 8);
            songPictureBox.Margin = new Padding(3, 2, 3, 2);
            songPictureBox.Name = "songPictureBox";
            songPictureBox.Size = new Size(40, 40);
            songPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            songPictureBox.TabIndex = 5;
            songPictureBox.TabStop = false;
            // 
            // songLengthLabel
            // 
            songLengthLabel.Font = new Font("Sitka Banner", 14F);
            songLengthLabel.ForeColor = SystemColors.ControlDark;
            songLengthLabel.Location = new Point(793, 9);
            songLengthLabel.Name = "songLengthLabel";
            songLengthLabel.Size = new Size(54, 28);
            songLengthLabel.TabIndex = 8;
            songLengthLabel.Text = "99:99";
            // 
            // songAuthorLabel
            // 
            songAuthorLabel.Font = new Font("Sitka Banner", 12F);
            songAuthorLabel.ForeColor = SystemColors.ControlDark;
            songAuthorLabel.Location = new Point(57, 29);
            songAuthorLabel.Name = "songAuthorLabel";
            songAuthorLabel.Size = new Size(300, 26);
            songAuthorLabel.TabIndex = 7;
            songAuthorLabel.Text = "Song Author";
            // 
            // songTitleLabel
            // 
            songTitleLabel.AutoEllipsis = true;
            songTitleLabel.Font = new Font("Sylfaen", 16F);
            songTitleLabel.ForeColor = SystemColors.ButtonShadow;
            songTitleLabel.Location = new Point(57, 2);
            songTitleLabel.Name = "songTitleLabel";
            songTitleLabel.Size = new Size(492, 30);
            songTitleLabel.TabIndex = 6;
            songTitleLabel.Text = "Song Title";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCreate);
            panel3.Location = new Point(10, 361);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1172, 112);
            panel3.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(30, 30, 30);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold);
            btnCreate.ForeColor = Color.FromArgb(255, 128, 0);
            btnCreate.Location = new Point(576, 34);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(131, 45);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // SongCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1194, 482);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "SongCreationForm";
            Text = "SongCreationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}