using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaklavaDilimiSeklindeYildizYazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayi giriniz:");
            int satir = Convert.ToInt32(Console.ReadLine());
            satir = satir % 2 == 0 ? satir++ : satir;

            int bosluk = satir / 2;
            int yildiz = 1;

            for(int i = 0; i < satir; i++) {
                for(int j = 0; j < bosluk; j++)
                {
                    Console.Write(" ");
                }
                for(int z = 0; z < yildiz; z++)
                {
                    Console.Write("*");
                }
                if(i < satir/2)
                {
                    bosluk--;
                    yildiz += 2;
                }
                else
                {
                    bosluk++;
                    yildiz -= 2; 
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
