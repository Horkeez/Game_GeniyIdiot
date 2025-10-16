namespace WinFormsApp
{
    partial class AllQuestionForm
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
            buttonAction = new Button();
            buttonBack = new Button();
            questionsDataGridView = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonAction
            // 
            buttonAction.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            buttonAction.Location = new Point(266, 379);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(156, 64);
            buttonAction.TabIndex = 6;
            buttonAction.Text = "Удалить";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += buttonAction_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI Semibold", 15.8F, FontStyle.Bold);
            buttonBack.Location = new Point(628, 386);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(124, 52);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            questionsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2 });
            questionsDataGridView.Location = new Point(12, 12);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RowHeadersWidth = 51;
            questionsDataGridView.Size = new Size(740, 356);
            questionsDataGridView.TabIndex = 11;
            questionsDataGridView.MultiSelect = false;
            questionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // Column3
            // 
            Column3.HeaderText = "№";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 55;
            // 
            // Column1
            // 
            Column1.HeaderText = "Текст";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 74;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ответ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 77;
            // 
            // AllQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(questionsDataGridView);
            Controls.Add(buttonBack);
            Controls.Add(buttonAction);
            Name = "AllQuestionForm";
            Text = "AllQuestionForm";
            Load += AllQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonAction;
        private Button buttonBack;
        private DataGridView questionsDataGridView;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}