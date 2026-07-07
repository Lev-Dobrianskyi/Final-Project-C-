namespace Music_App
{
    partial class SignupForm
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
            labePasswordMessage = new Label();
            labelEmailMessage = new Label();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnSignup = new Button();
            labelPasword = new Label();
            labelEmail = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            labelSingup = new Label();
            labelUsername = new Label();
            txtUsername = new TextBox();
            labelUserMessage = new Label();
            labelConfirmPassword = new Label();
            labelConfirmPasswordMessage = new Label();
            txtConfirmPassword = new TextBox();
            llLogin = new LinkLabel();
            SuspendLayout();
            // 
            // labePasswordMessage
            // 
            labePasswordMessage.AutoSize = true;
            labePasswordMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            labePasswordMessage.ForeColor = Color.FromArgb(255, 128, 0);
            labePasswordMessage.Location = new Point(60, 428);
            labePasswordMessage.Name = "labePasswordMessage";
            labePasswordMessage.Size = new Size(138, 16);
            labePasswordMessage.TabIndex = 46;
            labePasswordMessage.Text = "passwordMessage";
            labePasswordMessage.Visible = false;
            // 
            // labelEmailMessage
            // 
            labelEmailMessage.AutoSize = true;
            labelEmailMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            labelEmailMessage.ForeColor = Color.FromArgb(255, 128, 0);
            labelEmailMessage.Location = new Point(60, 314);
            labelEmailMessage.Name = "labelEmailMessage";
            labelEmailMessage.Size = new Size(109, 16);
            labelEmailMessage.TabIndex = 45;
            labelEmailMessage.Text = "emailMessage";
            labelEmailMessage.Visible = false;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(25, 25, 25);
            pnlTitleBar.Location = new Point(-3, -3);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(245, 45);
            pnlTitleBar.TabIndex = 44;
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
            btnClose.TabIndex = 43;
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
            btnMaximize.TabIndex = 42;
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
            btnMinimize.TabIndex = 41;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(255, 128, 0);
            btnSignup.FlatAppearance.BorderColor = Color.FromArgb(37, 37, 37);
            btnSignup.FlatAppearance.BorderSize = 5;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = SystemColors.ActiveCaptionText;
            btnSignup.Location = new Point(99, 566);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(200, 49);
            btnSignup.TabIndex = 40;
            btnSignup.Text = "SIGN UP";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            btnSignup.MouseEnter += btnSignup_MouseEnter;
            btnSignup.MouseLeave += btnSignup_MouseLeave;
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPasword.ForeColor = Color.FromArgb(255, 128, 0);
            labelPasword.Location = new Point(93, 359);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(206, 28);
            labelPasword.TabIndex = 39;
            labelPasword.Text = "Enter your password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelEmail.ForeColor = Color.FromArgb(255, 128, 0);
            labelEmail.Location = new Point(112, 245);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(169, 28);
            labelEmail.TabIndex = 38;
            labelEmail.Text = "Enter your email";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI Emoji", 10.8F);
            txtPassword.ForeColor = Color.FromArgb(255, 128, 0);
            txtPassword.Location = new Point(56, 392);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 31);
            txtPassword.TabIndex = 37;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(30, 30, 30);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI Emoji", 10.8F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(56, 278);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 31);
            txtEmail.TabIndex = 36;
            // 
            // labelSingup
            // 
            labelSingup.Font = new Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSingup.ForeColor = Color.FromArgb(255, 128, 0);
            labelSingup.Location = new Point(37, 32);
            labelSingup.Name = "labelSingup";
            labelSingup.Size = new Size(318, 128);
            labelSingup.TabIndex = 35;
            labelSingup.Text = "Sign up";
            labelSingup.Click += lblLogin_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUsername.ForeColor = Color.FromArgb(255, 128, 0);
            labelUsername.Location = new Point(93, 146);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(215, 28);
            labelUsername.TabIndex = 47;
            labelUsername.Text = "Enter your username ";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(30, 30, 30);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI Emoji", 10.8F);
            txtUsername.Location = new Point(56, 177);
            txtUsername.MaxLength = 24;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 31);
            txtUsername.TabIndex = 48;
            // 
            // labelUserMessage
            // 
            labelUserMessage.AutoSize = true;
            labelUserMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            labelUserMessage.ForeColor = Color.FromArgb(255, 128, 0);
            labelUserMessage.Location = new Point(60, 211);
            labelUserMessage.Name = "labelUserMessage";
            labelUserMessage.Size = new Size(101, 16);
            labelUserMessage.TabIndex = 49;
            labelUserMessage.Text = "userMessage";
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelConfirmPassword.ForeColor = Color.FromArgb(255, 128, 0);
            labelConfirmPassword.Location = new Point(80, 465);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(232, 28);
            labelConfirmPassword.TabIndex = 50;
            labelConfirmPassword.Text = "Confirm your password";
            // 
            // labelConfirmPasswordMessage
            // 
            labelConfirmPasswordMessage.AutoSize = true;
            labelConfirmPasswordMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            labelConfirmPasswordMessage.ForeColor = Color.FromArgb(255, 128, 0);
            labelConfirmPasswordMessage.Location = new Point(60, 530);
            labelConfirmPasswordMessage.Name = "labelConfirmPasswordMessage";
            labelConfirmPasswordMessage.Size = new Size(189, 16);
            labelConfirmPasswordMessage.TabIndex = 51;
            labelConfirmPasswordMessage.Text = "confirmPasswordMessage";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI Emoji", 10.8F);
            txtConfirmPassword.Location = new Point(56, 496);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(280, 31);
            txtConfirmPassword.TabIndex = 52;
            // 
            // llLogin
            // 
            llLogin.ActiveLinkColor = Color.FromArgb(255, 192, 128);
            llLogin.AutoSize = true;
            llLogin.Font = new Font("Sitka Text", 8.25F, FontStyle.Bold);
            llLogin.LinkColor = Color.Yellow;
            llLogin.Location = new Point(12, 644);
            llLogin.Name = "llLogin";
            llLogin.Size = new Size(238, 20);
            llLogin.TabIndex = 53;
            llLogin.TabStop = true;
            llLogin.Text = "Already have an account? Sign in";
            llLogin.LinkClicked += llLogin_LinkClicked_1;
            llLogin.Click += lblLogin_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(382, 673);
            Controls.Add(llLogin);
            Controls.Add(txtConfirmPassword);
            Controls.Add(labelConfirmPasswordMessage);
            Controls.Add(labelConfirmPassword);
            Controls.Add(labelUserMessage);
            Controls.Add(txtUsername);
            Controls.Add(labelUsername);
            Controls.Add(labePasswordMessage);
            Controls.Add(labelEmailMessage);
            Controls.Add(pnlTitleBar);
            Controls.Add(btnClose);
            Controls.Add(btnMaximize);
            Controls.Add(btnMinimize);
            Controls.Add(btnSignup);
            Controls.Add(labelPasword);
            Controls.Add(labelEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(labelSingup);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignupForm";
            Text = "SignupForm";
            Load += SignupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labePasswordMessage;
        private Label labelEmailMessage;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnSignup;
        private Label labelPasword;
        private Label labelEmail;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label labelSingup;
        private Label labelUsername;
        private TextBox txtUsername;
        private Label labelUserMessage;
        private Label labelConfirmPassword;
        private Label labelConfirmPasswordMessage;
        private TextBox txtConfirmPassword;
        private LinkLabel llLogin;
    }
}