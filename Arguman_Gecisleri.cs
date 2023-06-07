using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arguman_Gecisleri
{
    internal class Program
    {

        /*Out ile ref de direkt olarak adresleri ile metotlara gonderildigi icin gonderilen degiskenlerin kendileri de degisir.
          ama normal olarak gonderme sirasinda degerin kendi adresi gonderilmez bu yüzden kendisi degeri degistirilmez.        */
        //PASSING BY VALUE normal deger gecisi
        //PASSING BY REFERENCE adres ile deger gecisi
        static void Main(string[] args)
        {
            int x1 = 5;
            kuphesapla1(x1);
            Console.WriteLine("METOT DISI:" + x1);

            int x2 = 5;
            kuphesapla2(ref x2);
            Console.WriteLine("METOT DISI:" + x2);

            int x3;
            kuphesapla3(out x3);
            Console.WriteLine("METOT DISI:" + x3);

            Console.ReadLine();
        }

        static void kuphesapla1(int sayi)
        {
            sayi = sayi * sayi * sayi;
            Console.WriteLine("NORMAL DEGER GONDEREME ILE HESAPLAMA \nMETOT ICI:" + sayi);
        }

        static void kuphesapla2(ref int sayi) 
        {
            sayi = sayi * sayi * sayi;
            Console.WriteLine("\nREF ILE HESAPLAMA \nMETOT ICI:" + sayi);
        }

        static void kuphesapla3(out int sayi)
        {
            sayi = 5;
            sayi = sayi * sayi * sayi;
            Console.WriteLine("\nOUT ILE HESAPLAMA \nMETOT ICI:" + sayi);
        }
    }
}
