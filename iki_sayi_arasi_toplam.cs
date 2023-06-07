using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki_sayi_arasi_toplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen buyuk sayiyi giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen kucuk sayiyi giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            int dongu = a - b + 1;
            int toplam = 0;
            
            while (dongu > 0) {
                dongu--;
                toplam += b;
                b++;
            }

            Console.WriteLine("Toplam=" + toplam);

            Console.ReadLine();
        }
    }
}
