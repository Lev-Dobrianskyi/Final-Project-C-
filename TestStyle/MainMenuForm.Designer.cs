namespace TestStyle
{
    partial class MainMenuForm
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
            SigninButton = new Button();
            SignupButton = new Button();
            CreateSongBtnRMM = new Button();
            HistoryBtnRMM = new Button();
            PlaylistsBtnRMM = new Button();
            SearchBtnRMM = new Button();
            EnjoyMusicRMMTEXT = new Label();
            UserNameRMMLabel = new Label();
            GreetingRMMTEXT = new Label();
            SuspendLayout();
            // 
            // SigninButton
            // 
            SigninButton.BackColor = Color.FromArgb(40, 40, 40);
            SigninButton.FlatStyle = FlatStyle.Popup;
            SigninButton.ForeColor = SystemColors.Control;
            SigninButton.Location = new Point(815, 16);
            SigninButton.Margin = new Padding(3, 4, 3, 4);
            SigninButton.Name = "SigninButton";
            SigninButton.Size = new Size(86, 31);
            SigninButton.TabIndex = 0;
            SigninButton.Text = "Sign in";
            SigninButton.UseVisualStyleBackColor = false;
            SigninButton.Click += SigninButton_Click;
            // 
            // SignupButton
            // 
            SignupButton.BackColor = Color.FromArgb(40, 40, 40);
            SignupButton.FlatStyle = FlatStyle.Popup;
            SignupButton.ForeColor = SystemColors.Control;
            SignupButton.Location = new Point(722, 16);
            SignupButton.Margin = new Padding(3, 4, 3, 4);
            SignupButton.Name = "SignupButton";
            SignupButton.Size = new Size(86, 31);
            SignupButton.TabIndex = 1;
            SignupButton.Text = "Sign up";
            SignupButton.UseVisualStyleBackColor = false;
            // 
            // CreateSongBtnRMM
            // 
            CreateSongBtnRMM.BackColor = Color.FromArgb(20, 20, 20);
            CreateSongBtnRMM.Font = new Font("Sitka Banner", 12F);
            CreateSongBtnRMM.ForeColor = Color.FromArgb(255, 128, 0);
            CreateSongBtnRMM.Location = new Point(356, 394);
            CreateSongBtnRMM.Name = "CreateSongBtnRMM";
            CreateSongBtnRMM.Size = new Size(202, 70);
            CreateSongBtnRMM.TabIndex = 9;
            CreateSongBtnRMM.Text = "Create song";
            CreateSongBtnRMM.UseVisualStyleBackColor = false;
            CreateSongBtnRMM.Click += CreateSongBtnRMM_Click;
            // 
            // HistoryBtnRMM
            // 
            HistoryBtnRMM.BackColor = Color.FromArgb(20, 20, 20);
            HistoryBtnRMM.Font = new Font("Sitka Banner", 12F);
            HistoryBtnRMM.ForeColor = Color.FromArgb(255, 128, 0);
            HistoryBtnRMM.Location = new Point(356, 308);
            HistoryBtnRMM.Name = "HistoryBtnRMM";
            HistoryBtnRMM.Size = new Size(202, 70);
            HistoryBtnRMM.TabIndex = 8;
            HistoryBtnRMM.Text = "History";
            HistoryBtnRMM.UseVisualStyleBackColor = false;
            HistoryBtnRMM.Click += HistoryBtnRMM_Click;
            // 
            // PlaylistsBtnRMM
            // 
            PlaylistsBtnRMM.BackColor = Color.FromArgb(20, 20, 20);
            PlaylistsBtnRMM.Font = new Font("Sitka Banner", 12F);
            PlaylistsBtnRMM.ForeColor = Color.FromArgb(255, 128, 0);
            PlaylistsBtnRMM.Location = new Point(356, 222);
            PlaylistsBtnRMM.Name = "PlaylistsBtnRMM";
            PlaylistsBtnRMM.Size = new Size(202, 70);
            PlaylistsBtnRMM.TabIndex = 7;
            PlaylistsBtnRMM.Text = "Playlists";
            PlaylistsBtnRMM.UseVisualStyleBackColor = false;
            PlaylistsBtnRMM.Click += PlaylistsBtnRMM_Click;
            // 
            // SearchBtnRMM
            // 
            SearchBtnRMM.BackColor = Color.FromArgb(20, 20, 20);
            SearchBtnRMM.Font = new Font("Sitka Banner", 12F);
            SearchBtnRMM.ForeColor = Color.FromArgb(255, 128, 0);
            SearchBtnRMM.Location = new Point(356, 137);
            SearchBtnRMM.Name = "SearchBtnRMM";
            SearchBtnRMM.Size = new Size(202, 70);
            SearchBtnRMM.TabIndex = 6;
            SearchBtnRMM.Text = "Search";
            SearchBtnRMM.UseVisualStyleBackColor = false;
            SearchBtnRMM.Click += SearchBtnRMM_Click;
            // 
            // EnjoyMusicRMMTEXT
            // 
            EnjoyMusicRMMTEXT.AutoSize = true;
            EnjoyMusicRMMTEXT.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EnjoyMusicRMMTEXT.ForeColor = SystemColors.Control;
            EnjoyMusicRMMTEXT.Location = new Point(346, 499);
            EnjoyMusicRMMTEXT.Name = "EnjoyMusicRMMTEXT";
            EnjoyMusicRMMTEXT.Size = new Size(227, 43);
            EnjoyMusicRMMTEXT.TabIndex = 12;
            EnjoyMusicRMMTEXT.Text = "Enjoy your music!";
            // 
            // UserNameRMMLabel
            // 
            UserNameRMMLabel.AutoSize = true;
            UserNameRMMLabel.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserNameRMMLabel.ForeColor = Color.FromArgb(255, 128, 0);
            UserNameRMMLabel.Location = new Point(425, 50);
            UserNameRMMLabel.Name = "UserNameRMMLabel";
            UserNameRMMLabel.Size = new Size(133, 39);
            UserNameRMMLabel.TabIndex = 11;
            UserNameRMMLabel.Text = "UserName!";
            // 
            // GreetingRMMTEXT
            // 
            GreetingRMMTEXT.AutoSize = true;
            GreetingRMMTEXT.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GreetingRMMTEXT.ForeColor = SystemColors.Control;
            GreetingRMMTEXT.Location = new Point(356, 50);
            GreetingRMMTEXT.Name = "GreetingRMMTEXT";
            GreetingRMMTEXT.Size = new Size(76, 39);
            GreetingRMMTEXT.TabIndex = 10;
            GreetingRMMTEXT.Text = "Hello,";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(914, 600);
            Controls.Add(EnjoyMusicRMMTEXT);
            Controls.Add(UserNameRMMLabel);
            Controls.Add(GreetingRMMTEXT);
            Controls.Add(CreateSongBtnRMM);
            Controls.Add(HistoryBtnRMM);
            Controls.Add(PlaylistsBtnRMM);
            Controls.Add(SearchBtnRMM);
            Controls.Add(SignupButton);
            Controls.Add(SigninButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SigninButton;
        private Button SignupButton;
        private Button CreateSongBtnRMM;
        private Button HistoryBtnRMM;
        private Button PlaylistsBtnRMM;
        private Button SearchBtnRMM;
        private Label EnjoyMusicRMMTEXT;
        private Label UserNameRMMLabel;
        private Label GreetingRMMTEXT;
    }
}