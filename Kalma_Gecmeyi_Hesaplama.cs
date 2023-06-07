using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalma_Gecmeyi_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vize, final;
            do
            {
                Console.WriteLine("Vize notunuz giriniz:");
                vize = Convert.ToInt32(Console.ReadLine());
                if(vize < 0)
                {
                    Console.WriteLine("Vize notu sıfırdan küçük olamaz!!!");
                }
            } while (vize < 0);
            do
            {
                Console.WriteLine("Final notunu giriniz:");
                final = Convert.ToInt32(Console.ReadLine());
                if (final < 0)
                {
                    Console.WriteLine("Final notu sıfırdan küçük olamaz!!!");
                }
            } while (final < 0);
            float ortalama = Convert.ToInt32(final * 0.6 + vize * 0.4);
            Console.WriteLine("\n\nOrtalaması:" + ortalama);
            if(ortalama >= 50)
            {
                Console.WriteLine("Öğrenci Geçmiştir.");
            }
            else
            {
                Console.WriteLine("Öğrenci kalmıştır.");
            }

            Console.ReadLine();
        }
    }
}
