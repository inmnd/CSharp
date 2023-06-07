using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankaHesabıYönetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankaHesabı hesap = new BankaHesabı("Numan", "Demir", 1000, 987654321, 123456789);
            int secim;

            Console.WriteLine("Lütfen kart numaranızı giriniz:");
            int kartNumara = Convert.ToInt32(Console.ReadLine());
            while (kartNumara != hesap.kartno)
            {
                Console.WriteLine("Girdiginiz numara eksik ya da hatalıdır. Lütfen tekrar giriniz");
                kartNumara = Convert.ToInt32(Console.ReadLine());
            }

            int kontrol = 0;
            Console.WriteLine("Sifrenizi giriniz:");
            int sifre = Convert.ToInt32(Console.ReadLine());
            while (sifre != hesap.sifre)
            {
                Console.WriteLine("Girdiginiz sifre hatali tekrar giriniz:");
                sifre = Convert.ToInt32(Console.ReadLine());
                kontrol++;
                if (kontrol == 2) { break; }
            }
            if (kontrol >= 2)
            {
                Console.WriteLine("Fazla hatalı sifre girisinden dolayı hesap bloke edilmistir.");
            }
            else
            {
                Console.WriteLine("           BANKAMIZA HOSELDİNİZ " + hesap.ad + " " + hesap.soyad + " BEY");
                do
                {
                    Console.WriteLine("Ne Islem Yapmak Istersiniz?\n" +
                        "\n1)Para cekmek" +
                        "\n2)Para yatırmak" +
                        "\n3)Bakiye Sorgusu" +
                        "\n4)Sifre degistirmek" +
                        "\n5)Cıkıs yapmak"
                        );
                    secim = Convert.ToInt32(Console.ReadLine());
                    int miktar, bakiye, yeniSifre;
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Lütfen cekmek istediginiz miktarı secin.");
                            miktar = Convert.ToInt32(Console.ReadLine());
                            hesap.paraCek(miktar);
                            Thread.Sleep(1000);
                            Console.Write("Baska ");
                            break;
                        case 2:
                            Console.WriteLine("Yatırmak istediginiz miktari giriniz:");
                            miktar = Convert.ToInt32(Console.ReadLine());
                            hesap.paraYatir(miktar);
                            Console.WriteLine("Isleminiz basariyla gerceklestirilmistir.\n");
                            Thread.Sleep(1000);
                            Console.Write("Baska ");
                            break;
                        case 3:
                            Console.WriteLine("Bakiyeniz :" + hesap.bakiye + " TL'dir\n");
                            Thread.Sleep(1000);
                            Console.Write("Baska ");
                            break;
                        case 4:
                            Console.WriteLine("Yeni sifrenizi giriniz:");
                            yeniSifre = Convert.ToInt32(Console.ReadLine());
                            hesap.sifre = yeniSifre;
                            Console.WriteLine("İsleminiz basariyla gerceklestirilmistir.\n");
                            Thread.Sleep(1000);fff
                            Console.Write("Baska ");
                            break;
                        case 5:
                            Console.WriteLine("Cikis yapiliyor...");
                            Thread.Sleep(3000);
                            break;
                        default:
                            Console.WriteLine("Yanlıs veya hatalı bir giris yaptınız.");
                            Thread.Sleep(1000);
                            break;
                    }
                } while (secim != 5);
            }

            Console.ReadLine();
        }
    }
    class BankaHesabı
    {
        string Ad, Soyad;
        int Bakiye, kartNo, Sifre;
        public BankaHesabı(string ad, string soyad, int bakiye, int kartno, int sifre)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Bakiye = bakiye;
            this.kartNo = kartno;
            this.Sifre = sifre;
        }
        ~BankaHesabı() { }

        public void paraYatir(int miktar)
        {
            Bakiye += miktar;
        }
        public void paraCek(int miktar)
        {
            if (Bakiye < miktar)
            {
                Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.");
            }
            else
            {
                Bakiye -= miktar;
                Console.WriteLine("Isleminiz basariyla gerceklestirilmistir.\n");
            }
        }
        public string ad//Property
        {
            get { return Ad; }
            set { Ad = value; }
        }
        public string soyad
        {
            get { return Soyad; }
            set { Soyad = value; }
        }
        public int bakiye
        {
            get { return Bakiye; }
            set { Bakiye = value; }
        }
        public int kartno
        {
            get { return kartNo; }
        }
        public int sifre
        {
            get { return Sifre; }
            set { Sifre = value; }
        }
    }

}
