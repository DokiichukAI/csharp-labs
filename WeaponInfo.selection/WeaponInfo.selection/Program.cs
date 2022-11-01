using System;
using System.Text;
using System.Xml.Serialization;

namespace WeaponInfo.selection
{
    class Program
    {
        public static void SetConsolPram()
        {
            Console.BackgroundColor =
        ConsoleColor.White;

            Console.Clear();

            Console.ForegroundColor =
        ConsoleColor.Black;

            Console.InputEncoding =
        Encoding.Unicode;

            Console.OutputEncoding =
        Encoding.Unicode;

        }
        static void Main()
        {
            Console.Title = "WeaponInfo.selection " +
       "(Докийчук А.И)";

            SetConsolPram();

            Console.WriteLine("Реалізація " +
       "розгалужень");

            StudyDataIO();

            Console.ReadKey();

        }
        static void StudyDataIO()
        {

            Console.WriteLine("---StudyDataIO---");

            string typeOfweapon = "Штурмова " +
        "гвинтівка";

            string name = "AK-74";

            short yearOfadoption = 1974;

            string caliber = "5.45x39";

            string prodCountry = "СССР";

            OutData(typeOfweapon, name, caliber, yearOfadoption, prodCountry);

            try
            {
                EnterData(out typeOfweapon, out name, out caliber, out yearOfadoption, out prodCountry);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\tПомилка: {0}", ex.Message);


                OutData(typeOfweapon, name, caliber, yearOfadoption, prodCountry);
            }
            
        }
        static void OutData(string typeOfweapon, string name,
            string caliber, short yearOfadoption, string prodCountry)
        {
            Console.WriteLine("Дані про зброю");

            Console.WriteLine("\t{0,-9} {1,-9} Рік виготовлення: {2,5}  " +
        "Калібр: {3,-10}  Країна: {4,5}",typeOfweapon ?? "?", name ?? "?", 
         yearOfadoption, caliber ?? "?", prodCountry ?? "?");

        }
        static void EnterData(out string typeOfweapon,out string name,
            out string caliber,out short yearOfadoption,out string prodContry) {

            typeOfweapon = null;

            name = null;

            caliber = null;

            yearOfadoption = 0;
            
            prodContry = null;

            Console.WriteLine("Ведіть дані про зброю");

            name = EnterName();

            typeOfweapon = EnterTypeOfWeapon();

            caliber = EnterCaliber();

            yearOfadoption =Convert.ToInt16(EnterYearOfAdoption());

            prodContry = EnterProdCountry();
        }
        static string EnterName() {
            
            Console.WriteLine("\n\tНазва: ");

            string s = Console.ReadLine();

            s = s.Trim();

            if (s.Length >= 3 && s.Length <= 50)
            {
                return s;
            }
            throw new Exception("потрібно ввести від 3-х до 50-ти символів");          
                 
        }
        static string EnterTypeOfWeapon()
        {
            Console.WriteLine("\n\tВид Зброї:");

            string s = Console.ReadLine();

            s = s.Trim();

            if (s.Length >=3 && s.Length <= 40) {

                return s;
            }
            throw new Exception("потрібно ввести від 3-х до 40-ка символів");
        }
        static string EnterCaliber()
        {
            Console.WriteLine("\n\tКалібр: ");

            string s = Console.ReadLine();

            s = s.Trim();

            if(s.Length >=7 && s.Length <= 7)
            {
                return s;
            }
            throw new Exception("потрібно ввести 7 символів");
        }
        static string EnterYearOfAdoption()
        {
            Console.WriteLine("\n\tРік виготовлення: ");

            string s = Console.ReadLine();

            s = s.Trim(); 

             if(s.Length >= 4 && s.Length <= 4)
            {
                return s;
            }
            throw new Exception("потрібно ввести 4 символа");

        }
        static string EnterProdCountry ()
        {
            Console.WriteLine("\n\tКраїна виробник: ");

            string s = Console.ReadLine();

            s = s.Trim();

            if (s == "")
            {
                return null;
            }
            if (s.Length >= 3 && s.Length <= 40){
                
                return s;
            }
           
            throw new Exception("потрібно ввести від 3 до 40 символів");
        }   


    }
    
}
