
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int yanlıscevap = 0;
            int dogrucevap = 0;
            int puan = 0;
            char istek = 'e';
            do {
                int sayi1 = rnd.Next(2, 100);
                int sayi2 = rnd.Next(2, 100);
                int toplam = sayi1 + sayi2;
                Console.WriteLine("Tahmininizi giriniz:");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if(tahmin == toplam)
                {
                    Console.WriteLine("Tebrikler bildiniz!!!");
                    puan += 5;
                    dogrucevap++;
                    Console.WriteLine("Tekrar oynamak istiyor musunuz?(E/e)");
                    istek = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Üzgünüm yanlış bildin=(\nDoğru Cevap:" + toplam);
                    puan -= 2;
                    yanlıscevap++;
                    Console.WriteLine("Tekrar oynamak istiyor musunuz?(E/e)");
                    istek = Convert.ToChar(Console.ReadLine());
                }

            } while (istek == 'e' || istek == 'E');

            Console.WriteLine("Puanın:" + puan + "\nDoğru cevap sayın:" + dogrucevap + "\nYanlış cevap sayın:" + yanlıscevap + "\nHoşçakal =)");

            Console.ReadLine();
        }
    }
}
