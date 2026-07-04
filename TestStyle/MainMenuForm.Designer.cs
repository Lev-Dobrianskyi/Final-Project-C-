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
            SuspendLayout();
            // 
            // SigninButton
            // 
            SigninButton.Location = new Point(815, 16);
            SigninButton.Margin = new Padding(3, 4, 3, 4);
            SigninButton.Name = "SigninButton";
            SigninButton.Size = new Size(86, 31);
            SigninButton.TabIndex = 0;
            SigninButton.Text = "Sign in";
            SigninButton.UseVisualStyleBackColor = true;
            SigninButton.Click += SigninButton_Click;
            // 
            // SignupButton
            // 
            SignupButton.Location = new Point(722, 16);
            SignupButton.Margin = new Padding(3, 4, 3, 4);
            SignupButton.Name = "SignupButton";
            SignupButton.Size = new Size(86, 31);
            SignupButton.TabIndex = 1;
            SignupButton.Text = "Sign up";
            SignupButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(SignupButton);
            Controls.Add(SigninButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button SigninButton;
        private Button SignupButton;
    }
}