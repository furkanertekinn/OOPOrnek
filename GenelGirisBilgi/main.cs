using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1= new Musteri();

            M1.MusteriID= 111;
            M1.isim = "Furkan";
            M1.soyisim = "Ertekin";
            M1.emailadres = "furkan.ertekin@hotmail.com";
            M1.KullaniciAdi = "furkan.ertekin.123";
            M1.Sifre = "456";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri()
            {
                MusteriID = 222,
                isim = "Osman",
                soyisim = "Ertekin",
                emailadres = "osman.ertekin@hotmail.com",
                KullaniciAdi="osman.ertekin.456",
                Sifre="1230"
            };

            Musteri.MusteriEkle(M2);

            Musteri M3 = new Musteri();

            M3.MusteriID = 111;
            M3.isim = "Furkan";
            M3.soyisim = "Ertekin";
            M3.emailadres = "furkan.ertekin@hotmail.com";
            M3.KullaniciAdi = "furkan.ertekin.123";
            M3.Sifre = "456";

            Musteri.MusteriEkle(M3);


        }
    }
}
