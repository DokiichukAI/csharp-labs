using System;
using System.Text;

namespace WeaponInfo
{
    static class ConsoleIO
    {
        public static void SetConsolePram()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
        }

        class Program
        {
            static void Main()
            {
                SetConsolePram();
                Console.Title = "WeaponInfo.iteration(Докійчук А.І.)";
                Console.WriteLine("Реалізація циклів");
                StudyDataIO();

                Console.ReadKey();
            }
            static void StudyDataIO()
            {
                Console.WriteLine("---StudyDataIO---");

                string typeOfweapon = "Штурмова гвинтівка";
                string name = "AK-74";
                double yearOfadoption = 1974;
                string caliber = "5.45x39";
                string prodCountry = "СССР";

                OutData(typeOfweapon, name, caliber, yearOfadoption, prodCountry);
                EnterData(out  typeOfweapon, out name, out  caliber, out yearOfadoption, out prodCountry);
                OutData(typeOfweapon, name, caliber, yearOfadoption, prodCountry);
            }

            static void OutData(string typeOfweapon, string name, string caliber, 
                double yearOfadoption, string prodCountry)
            {
                Console.WriteLine("Дані про зброю");

                Console.WriteLine(
                    "\t{0,-9} {1,-9} Рік виготовлення: {2,5}  " + 
                    "Калібр: {3,-10}  Країна: {4,5}",
                    typeOfweapon ?? "?", name ?? "?", yearOfadoption, caliber ?? "?", prodCountry ?? "?"
                );
            }
            static void EnterData(out string typeOfweapon, out string name,
                 out string caliber, out double yearOfAdoption, out string prodContry)
            {
                typeOfweapon = null;
                name = null;
                caliber = null;
                yearOfAdoption = 0d;
                prodContry = null;

                Console.WriteLine("Ведіть дані про зброю");

                name = ConsoleIO.EnterString("\tНазва", 50, 2);
                typeOfweapon = ConsoleIO.EnterString("\tТип Зброї", 40, 3);
                caliber = ConsoleIO.EnterString("\tКалібр", 10, 7);
                prodContry = ConsoleIO.EnterString("\tКраїна виробник", 30, 3);
                yearOfAdoption = ConsoleIO.EnterDouble("\tРік виробництва", 4, 4);
            }
        }

        public static string EnterString(string prompt, int maxLenght, int minLenght = 0)
        {
            while (true)
            {
                Console.Write("\t{0}: ",prompt);

                string s = Console.ReadLine();
                s = s.Trim();

                if (s.Length >= minLenght && s.Length <= maxLenght)
                {
                    return s; 
                }
                
                Console.WriteLine("\t\tпотрібно ввести від {0} до {1} символів", minLenght, maxLenght);
            }
             
        }

        public static double EnterDouble(string prompt, int maxLenght,int minLenght = 0)
        {
            while (true)
            {
                Console.Write("\t{0}: ",prompt);

                string  s = Console.ReadLine();
  
                if(double.TryParse(s,out double value))
                { 
                    return value;
                }
                
                Console.WriteLine("\t\tпотрібно ввести {0} символa", minLenght);
            }
        }
    }
}