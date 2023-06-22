using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirTicket
{
    public partial class AddRaceForm : Form
    {
        public AddRaceForm()
        {
            InitializeComponent();
        }

        // нажатие на выход из окна
        private void AddRaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // метод проверки введенных данных
        private bool CheckCorrectData()
        {
            // проверка на наличие введенных данных
            if ((companyTextBox.Text == "") || (fromPlaceTextBox.Text == "") ||
               (toPlaceTextBox.Text == "") || (priceTextBox.Text == "") || (seatTextBox.Text == "")) 
                return false;

            // место вылета и прибытия состоит только из символов
            else if (fromPlaceTextBox.Text.Any(char.IsDigit) ||
                toPlaceTextBox.Text.Any(char.IsDigit))
                return false;

            // кол-во мест состоит толко их цифр
            else if (!seatTextBox.Text.All(char.IsDigit))
                return false;

            // кол-во мест больше нуля
            else if (int.Parse(seatTextBox.Text) <= 0)
                return false;

            // цена состоит только из цифр
            else if (!priceTextBox.Text.All(char.IsDigit))
                return false;

            // цена больше 0
            else if (int.Parse(priceTextBox.Text) <= 0)
                return false;
            
            return true;
        }

        // нажатие на кнопку "добавить рейс"
        private void addRaceButton_Click(object sender, EventArgs e)
        {
            if (CheckCorrectData()) {
                // записываем дату в переменную date
                DateTime varDate;
                varDate = dateTimePicker1.Value;
                string data = varDate.ToShortDateString().Substring(0, 5);

                // добавляем новый рейс в список всех рейсов
                Program.data.racesList.Add(new Race(companyTextBox.Text, data, fromPlaceTextBox.Text, toPlaceTextBox.Text, int.Parse(seatTextBox.Text), int.Parse(priceTextBox.Text)));

                // получаем поток, куда будем записывать сериализованный объект
                using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
                {
                    Program.formatter.Serialize(fs, Program.data);
                }

                // возвращаемся в окно администратора
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.Show();

            }
            // если данные не корректны, то появляется соответстующая надпись
            else
                incorrectText.Visible = true;
        }
    }
}
