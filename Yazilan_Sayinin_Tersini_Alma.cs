using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazilan_Sayinin_Tersini_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int reverse = 0;

            Console.WriteLine("Tersini almak istediğiniz sayiyi giriniz:");
            number = Convert.ToInt32(Console.ReadLine());
            do {
                reverse = reverse * 10;
                reverse += number % 10;
                number = number / 10;
            }while(number != 0);
            Console.WriteLine("Girdiginiz sayinin tersi:" + reverse);

            Console.ReadLine();
        }
    }
}
