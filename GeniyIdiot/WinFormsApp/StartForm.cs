using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GeniyIdiotCommon;

namespace WinFormsApp
{
    public partial class StartForm : Form
    {
        private string _userName;

        public StartForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += Closing;
        }

        public static void Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите Ваше имя!", "Ошибка ввода",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _userName = userNameTextBox.Text;

            Hide();

            MainForm mainForm = new MainForm(_userName);
            mainForm.Show();
        }
        
    }
}
