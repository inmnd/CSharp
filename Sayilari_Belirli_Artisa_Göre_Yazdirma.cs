using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayilari_Belirli_Artisa_Göre_Yazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1'den kaca kadar yazdirilmasi istendigini giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen artis miktarini yaziniz:");
            int artis  = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < sayi; i += artis)
            {
                Console.Write(i + ",");
            }

            Console.ReadLine();
        }
    }
}
