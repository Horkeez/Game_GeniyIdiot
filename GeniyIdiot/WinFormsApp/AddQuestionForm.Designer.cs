namespace WinFormsApp
{
    partial class AddQuestionForm
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
            buttonAdd = new Button();
            textBoxAddAnswer = new TextBox();
            textBoxAddQuestion = new TextBox();
            labelAddAnswer = new Label();
            labelForAll = new Label();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI Semibold", 15.8F, FontStyle.Bold);
            buttonAdd.Location = new Point(304, 317);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(168, 52);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxAddAnswer
            // 
            textBoxAddAnswer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxAddAnswer.Location = new Point(304, 241);
            textBoxAddAnswer.Name = "textBoxAddAnswer";
            textBoxAddAnswer.Size = new Size(168, 31);
            textBoxAddAnswer.TabIndex = 8;
            // 
            // textBoxAddQuestion
            // 
            textBoxAddQuestion.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxAddQuestion.Location = new Point(70, 115);
            textBoxAddQuestion.Name = "textBoxAddQuestion";
            textBoxAddQuestion.Size = new Size(660, 31);
            textBoxAddQuestion.TabIndex = 7;
            // 
            // labelAddAnswer
            // 
            labelAddAnswer.AutoSize = true;
            labelAddAnswer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddAnswer.Location = new Point(304, 198);
            labelAddAnswer.Name = "labelAddAnswer";
            labelAddAnswer.Size = new Size(179, 28);
            labelAddAnswer.TabIndex = 6;
            labelAddAnswer.Text = "Напишите ответ :";
            // 
            // labelForAll
            // 
            labelForAll.AutoSize = true;
            labelForAll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelForAll.Location = new Point(288, 56);
            labelForAll.Name = "labelForAll";
            labelForAll.Size = new Size(195, 28);
            labelForAll.TabIndex = 5;
            labelForAll.Text = "Напишите вопрос :";
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI Semibold", 15.8F, FontStyle.Bold);
            buttonBack.Location = new Point(631, 371);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(124, 52);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(textBoxAddAnswer);
            Controls.Add(textBoxAddQuestion);
            Controls.Add(labelAddAnswer);
            Controls.Add(labelForAll);
            Controls.Add(buttonAdd);
            Name = "AddQuestionForm";
            Text = "AddQuestionFormcs";
            Load += AddQuestionFormcs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox textBoxAddAnswer;
        private TextBox textBoxAddQuestion;
        private Label labelAddAnswer;
        private Label labelForAll;
        private Button buttonBack;
    }
}