using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_Proje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Variables Declaration
            int number1;
            int number2;
            string sehir;
            string belediye=" Büyük Şehir Belediyesi";
           
           //Number Example Functions
            Console.Write("Lütfen bir sayı giriniz :");
            number1 = Convert.ToInt32(Console.ReadLine());

            number2 = number1;

            Console.WriteLine("1.Sayının değeri: " + number1);
            Console.WriteLine("2.Sayının değeri : " + number2);

            //City Example Functions
            Console.Write("Lütfen Şehir bilgisi giriniz ");
            sehir = Console.ReadLine();
            Console.WriteLine(sehir + belediye);

            
            Console.ReadKey();

        }
    }
}
