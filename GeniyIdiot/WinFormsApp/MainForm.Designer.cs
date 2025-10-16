namespace WinFormsApp
{
    partial class MainForm
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
            nextButton = new Button();
            questionTextLabel = new Label();
            numberQuestionLabel = new Label();
            userAnswerTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            результатыToolStripMenuItem = new ToolStripMenuItem();
            пеToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(230, 256);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(235, 87);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionTextLabel.Location = new Point(12, 93);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(140, 25);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса :";
            // 
            // numberQuestionLabel
            // 
            numberQuestionLabel.AutoSize = true;
            numberQuestionLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberQuestionLabel.Location = new Point(302, 32);
            numberQuestionLabel.Name = "numberQuestionLabel";
            numberQuestionLabel.Size = new Size(95, 31);
            numberQuestionLabel.TabIndex = 1;
            numberQuestionLabel.Text = "Вопрос";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userAnswerTextBox.Location = new Point(230, 162);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(235, 34);
            userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem, выйтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(727, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, удалитьToolStripMenuItem, результатыToolStripMenuItem, пеToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(65, 24);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(224, 26);
            добавитьToolStripMenuItem.Text = "Добавить вопрос";
            добавитьToolStripMenuItem.Click += добавитьВопросToolStripMenuItem_Click_1;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(224, 26);
            удалитьToolStripMenuItem.Text = "Все вопросы";
            удалитьToolStripMenuItem.Click += удалитьВопросToolStripMenuItem_Click_1;
            // 
            // результатыToolStripMenuItem
            // 
            результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            результатыToolStripMenuItem.Size = new Size(224, 26);
            результатыToolStripMenuItem.Text = "Результаты";
            результатыToolStripMenuItem.Click += результатыToolStripMenuItem_Click_1;
            // 
            // пеToolStripMenuItem
            // 
            пеToolStripMenuItem.Name = "пеToolStripMenuItem";
            пеToolStripMenuItem.Size = new Size(224, 26);
            пеToolStripMenuItem.Text = "Перезапустить";
            пеToolStripMenuItem.Click += пеToolStripMenuItem_Click;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(67, 24);
            выйтиToolStripMenuItem.Text = "Выйти";
            выйтиToolStripMenuItem.Click += выйтиToolStripMenuItem_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 412);
            Controls.Add(menuStrip1);
            Controls.Add(nextButton);
            Controls.Add(questionTextLabel);
            Controls.Add(numberQuestionLabel);
            Controls.Add(userAnswerTextBox);
            Name = "MainForm";
            Text = "Гений Идиот";
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label numberQuestionLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem результатыToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem пеToolStripMenuItem;
    }
}
