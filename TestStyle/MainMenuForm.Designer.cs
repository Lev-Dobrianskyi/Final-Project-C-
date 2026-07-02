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
            SigninButton.Location = new Point(713, 12);
            SigninButton.Name = "SigninButton";
            SigninButton.Size = new Size(75, 23);
            SigninButton.TabIndex = 0;
            SigninButton.Text = "Sign in";
            SigninButton.UseVisualStyleBackColor = true;
            SigninButton.Click += SigninButton_Click;
            // 
            // SignupButton
            // 
            SignupButton.Location = new Point(632, 12);
            SignupButton.Name = "SignupButton";
            SignupButton.Size = new Size(75, 23);
            SignupButton.TabIndex = 1;
            SignupButton.Text = "Sign up";
            SignupButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SignupButton);
            Controls.Add(SigninButton);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button SigninButton;
        private Button SignupButton;
    }
}