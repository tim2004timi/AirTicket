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
    public partial class CencelTicketForm : Form
    {
        public CencelTicketForm()
        {
            InitializeComponent();
            OutputTickets();
        }

        // метод вывода всех заявок
        private void OutputTickets()
        {
            // проходимся циклом по всем рейсам
            foreach (Race race in Program.data.racesList)
            {
                // прозодимся циклом по всем заявкам в рейсе
                foreach (string ticket in race.ticketsList)
                {
                    // выводим заявку на экран ввиде списка
                    ticketsListBox.Items.Add(ticket);
                }
            }
        }

        // нажатие на кнопку "отменить заявку"
        private void CancelTicketButton_Click(object sender, EventArgs e)
        {
            // если вообще выбранна заявка
            if (ticketsListBox.SelectedItem != null)
            {
                // копируем список, чтоб по нему пройтись циклом и удалить элемент
                List<Race> racesList1 = Program.data.racesList.ToList();

                foreach (Race race in racesList1)
                {
                    // копируем список, чтоб по нему пройтись циклом и удалить элемент
                    List<string> ticketsList1 = race.ticketsList.ToList();

                    foreach (string ticket in race.ticketsList)
                    {
                        if (ticketsListBox.SelectedItem.ToString() == ticket)
                        {
                            // удаляем заявку из списка
                            race.ticketsList.Remove(ticket);
                            race.seats++;

                            // получаем поток, куда будем записывать сериализованный объект
                            using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
                            {
                                Program.formatter.Serialize(fs, Program.data);
                            }

                            break;
                        }
                    }
                }
                // очищаем весь список на экране
                ticketsListBox.Items.Clear();

                // выводим новый список
                OutputTickets();
            }
        }

        // нажатие на кнопку выхода из окна
        private void CencelTicketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // нажатие на картинку "назад"
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // преходим в окно пользователя
            UserForm userForm = new UserForm();
            this.Hide();
            userForm.Show();
        }
    }
}
