using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Yazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            do
            {
                Console.WriteLine("Lütfen hangi sayiya -birden buyuk- kadar fibonacci yazdirilacagini giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
            } while (sayi <= 1);


            int temp1 = 1;
            int temp2 = 1;
            Console.WriteLine("\nGirdiginiz sayiya göre fibonacci serisi asagidaki gibidir:");
            Console.Write(temp1 + " ");
            for(int i = 1; i <= sayi; i = temp1 + temp2)
            {
                Console.Write(i + " ");
                temp1 = temp2;
                temp2 = i;
            }

            Console.ReadLine();
        }
    }
}
