using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdev
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar B1 = new Bilgisayar();

            Console.Write("Lütfen bilgisayarın markasını giriniz : ");
            B1.marka = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Lütfen bilgisayarın modelini giriniz : ");
            B1.model = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Lütfen bilgisayarın işlemcisini giriniz : ");
            B1.islemci = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Lütfen bilgisayarın alış fiyatını giriniz : ");
            B1.alisFiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Lütfen bilgisayarın satış fiyatını giriniz : ");
            B1.satisFiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Lütfen bilgisayarın kampanya fiyatını giriniz : ");
            B1.kampanyaFiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Lütfen bilgisayarın barkod numarasını giriniz : ");
            B1.barkod = Console.ReadLine();


            SanalDataBase.yeniUrunEkle(B1);

            Bilgisayar B2 = new Bilgisayar();

            B2.marka = "Lenova";
            B2.model = "z50";
            B2.islemci = "i7";
            B2.alisFiyat = 15000;
            B2.satisFiyat = 20000;
            B2.kampanyaFiyat = 15500;
            B2.barkod = "1234567890";

            SanalDataBase.yeniUrunEkle(B2);

        }
    }
}
