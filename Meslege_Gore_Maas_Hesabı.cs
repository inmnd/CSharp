using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeslegeGoreMaas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen mesleginizi giriniz");
            string meslek = Console.ReadLine();

            switch (meslek)
            {
                case "Doktor":
                    Console.WriteLine("Maasınız 20.000 TL'dir");
                    break;
                case "Muhendis":
                    Console.WriteLine("Maasınız 10.000 TL'dir");
                    break;
                case "İsci":
                    Console.WriteLine("Maasınız 8.000 TL'dir");
                    break;
                default:
                    Console.WriteLine("Yazıgınız meslek sistemde tanımlı degildir!!!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
