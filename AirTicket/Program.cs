using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AirTicket
{
    internal static class Program
    { 
        // создаем объект, где хранится список рейсов
        static public Data data;

        // создаем объект BinaryFormatter
        static public BinaryFormatter formatter = new BinaryFormatter();

        [STAThread]
        static void Main()
        {
            // десериализация из файла data.dat
            using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                Program.data = (Data)formatter.Deserialize(fs);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }
    }
}
