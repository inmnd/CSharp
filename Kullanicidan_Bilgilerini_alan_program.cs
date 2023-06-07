using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanicidan_Bilgilerini_alan_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adınızı ve soyadınızı giriniz:");
            string adSoyad = Console.ReadLine();

            Console.WriteLine("Lütfen yaşınızı giriniz:");
            int yas = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Lütfen boyunuzu giriniz:");
            float boy = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Adınız ve soyadınız=" + adSoyad+ "\nYaşınız=" + yas + "\nBoyunuz=" + boy);
            
            Console.ReadLine();//Konsolun kapanmaması için.

        }
    }
}
