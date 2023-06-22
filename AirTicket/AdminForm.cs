using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicket
{
    public partial class AdminForm : Form
    {
        private List<HelperRace> helperRacesList = new List<HelperRace>(); 

        public AdminForm()
        {
            InitializeComponent();
            OutputRaces();
        }

        // метод вывода всех рейсов
        private void OutputRaces()
        {
            int racePositionX = 17;
            int racePositionY = 140;
            int raceIntervalY = 95;

            // циклом проходимся по всему списку рейсов
            foreach (Race race in Program.data.racesList)
            {
                // объект, который принимает в себя текущую директорию
                var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                HelperRace helperRace = new HelperRace();
                helperRace.race = race;

                Panel panel = new Panel();
                helperRace.panel = panel;
                PictureBox pictureSeat = new PictureBox();
                Label labelSeat = new Label();
                PictureBox pictureCancel = new PictureBox();
                helperRace.pictureEvent = pictureCancel;
                Label labelDate = new Label();
                PictureBox pictureDate = new PictureBox();
                PictureBox picturePlane = new PictureBox();
                Label labelCompany = new Label();
                Label labelCity = new Label();
                Label labelPrice = new Label();

                ((System.ComponentModel.ISupportInitialize)(pictureSeat)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(pictureCancel)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(pictureDate)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(picturePlane)).BeginInit();

                // 
                // panel
                // 
                panel.BackColor = System.Drawing.Color.White;
                panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panel.Controls.Add(labelPrice);
                panel.Controls.Add(pictureDate);
                panel.Controls.Add(pictureSeat);
                panel.Controls.Add(labelSeat);
                panel.Controls.Add(pictureCancel);
                panel.Controls.Add(labelDate);
                panel.Controls.Add(picturePlane);
                panel.Controls.Add(labelCompany);
                panel.Controls.Add(labelCity);
                panel.Location = new System.Drawing.Point(racePositionX, racePositionY);
                panel.Name = "panel";
                panel.Size = new System.Drawing.Size(1150, 80);
                panel.TabIndex = 0;
                // 
                // pictureSeat
                // 
                pictureSeat.Image = Image.FromFile(@"..\..\images\4049292_holiday_sit_tourism_travel_vacation_icon.png");
                pictureSeat.Location = new System.Drawing.Point(933, 40);
                pictureSeat.Name = "pictureSeat";
                pictureSeat.Size = new System.Drawing.Size(40, 40);
                pictureSeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureSeat.TabIndex = 7;
                pictureSeat.TabStop = false;
                // 
                // labelSeat
                // 
                labelSeat.AutoSize = true;
                labelSeat.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelSeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
                labelSeat.Location = new System.Drawing.Point(874, 45);
                labelSeat.Name = "labelSeat";
                labelSeat.Size = new System.Drawing.Size(53, 31);
                labelSeat.TabIndex = 6;
                labelSeat.Text = race.seats.ToString();
                // 
                // pictureCancel
                // 
                pictureCancel.Image = Image.FromFile(@"..\..\images\1891023_cancel_cercle_close_delete_dismiss_icon.png");
                pictureCancel.Location = new System.Drawing.Point(1075, 10);
                pictureCancel.Name = "pictureCancel";
                pictureCancel.Size = new System.Drawing.Size(60, 60);
                pictureCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureCancel.TabIndex = 5;
                pictureCancel.TabStop = false;
                pictureCancel.Click += new System.EventHandler(pictureEvent_Click);
                // 
                // labelDate
                // 
                labelDate.AutoSize = true;
                labelDate.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
                labelDate.Location = new System.Drawing.Point(532, 20);
                labelDate.Name = "labelDate";
                labelDate.Size = new System.Drawing.Size(94, 41);
                labelDate.TabIndex = 4;
                labelDate.Text = race.date.ToString();
                // 
                // pictureDate
                // 
                pictureDate.Image = Image.FromFile(@"..\..\images\115762_calendar_date_event_month_icon.png");
                pictureDate.Location = new System.Drawing.Point(648, 15);
                pictureDate.Name = "pictureDate";
                pictureDate.Size = new System.Drawing.Size(50, 50);
                pictureDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureDate.TabIndex = 3;
                pictureDate.TabStop = false;
                // 
                // picturePlane
                // 
                picturePlane.Image = Image.FromFile(@"..\..\images\103733_plane_transportation_icon.png");
                picturePlane.Location = new System.Drawing.Point(8, 3);
                picturePlane.Name = "picturePlane";
                picturePlane.Size = new System.Drawing.Size(72, 72);
                picturePlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                picturePlane.TabIndex = 2;
                picturePlane.TabStop = false;
                // 
                // labelCompany
                // 
                labelCompany.AutoSize = true;
                labelCompany.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelCompany.ForeColor = System.Drawing.Color.Gray;
                labelCompany.Location = new System.Drawing.Point(87, 3);
                labelCompany.Name = "labelCompany";
                labelCompany.Size = new System.Drawing.Size(75, 28);
                labelCompany.TabIndex = 1;
                labelCompany.Text = race.company;
                // 
                // labelCity
                // 
                labelCity.AutoSize = true;
                labelCity.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold);
                labelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
                labelCity.Location = new System.Drawing.Point(85, 40);
                labelCity.Name = "labelCity";
                labelCity.Size = new System.Drawing.Size(251, 38);
                labelCity.TabIndex = 0;
                labelCity.Text = $"{race.fromPlace} - {race.toPlace}";
                // 
                // labelPrice
                // 
                labelPrice.AutoSize = true;
                labelPrice.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
                labelPrice.Location = new System.Drawing.Point(872, -1);
                labelPrice.Name = "labelPrice";
                labelPrice.Size = new System.Drawing.Size(164, 41);
                labelPrice.TabIndex = 8;
                labelPrice.Text = $"{race.price} руб";

                Controls.Add(panel);

                panel.ResumeLayout(false);
                panel.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(pictureSeat)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(pictureCancel)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(pictureDate)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(picturePlane)).EndInit();

                helperRacesList.Add(helperRace);

                racePositionY += raceIntervalY;
            }
        }

        // нажатие на кнопку "добавить рейс"
        private void AddButton_Click(object sender, EventArgs e)
        {
            // переходим в окно добавления рейса
            AddRaceForm addRaceForm = new AddRaceForm();
            this.Hide();
            addRaceForm.Show();
        }

        // нажатие на картинку с крестиком у рейса
        private void pictureEvent_Click(object sender, EventArgs e)
        {
            // копируем список, чтоб потом по нему пройтись циклом(потомучто мы будем удалять рейс)
            List<HelperRace> helperRacesList1 = helperRacesList.ToList();

            // проходимся циклом
            foreach (HelperRace helperRace in helperRacesList1)
            {
                // удаляем с экрана панель с рейсом
                this.Controls.Remove(helperRace.panel);
                if (helperRace.pictureEvent == sender)
                {
                    // убираем рейс из списка
                    Program.data.racesList.Remove(helperRace.race);
                    helperRacesList.Remove(helperRace);
                }
            }
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                Program.formatter.Serialize(fs, Program.data);
            }

            // выводим на экран уже новый список рейсов
            OutputRaces();
        }

        // нажатие на картинку "назад"
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // переходим в окно с меню
            MenuForm menuForm = new MenuForm();
            this.Hide();
            menuForm.Show();
        }

        // нажатие на выход из окна
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    // класс-помощник, который помогает при обработке нажатия на картинку "удалить рейс"
    // он нужен потому, что нельзя сериализовать Panel и PictureBox
    class HelperRace
    {
        public Race race;
        public PictureBox pictureEvent;
        public Panel panel;
    }
}
