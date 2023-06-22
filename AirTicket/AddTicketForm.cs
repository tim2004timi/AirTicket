using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicket
{
    partial class AddTicketForm : Form
    {
        Race race;

        public AddTicketForm(Race race)
        {
            InitializeComponent();
            this.race = race;
        }

        // нажатие на выход из окна
        private void AddTicketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // метод проверки на коректность данных
        private bool CheckCorrect()
        {
            // данные введены
            if ((surnameTextBox.Text == "") || (nameTextBox.Text == "") ||
               (fatherNameTextBox.Text == "") || (passportTextBox.Text == ""))
                return false;

            // фамилия, имя и отчество состоят только из символов
            else if ((surnameTextBox.Text.Any(char.IsDigit) ||
                nameTextBox.Text.Any(char.IsDigit)) ||
                fatherNameTextBox.Text.Any(char.IsDigit))
                return false;

            // номер паспорта состоит только из цифр
            else if (!passportTextBox.Text.All(char.IsDigit))
                return false;

            return true;
        }

        // нажатие на кнопку добавить рейс
        private void addRaceButton_Click(object sender, EventArgs e)
        {
            if (CheckCorrect())
            {
                race.seats--;
                // добавляем в заявку в список заявок в данном рейсе
                race.ticketsList.Add($"{surnameTextBox.Text} {nameTextBox.Text} {fatherNameTextBox.Text} | {race.fromPlace} - {race.toPlace} | {race.date}");              

                // получаем поток, куда будем записывать сериализованный объект
                using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
                {
                    Program.formatter.Serialize(fs, Program.data);
                }

                // возвращаемся в окно пользователя
                UserForm userForm = new UserForm();
                this.Hide();
                userForm.Show();
            }
            // если данные не корректны, то появляется соответствующая надпись
            else incorrectText.Visible = true;
        }
    }
}
