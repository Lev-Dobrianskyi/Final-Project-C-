namespace TestStyle
{
    partial class SigninForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            labelEmail = new Label();
            labelPasword = new Label();
            btnLogin = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(255, 128, 0);
            lblLogin.Location = new Point(46, 55);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(194, 79);
            lblLogin.TabIndex = 9;
            lblLogin.Text = "Login";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(30, 30, 30);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI Emoji", 10.8F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(23, 175);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI Emoji", 10.8F);
            txtPassword.ForeColor = Color.FromArgb(255, 128, 0);
            txtPassword.Location = new Point(23, 257);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(245, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelEmail.ForeColor = Color.FromArgb(255, 128, 0);
            labelEmail.Location = new Point(60, 144);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(137, 21);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Enter your gmail";
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPasword.ForeColor = Color.FromArgb(255, 128, 0);
            labelPasword.Location = new Point(51, 226);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(165, 21);
            labelPasword.TabIndex = 4;
            labelPasword.Text = "Enter your password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(60, 311);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(175, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(209, -1);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(39, 34);
            button1.TabIndex = 6;
            button1.Text = "_";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 20, 20);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(245, -1);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(39, 34);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // SigninForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(labelPasword);
            Controls.Add(labelEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SigninForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label labelEmail;
        private Label labelPasword;
        private Button btnLogin;
        private Button button1;
        private Button button2;
    }
}
