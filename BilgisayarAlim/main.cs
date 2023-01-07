using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekleme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar B1 = new Bilgisayar();

            B1.isim = "Furkan";
            B1.soyisim = "Ertekin";
            B1.bilgisayarMarkasi = "Asus";
            B1.isletimSistemi = "Windows";
            B1.ramBoyutu = 8;
            B1.bilgisayarFiyati = 15000;

            Console.WriteLine("1-Kişisel Bilgileri : ");
            Console.WriteLine("2-Bilgisayar Bilgileri : ");
            Console.WriteLine("3-Bilgisayarın Alınabilirliği :");

            Console.WriteLine(" ");

            while (true)
            {
                Console.Write("Lütfen bir seçenek seçiniz : ");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    B1.KisiselBilgiler();
                }

                else if (secim == 2)
                {
                    B1.BilgisayarBilgiler();
                }

                else if (secim == 3)
                {
                    Console.WriteLine(" ");
                    Console.Write("Lütfen bakiyenizi giriniz : ");
                    B1.bakiye = Convert.ToInt32(Console.ReadLine());

                    B1.Alinabilirlik();
                }

                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Lütfen seçeneklerden birini seçiniz!");
                }

                Console.WriteLine("");

            }

        }
    }
}
