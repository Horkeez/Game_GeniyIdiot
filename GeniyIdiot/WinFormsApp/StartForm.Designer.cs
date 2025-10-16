namespace WinFormsApp
{
    partial class StartForm
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
            startGameButton = new Button();
            namePromptLabel = new Label();
            userNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // startGameButton
            // 
            startGameButton.Font = new Font("Segoe UI", 45F, FontStyle.Bold);
            startGameButton.Location = new Point(221, 265);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(358, 134);
            startGameButton.TabIndex = 6;
            startGameButton.Text = "Старт";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // namePromptLabel
            // 
            namePromptLabel.AutoSize = true;
            namePromptLabel.Font = new Font("Segoe UI", 20F);
            namePromptLabel.Location = new Point(232, 52);
            namePromptLabel.Name = "namePromptLabel";
            namePromptLabel.Size = new Size(347, 46);
            namePromptLabel.TabIndex = 8;
            namePromptLabel.Text = "Напишите свое имя :";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Segoe UI", 16F);
            userNameTextBox.Location = new Point(221, 162);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(358, 43);
            userNameTextBox.TabIndex = 7;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(startGameButton);
            Controls.Add(namePromptLabel);
            Controls.Add(userNameTextBox);
            Name = "StartForm";
            Text = "StartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startGameButton;
        private Label namePromptLabel;
        private TextBox userNameTextBox;
    }
}