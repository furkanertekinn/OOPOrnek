using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeOrnekleme
{
    public class MusteriIletisimBilgisi
    {
        public int iletisimTip { get; set; } // 7177770001 : Mobil - 7177770001 : Sabit
        public string alankodu { get; set; }
        public string numara { get; set; }
        public string aktifPasif { get; set; }

        public void MusteriIletisimBilgisiTestMetot()
        {
            Console.WriteLine("Musteri Iletisim Bilgisi Test Metot");
        }

    }
}
