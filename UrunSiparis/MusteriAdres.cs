using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeOrnekleme
{
    public class MusteriAdres
    {
        public string adresTip { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string Adres { get; set; }

        public MusteriAdres()
        {
            Console.WriteLine("Müşteri adres yapıcı öeyodu çalıştı");
        }

        public void MusteriAdresTestMetot()
        {
            Console.WriteLine("Musteri Adres Test Metot");
        }

    }
}
