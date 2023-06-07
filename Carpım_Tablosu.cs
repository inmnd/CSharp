using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpım_Tablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            while(a < 10)
            {
                while(b < 10) {
                    Console.WriteLine(a + "x" + b + "=" + (a*b));
                    b++;
                }
                a++;
                b = 0;
            }

            Console.ReadLine();
        }
    }
}
