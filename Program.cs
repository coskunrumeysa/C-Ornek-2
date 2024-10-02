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
            int number1;
            int number2;
           
            Console.Write("Lütfen bir sayı giriniz :");
            number1 = Convert.ToInt32(Console.ReadLine());

            number2 = number1;

            Console.WriteLine("1.Sayının değeri: " + number1);
            Console.Write("2.Sayının değeri : " + number2);

            Console.ReadKey();

        }
    }
}
