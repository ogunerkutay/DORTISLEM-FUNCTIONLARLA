using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DORTISLEM_FUNCTIONLARLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string islem = string.Empty;
            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi belirtiniz : topla, cikart, carp, bolme");
                islem = Console.ReadLine();
                double[] sayilar;
                switch (islem)
                {
                    case "exit":
                        break;
                    case "topla":
                        EkranaYaz(Topla(VeriTopla("topla")));
                        break;
                    case "cikart":
                        EkranaYaz(Cikart(VeriTopla("cikart")));
                        break;
                    case "carp":
                        EkranaYaz(Carp(VeriTopla("carp")));
                        break;
                    case "bolme":
                        EkranaYaz(Bol(VeriTopla("bolme")));
                        break;
                    default:
                        Console.WriteLine("Yapacağınız işlemi belirtmek için LÜTFEN SADECE topla, cikart, carp, bolme kelimelerini kullanınız!\nÇıkmak için exit yazabilirsiniz!");
                        break;
                }


            } while (islem != "exit");

            Console.WriteLine("Uygulamamızı kullandığınız için teşekkür ederiz!");
        }

        static double[] VeriTopla(string yapilanislem)
        {
            bool isNumeric = false;
            double sayi1 = 0;
            double sayi2 = 0;
            double[] sayilar = new double[2];
            do
            {
                Console.WriteLine("Lütfen 1. sayıyı giriniz : ");
                isNumeric = double.TryParse(Console.ReadLine(), out sayi1);
                if (isNumeric==false)
                {
                    Console.WriteLine("Lütfen sadece bir sayı giriniz!");
                }
            } while (isNumeric==false);
            do
            {
                Console.WriteLine("Lütfen 2. sayıyı giriniz : ");
                isNumeric = double.TryParse(Console.ReadLine(), out sayi2);
                if (isNumeric == false)
                {
                    Console.WriteLine("Lütfen sadece bir sayı giriniz!");
                }
                if (isNumeric == true && yapilanislem == "bolme" && sayi2 == 0)
                {
                    Console.WriteLine("Bölme işleminde 0 tanımsız sonuç verir, farklı bir sayı giriniz!");
                    isNumeric = false;
                }
            } while (isNumeric == false);


            sayilar[0] = sayi1;
            sayilar[1] = sayi2;
            return sayilar;

        }
        static void EkranaYaz(double sonuc)
        {
            Console.WriteLine(new String('-',100));
            Console.WriteLine("Yapılan işlemin sonucu : " + sonuc);
            Console.WriteLine(new String('-', 100));
        }

        static double Topla(double[] sayilar)
        {
            double sonuc = sayilar[0]+sayilar[1];
            return sonuc;
        }

        static double Cikart(double[] sayilar)
        {
            double sonuc = sayilar[0] - sayilar[1];
            return sonuc;
        }
        static double Carp(double[] sayilar)
        {
            double sonuc = sayilar[0] * sayilar[1];
            return sonuc;
        }
        static double Bol(double[] sayilar)
        {
            double sonuc = sayilar[0] / sayilar[1];
            return sonuc;
        }


    }
}
