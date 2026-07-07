namespace Music_App
{
    partial class SigninForm
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
            llSignup = new LinkLabel();
            labelPasswordMessage = new Label();
            labelUsernameMessage = new Label();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnSignin = new Button();
            labelPasword = new Label();
            labelUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            labelSingin = new Label();
            SuspendLayout();
            // 
            // llSignup
            // 
            llSignup.ActiveLinkColor = Color.FromArgb(255, 128, 0);
            llSignup.AutoSize = true;
            llSignup.Font = new Font("Sitka Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            llSignup.LinkColor = Color.Yellow;
            llSignup.Location = new Point(12, 544);
            llSignup.Name = "llSignup";
            llSignup.Size = new Size(221, 20);
            llSignup.TabIndex = 34;
            llSignup.TabStop = true;
            llSignup.Text = "Dont have an account? Sign up";
            llSignup.LinkClicked += llSignup_LinkClicked;
            // 
            // labelPasswordMessage
            // 
            labelPasswordMessage.AutoSize = true;
            labelPasswordMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            labelPasswordMessage.ForeColor = Color.FromArgb(255, 128, 0);
            labelPasswordMessage.Location = new Point(62, 359);
            labelPasswordMessage.Name = "labelPasswordMessage";
            labelPasswordMessage.Size = new Size(138, 16);
            labelPasswordMessage.TabIndex = 33;
            labelPasswordMessage.Text = "passwordMessage";
            labelPasswordMessage.Visible = false;
            // 
            // labelUsernameMessage
            // 
            labelUsernameMessage.AutoSize = true;
            labelUsernameMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            labelUsernameMessage.ForeColor = Color.FromArgb(255, 128, 0);
            labelUsernameMessage.Location = new Point(62, 229);
            labelUsernameMessage.Name = "labelUsernameMessage";
            labelUsernameMessage.Size = new Size(109, 16);
            labelUsernameMessage.TabIndex = 32;
            labelUsernameMessage.Text = "nameMessage";
            labelUsernameMessage.Visible = false;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(25, 25, 25);
            pnlTitleBar.Location = new Point(-3, -3);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(245, 45);
            pnlTitleBar.TabIndex = 31;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            pnlTitleBar.MouseMove += pnlTitleBar_MouseMove;
            pnlTitleBar.MouseUp += pnlTitleBar_MouseUp;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(20, 20, 20);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClose.ForeColor = Color.FromArgb(255, 128, 0);
            btnClose.Location = new Point(335, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 40);
            btnClose.TabIndex = 30;
            btnClose.Text = "×";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.FromArgb(20, 20, 20);
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMaximize.ForeColor = Color.FromArgb(255, 128, 0);
            btnMaximize.Location = new Point(289, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(45, 40);
            btnMaximize.TabIndex = 29;
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btnMaximize_MouseEnter;
            btnMaximize.MouseLeave += btnMaximize_MouseLeave;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(20, 20, 20);
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.FromArgb(255, 128, 0);
            btnMinimize.Location = new Point(243, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 40);
            btnMinimize.TabIndex = 28;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.FromArgb(255, 128, 0);
            btnSignin.FlatAppearance.BorderColor = Color.FromArgb(37, 37, 37);
            btnSignin.FlatAppearance.BorderSize = 5;
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignin.ForeColor = SystemColors.ActiveCaptionText;
            btnSignin.Location = new Point(100, 426);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(200, 49);
            btnSignin.TabIndex = 27;
            btnSignin.Text = "SIGN IN";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            btnSignin.MouseEnter += btnSignin_MouseEnter;
            btnSignin.MouseLeave += btnSignin_MouseLeave;
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPasword.ForeColor = Color.FromArgb(255, 128, 0);
            labelPasword.Location = new Point(94, 281);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(206, 28);
            labelPasword.TabIndex = 26;
            labelPasword.Text = "Enter your password";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelUsername.ForeColor = Color.FromArgb(255, 128, 0);
            labelUsername.Location = new Point(104, 154);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(209, 28);
            labelUsername.TabIndex = 25;
            labelUsername.Text = "Enter your username";
            labelUsername.Click += labelEmail_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI Emoji", 10.8F);
            txtPassword.ForeColor = Color.FromArgb(255, 128, 0);
            txtPassword.Location = new Point(62, 323);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 31);
            txtPassword.TabIndex = 24;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(30, 30, 30);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Segoe UI Emoji", 10.8F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(62, 193);
            txtUsername.Margin = new Padding(5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 31);
            txtUsername.TabIndex = 23;
            // 
            // labelSingin
            // 
            labelSingin.BackColor = Color.FromArgb(0, 0, 0, 0);
            labelSingin.Font = new Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSingin.ForeColor = Color.FromArgb(255, 128, 0);
            labelSingin.Location = new Point(62, 40);
            labelSingin.Name = "labelSingin";
            labelSingin.Size = new Size(280, 128);
            labelSingin.TabIndex = 22;
            labelSingin.Text = "Sign in";
            // 
            // SigninForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(382, 573);
            Controls.Add(llSignup);
            Controls.Add(labelPasswordMessage);
            Controls.Add(labelUsernameMessage);
            Controls.Add(pnlTitleBar);
            Controls.Add(btnClose);
            Controls.Add(btnMaximize);
            Controls.Add(btnMinimize);
            Controls.Add(btnSignin);
            Controls.Add(labelPasword);
            Controls.Add(labelUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(labelSingin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SigninForm";
            Text = "SigninForm";
            Load += SigninForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llSignup;
        private Label labelPasswordMessage;
        private Label labelUsernameMessage;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnSignin;
        private Label labelPasword;
        private Label labelUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label labelSingin;
    }
}