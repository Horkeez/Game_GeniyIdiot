using GeniyIdiotCommon;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> _questions;
        private int _currentIndexQuestion;
        private Question _currentQuestion;
        private User _user;
        private Diagnose _diagnose;
        private int _countQuestions;
        private int _numberQuestion;
        private string _userName;
        private int _countCorrectAnswers;

        public enum FormType
        {
            AddQuestionForm,
            AllQuestionForm,
            ResultsForm
        }

        public MainForm(string userName)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += StartForm.Closing;

            _userName = userName;
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            _questions = QuestionsRepository.GetMixedQuestions();
            _countQuestions = _questions.Count;
            ShowNextQuestion();
            questionTextLabel.Text = _currentQuestion.Text;
        }

        private void ShowNextQuestion()
        {
            if (_currentIndexQuestion < _countQuestions)
            {
                _currentQuestion = _questions[_currentIndexQuestion];
                _currentIndexQuestion++;
                questionTextLabel.Text = _currentQuestion.Text;
                _numberQuestion++;
                numberQuestionLabel.Text = $"Âîïðîñ ¹ {_numberQuestion.ToString()}";
                userAnswerTextBox.Text = string.Empty;
                userAnswerTextBox.Focus();
            }
            else
            {
                _diagnose = new Diagnose(_countQuestions, _countCorrectAnswers);
                _user = new User(_userName, _diagnose, _countCorrectAnswers);
                UsersResultRepository.Add(_user);
                questionTextLabel.Text = string.Empty;
                numberQuestionLabel.Text = string.Empty;
                userAnswerTextBox.Text = string.Empty;

                MessageBox.Show($"{_user.ToString()}", "Èãðà îêîí÷åíà",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = userAnswerTextBox.Text;
            if (GetValidUserResponse(userAnswer))
            {
                if (Convert.ToInt32(userAnswer) == _currentQuestion.Answer)
                {
                    _countCorrectAnswers++;
                }
                ShowNextQuestion();
            }
        }

        private bool GetValidUserResponse(string answer)
        {
            try
            {
                Convert.ToInt32(answer);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Âû ââåëè íå ÷èñëîâîå çíà÷åíèå, ïîïðîáóéòå åùå ðàç", "Îøèáêà ââîäà",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Âû ââåëè ñëèøêîì áîëüøîå ÷èñëî", "Îøèáêà ââîäà",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void OpenForm(FormType formType)
        {
            Hide();
            Form form = null;

            switch (formType)
            {
                case FormType.AddQuestionForm:
                    form = new AddQuestionForm();
                    break;
                case FormType.AllQuestionForm:
                    form = new AllQuestionForm();
                    break;
                case FormType.ResultsForm:
                    form = new ResultsForm();
                    break;
            }

            if (form != null)
            {
                form.ShowDialog();
            }

            Show();
        }

        private void ïåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClosing -= StartForm.Closing;
            StartForm startForm = new StartForm();
            startForm.Show();
            Close();
        }

        private void äîáàâèòüÂîïðîñToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenForm(FormType.AddQuestionForm);
        }

        private void óäàëèòüÂîïðîñToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenForm(FormType.AllQuestionForm);
        }

        private void ðåçóëüòàòûToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenForm(FormType.ResultsForm);
        }

        private void âûéòèToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Âû äåéñòâèòåëüíî õîòèòåòå çàêðûòü ïðèëîæåíèå?",
            "Ïîäòâåðæäåíèå",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void LoadData<T>(List<T> items, ListBox listBox)
        {
            listBox.Items.Clear();

            for (int i = 0; i < items.Count; i++)
            {
                listBox.Items.Add($"{i + 1}. {items[i].ToString()}");
            }
        }
    }
}
