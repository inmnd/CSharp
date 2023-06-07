using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairenin_alanını_cevresini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            Console.WriteLine("Lütfen daireninin yarıçapını giriniz:");
            double yaricap = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dairenin çevresi:" + (2 * PI * yaricap) + "\nDairenin alanı:" + (PI * Math.Pow(yaricap, 2)));

            Console.ReadLine();
        }
    }
}
