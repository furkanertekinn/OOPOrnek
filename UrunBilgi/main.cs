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

            B1.marka = "Lenova";
            B1.model = "z50";
            B1.islemci = "i7";
            B1.alisFiyat = 15000;
            B1.satisFiyat = 20000;
            B1.kampanyaFiyat = 15500;
            B1.barkod = "1234567890";

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
