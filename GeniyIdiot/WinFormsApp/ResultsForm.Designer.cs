namespace WinFormsApp
{
    partial class ResultsForm
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
            listBoxResults = new ListBox();
            labelForAll = new Label();
            buttunBack = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(70, 113);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(660, 188);
            listBoxResults.TabIndex = 8;
            // 
            // labelForAll
            // 
            labelForAll.AutoSize = true;
            labelForAll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelForAll.Location = new Point(306, 67);
            labelForAll.Name = "labelForAll";
            labelForAll.Size = new Size(166, 28);
            labelForAll.TabIndex = 7;
            labelForAll.Text = "Все результаты :";
            // 
            // buttunBack
            // 
            buttunBack.Font = new Font("Segoe UI Semibold", 15.8F, FontStyle.Bold);
            buttunBack.Location = new Point(306, 332);
            buttunBack.Name = "buttunBack";
            buttunBack.Size = new Size(168, 52);
            buttunBack.TabIndex = 6;
            buttunBack.Text = "Назад";
            buttunBack.UseVisualStyleBackColor = true;
            buttunBack.Click += buttonBack_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(labelForAll);
            Controls.Add(buttunBack);
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxResults;
        private Label labelForAll;
        private Button buttunBack;
    }
}