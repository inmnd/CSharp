using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyel_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen faktoriyeli hesaplanmasını istediginiz sayiyi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int temp = sayi-1;

            while(temp > 0)
            {
                sayi *= temp;
                temp--;
            }

            Console.WriteLine("Sonuc=" + sayi);
          
            Console.ReadLine();
        }
    }
}
