using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_sayiya_kadar_toplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayıyı giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            
            while (a > 0) {
                sayac += a;
                a--;
            }

            Console.WriteLine("Toplam=" + sayac);


            Console.ReadLine();
        }
    }
}
