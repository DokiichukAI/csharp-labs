using System;
using System.Text;
using System.Xml.Linq;

namespace WeaponInfo.io
{
    class program
    {

        private static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "WeaponInfo.io (Докийчук А.И) ";
            Console.WriteLine("----Weapon Info.Ua---- ");
            StudyDataIO();
            Console.ReadKey(true);

        }

        static void OutData(string TypeOfWeapon, string Name, double YearOfAdoption, string caliber, string ProdCountry)
        {

            Console.WriteLine("Даные об оружии:");
            Console.WriteLine("\t{0,-9} {1,-9} Год производства: {2,5} Калибр: {3,10} Страна: {4,-10}", TypeOfWeapon, Name, YearOfAdoption, caliber, ProdCountry);
            Console.ReadKey(true);











        }
        static void StudyDataIO()
        {
            string TypeOfWeapon = "Штурмовая винтовка";
            string Name = "AK-74";
            double YearOfAdoption = 1974;
            string caliber = "5.45x39";
            string ProdCountry = "СССР";
            OutData(TypeOfWeapon, Name, YearOfAdoption, caliber, ProdCountry);
            EnterData(out TypeOfWeapon, out Name, out YearOfAdoption, out caliber, out ProdCountry);
        }



        public static void EnterData(out string TypeOfWeapon, out string Name, out double YearOfAdoption, out string caliber, out string ProdCountry)
        {
            Name = null;
            YearOfAdoption = 0.0;
            TypeOfWeapon = null;
            caliber = null;
            ProdCountry = null;
            string s;
            
          Console.WriteLine("Ведите даные об оружии");
            Console.WriteLine("\tТип Оружия");
             s = Console.ReadLine();
            TypeOfWeapon = s.Trim();
           Console.WriteLine("\tНазвание: ");
             s = Console.ReadLine();
            Name = s.Trim();
           Console.WriteLine("\tГод производства: ");
             s = Console.ReadLine();
            YearOfAdoption =Convert.ToDouble (s.Trim());
           Console.WriteLine("\tКалибр: ");
             s = Console.ReadLine();
            caliber = s.Trim();
           Console.WriteLine("\t Страна прозводитель: ");
             s = Console.ReadLine();
            ProdCountry = s.Trim();
        }
    }   
} 
