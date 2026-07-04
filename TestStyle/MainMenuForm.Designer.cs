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
            button1 = new Button();
            SuspendLayout();
            // 
            // SigninButton
            // 
            SigninButton.Location = new Point(713, 12);
            SigninButton.Name = "SigninButton";
            SigninButton.Size = new Size(75, 23);
            SigninButton.TabIndex = 2;
            SigninButton.Text = "Sign in";
            SigninButton.UseVisualStyleBackColor = true;
            SigninButton.Click += SigninButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(632, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(SigninButton);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ResumeLayout(false);
        }

        #endregion
        private Button SigninButton;
        private Button button1;
    }
}