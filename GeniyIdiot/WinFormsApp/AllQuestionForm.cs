using GeniyIdiotCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AllQuestionForm : Form
    {
        public AllQuestionForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AllQuestionForm_Load(object sender, EventArgs e)
        {
            RefreshQuestionsTable();
        }

        private void RefreshQuestionsTable()
        {
            var questions = QuestionsRepository.GetAll();

            if (questions.Count == 0)
            {
                QuestionsRepository.Save(QuestionsRepository.GetDefaultQuestions());
                questions = QuestionsRepository.GetAll();
                MessageBox.Show("Загружены базовые вопросы.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            questionsDataGridView.Rows.Clear();
            for (int i = 0; i < questions.Count; i++)
            {
                questionsDataGridView.Rows.Add(i + 1, questions[i].Text, questions[i].Answer);
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            try
            {
                int index = questionsDataGridView.SelectedRows[0].Index;

                QuestionsRepository.DeleteByIndex(index);
                questionsDataGridView.Rows.RemoveAt(index);

                for (int i = 0; i < questionsDataGridView.Rows.Count - 1; i++)
                {
                    questionsDataGridView.Rows[i].Cells[0].Value = i + 1;
                }

                MessageBox.Show("Вопрос успешно удален!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (questionsDataGridView.Rows.Count <= 1)
                {
                    RefreshQuestionsTable();
                }
            }
            catch
            {
                MessageBox.Show("Выберите вопрос для удаления!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}