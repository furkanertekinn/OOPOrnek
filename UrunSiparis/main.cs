using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeOrnekleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.tckimliknumarasi = "12345678901";
            M1.isim = "Furkan";
            M1.soyisim = "Ertekin";
            M1.olusturmatarihi = DateTime.Now;

            //M1.musteriAdresleri = new MusteriAdres[5];
            //asla yapma. burda da olur ama yeri burası değil.

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                il = "Tokat",
                ilce = "Merkez",
                Adres = "Karşıyaka ",
                adresTip = " Ofis",
            };

            M1.musteriAdresleri[0].MusteriAdresTestMetot();

            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi="spNo123456",
            };


            M1.musteriSiparisBilgileri[0].urunler[0] = new Urun
            {
                urunId = 1,
                ismi = "Telefon",
                fiyat = 14000,

            };
        }
    }
}
