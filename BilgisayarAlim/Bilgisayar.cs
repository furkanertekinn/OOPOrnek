using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekleme2
{
    class Bilgisayar
    {
        public string isim;
        public string soyisim;
        public string bilgisayarMarkasi;
        public string isletimSistemi;
        public int ramBoyutu;
        public int bilgisayarFiyati;
        public int bakiye;

        public void KisiselBilgiler()
        {
            Console.WriteLine(" ");
            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Soyisim : " + soyisim);
            Console.WriteLine("Bakiyeniz : " + bakiye);
        }

        public void BilgisayarBilgiler()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Markası : " + bilgisayarMarkasi);
            Console.WriteLine("İşletim sistemi : " + isletimSistemi);
            Console.WriteLine("Ram boyutu : " + ramBoyutu);
            Console.WriteLine("Fiyatı : " + bilgisayarFiyati);
        }

        public void Alinabilirlik()
        {
            Console.WriteLine(" ");

            if (bakiye >= bilgisayarFiyati)
            {              
                Console.WriteLine("Bilgisayarı alabilirsiniz, bakiyeniz yeterli");
            }

            else
            {
                Console.WriteLine("Bilgisayarı alamazsınız, bakiyeniz yetersiz!");
            }
        }

    }
}
