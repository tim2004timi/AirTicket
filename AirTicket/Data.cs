using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket
{
    // класс для сериализации данных
    [Serializable]
    class Data
    {
        public List<Race> racesList;

        public Data(){}
    }
}
