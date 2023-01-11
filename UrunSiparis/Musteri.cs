using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeOrnekleme
{
    public class Musteri
    {
        public int musteriID { get; set; }
        public string tckimliknumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set;}
        public DateTime olusturmatarihi { get; set; }
        public int kullaniciID { get; set; }


        public MusteriAdres[] musteriAdresleri;
        public MusteriIletisimBilgisi[] musteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;

        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[5];
            musteriIletisimBilgileri=new MusteriIletisimBilgisi[3];
            musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
            
        }

    }
}
