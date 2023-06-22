using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicket
{
    public partial class AdminPasswordForm : Form
    {
        private string PASSWORD = "admin";

        public AdminPasswordForm()
        {
            InitializeComponent();
            passwordBox.AutoSize = false;
        }

        // нажатие на картинку назад
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            this.Hide();
            menuForm.Show();
        }

        // нажатие на кнопку вход
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == PASSWORD)
            {
                // переход в окно администратора
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.Show();
            }
            else
            {
                // высвечивается надпись "пароль неверен"
                wrongPasswordLabel.Visible = true;
            }
        }

        // нажатие на крестик
        private void AdminPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
