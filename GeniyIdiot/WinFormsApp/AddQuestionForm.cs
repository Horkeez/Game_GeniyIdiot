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
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddQuestionFormcs_Load(object sender, EventArgs e)
        {
            QuestionsRepository.GetAll();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddQuestion.Text))
            {
                MessageBox.Show("Пожалуйста, введите текст вопроса!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxAddAnswer.Text, out int answer))
            {
                MessageBox.Show("Ответ должен быть целым числом!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            QuestionsRepository.Add(textBoxAddQuestion.Text, answer);

            MessageBox.Show("Вопрос успешно добавлен!", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
