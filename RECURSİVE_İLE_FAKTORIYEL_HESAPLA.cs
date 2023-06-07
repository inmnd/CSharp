using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAKTORIYEL_HESAPLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(faktoriyel(5));

            Console.ReadLine();
        }

        static int faktoriyel(int x)
        {
            if(x == 1) { 
                return 1;
            }
            else
            {
                return x * faktoriyel(x - 1);//metot kendi icinde kendini cagırarak recursive fonksiyon halini alır.
            }
        }
    }
}
