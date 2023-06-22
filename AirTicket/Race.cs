using AirTicket.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicket
{
    // сериализуемый класс рейса
    [Serializable]
    internal class Race
    {
        public string company;
        public string date;
        public string fromPlace;
        public string toPlace;
        public int seats;
        public int price;
        public List<string> ticketsList = new List<string>();

        public Race(string company, string date, string fromPlace, string toPlace, int seats, int price)
        {
            this.company = company;
            this.date = date;
            this.fromPlace = fromPlace;
            this.toPlace = toPlace;
            this.seats = seats;
            this.price = price;
        }

        public Race() { }
    }
}
