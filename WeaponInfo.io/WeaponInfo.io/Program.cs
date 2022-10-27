using System;
using System.Text;
using System.Xml.Linq;

namespace WeaponInfo.io
{
    class program
    {

        private static void Main()
        {
            Console.BackgroundColor = 
        ConsoleColor.White;

            Console.Clear();

            Console.ForegroundColor =
        ConsoleColor.Black;

            Console.OutputEncoding = 
        Encoding.Unicode;

            Console.InputEncoding = 
        Encoding.Unicode;

            Console.Title = 
        "WeaponInfo.io (Докийчук А.И) ";

            Console.WriteLine
        ("----Weapon Info.Ua---- ");

            StudyDataIO();

            Console.ReadKey(true);


        }

        static void OutData(string typeOfweapon, string name, double yearOfadoption,
            string caliber, string prodCountry)
        {

            Console.WriteLine("Даные об оружии:");

            Console.WriteLine("\t{0,-9} {1,-9} Год производства: {2,5} Калибр: {3,10} " +
                "Страна: {4,-10}", typeOfweapon, name, yearOfadoption, caliber, prodCountry);

            Console.ReadKey(true);
        }
        static void StudyDataIO()
        {
            string typeOfweapon = "Штурмовая " +
        "винтовка"; 

            string name = "AK-74";

            double yearOfadoption = 1974;

            string caliber = "5.45x39";

            string prodCountry = "СССР";

            OutData(typeOfweapon, name, yearOfadoption,
        caliber, prodCountry);

            EnterData(out typeOfweapon, out name, out yearOfadoption, 
        out caliber, out prodCountry);
        }
        public static void EnterData(out string typeOfweapon, out string name,
           out double yearOfadoption, out string caliber, out string prodCountry)
        {
            name = null; 

            yearOfadoption = 0.0;

            typeOfweapon = null;

            caliber = null;

            prodCountry = null;

            string s;
            
          Console.WriteLine("Ведите даные об оружии");

            Console.WriteLine("\tТип Оружия");

             s = Console.ReadLine();

            typeOfweapon = s.Trim();

           Console.WriteLine("\tНазвание: ");

             s = Console.ReadLine();

            name = s.Trim();

           Console.WriteLine("\tГод производства: ");

             s = Console.ReadLine();

            yearOfadoption =Convert.ToDouble (s.Trim());

           Console.WriteLine("\tКалибр: ");

             s = Console.ReadLine();

            caliber = s.Trim();

           Console.WriteLine("\t Страна прозводитель: ");

             s = Console.ReadLine();

            prodCountry = s.Trim();
        }
    }   
} 
