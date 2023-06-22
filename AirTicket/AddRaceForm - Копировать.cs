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

        private void AddRaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private bool CheckCorrectData()
        {
            if ((companyTextBox.Text == "") || (fromPlaceTextBox.Text == "") ||
               (toPlaceTextBox.Text == "") || (priceTextBox.Text == "") || (seatTextBox.Text == ""))
                return false;

            else if (fromPlaceTextBox.Text.Any(char.IsDigit) ||
                toPlaceTextBox.Text.Any(char.IsDigit))
                return false;

            else if (!seatTextBox.Text.All(char.IsDigit))
                return false;

            else if (int.Parse(seatTextBox.Text) <= 0)
                return false;

            else if (!priceTextBox.Text.All(char.IsDigit))
                return false;

            else if (int.Parse(priceTextBox.Text) <= 0)
                return false;
            
            return true;
        }

        private void addRaceButton_Click(object sender, EventArgs e)
        {
            if (CheckCorrectData()) {
                DateTime varDate;
                varDate = dateTimePicker1.Value;
                string data = varDate.ToShortDateString().Substring(0, 5);

                Program.data.racesList.Add(new Race(companyTextBox.Text, data, fromPlaceTextBox.Text, toPlaceTextBox.Text, int.Parse(seatTextBox.Text), int.Parse(priceTextBox.Text)));

                // получаем поток, куда будем записывать сериализованный объект
                using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
                {
                    Program.formatter.Serialize(fs, Program.data);
                }

                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.Show();

            }
            else
                incorrectText.Visible = true;
        }
    }
}
