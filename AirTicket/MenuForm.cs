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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        // нажатие на кнопку выход
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // нажатие на кнопку 
        private void enterAdminButton_Click(object sender, EventArgs e)
        {
            AdminPasswordForm adminPasswordForm = new AdminPasswordForm();
            this.Hide();
            adminPasswordForm.Show();
        }

        // нажатие на кнопку
        private void enterUserButton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            this.Hide();
            userForm.Show();
        }

        // нажатие на кнопку
        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
