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
            lblPasswordMessage = new Label();
            lblEmailMessage = new Label();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnSignup = new Button();
            labelPasword = new Label();
            labelEmail = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblLogin = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            lblUserMessage = new Label();
            lblConfirmPassword = new Label();
            lblConfirmPasswordMessage = new Label();
            txtConfirmPassword = new TextBox();
            llLogin = new LinkLabel();
            SuspendLayout();
            // 
            // lblPasswordMessage
            // 
            lblPasswordMessage.AutoSize = true;
            lblPasswordMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            lblPasswordMessage.ForeColor = Color.FromArgb(255, 128, 0);
            lblPasswordMessage.Location = new Point(60, 428);
            lblPasswordMessage.Name = "lblPasswordMessage";
            lblPasswordMessage.Size = new Size(138, 16);
            lblPasswordMessage.TabIndex = 46;
            lblPasswordMessage.Text = "passwordMessage";
            lblPasswordMessage.Visible = false;
            // 
            // lblEmailMessage
            // 
            lblEmailMessage.AutoSize = true;
            lblEmailMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            lblEmailMessage.ForeColor = Color.FromArgb(255, 128, 0);
            lblEmailMessage.Location = new Point(60, 314);
            lblEmailMessage.Name = "lblEmailMessage";
            lblEmailMessage.Size = new Size(109, 16);
            lblEmailMessage.TabIndex = 45;
            lblEmailMessage.Text = "emailMessage";
            lblEmailMessage.Visible = false;
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
            // lblLogin
            // 
            lblLogin.Font = new Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(255, 128, 0);
            lblLogin.Location = new Point(37, 32);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(318, 128);
            lblLogin.TabIndex = 35;
            lblLogin.Text = "Sign up";
            lblLogin.Click += lblLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(93, 146);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 47;
            label1.Text = "Enter your username ";
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
            // lblUserMessage
            // 
            lblUserMessage.AutoSize = true;
            lblUserMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            lblUserMessage.ForeColor = Color.FromArgb(255, 128, 0);
            lblUserMessage.Location = new Point(60, 211);
            lblUserMessage.Name = "lblUserMessage";
            lblUserMessage.Size = new Size(101, 16);
            lblUserMessage.TabIndex = 49;
            lblUserMessage.Text = "userMessage";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(255, 128, 0);
            lblConfirmPassword.Location = new Point(80, 465);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(232, 28);
            lblConfirmPassword.TabIndex = 50;
            lblConfirmPassword.Text = "Confirm your password";
            // 
            // lblConfirmPasswordMessage
            // 
            lblConfirmPasswordMessage.AutoSize = true;
            lblConfirmPasswordMessage.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold | FontStyle.Italic);
            lblConfirmPasswordMessage.ForeColor = Color.FromArgb(255, 128, 0);
            lblConfirmPasswordMessage.Location = new Point(60, 530);
            lblConfirmPasswordMessage.Name = "lblConfirmPasswordMessage";
            lblConfirmPasswordMessage.Size = new Size(189, 16);
            lblConfirmPasswordMessage.TabIndex = 51;
            lblConfirmPasswordMessage.Text = "confirmPasswordMessage";
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
            Controls.Add(lblConfirmPasswordMessage);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblUserMessage);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(lblPasswordMessage);
            Controls.Add(lblEmailMessage);
            Controls.Add(pnlTitleBar);
            Controls.Add(btnClose);
            Controls.Add(btnMaximize);
            Controls.Add(btnMinimize);
            Controls.Add(btnSignup);
            Controls.Add(labelPasword);
            Controls.Add(labelEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignupForm";
            Text = "SignupForm";
            Load += SignupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPasswordMessage;
        private Label lblEmailMessage;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnSignup;
        private Label labelPasword;
        private Label labelEmail;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblLogin;
        private Label label1;
        private TextBox txtUsername;
        private Label lblUserMessage;
        private Label lblConfirmPassword;
        private Label lblConfirmPasswordMessage;
        private TextBox txtConfirmPassword;
        private LinkLabel llLogin;
    }
}