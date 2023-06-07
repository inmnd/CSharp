using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kare_Dikdortgenin_alan_cevre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            do {
                Console.WriteLine("İşlem kare üzerinde yapılacaksa k dikdörtgen için yapılacaksa d yazınız:");
                char sekil = Convert.ToChar(Console.ReadLine());
                if (sekil == 'k' || sekil == 'K')
                {
                    Console.WriteLine("Lütfen karenin bir kenarının uzunluğunu giriniz:");
                    float kenar = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nKarenin alanı:" + (kenar * kenar) + "\nKarenin çevresi:" + (4 * kenar));
                    kontrol = true;
                }
                else if (sekil == 'd' || sekil == 'D')
                {
                    Console.WriteLine("Lütfen dikdörtgenin büyük kenarını giriniz:");
                    float buyuk = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Lütfen karenin küçük kenarını giriniz:");
                    float kucuk = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nDikdörtgenin alanı:" + (buyuk * kucuk) + "\nDikdörtgenin çevresi:" + ((2 * kucuk) + (2 * buyuk)));
                    kontrol = true;
                }
                else
                {
                    Console.WriteLine("Girdiğiniz şekil ismi hatalıdır Tekrar Deneyiniz!!!");
                    kontrol = false;
                }
            } while (kontrol == false);

            Console.ReadLine();
        }
    }
}
