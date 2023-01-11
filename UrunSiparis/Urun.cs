using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeOrnekleme
{
    public class Urun
    {
        public int urunId { get; set; }
        public string ismi { get; set; }
        public double fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Ürünün içerisinde ki yapıcı metot çalıştı.");
        }

        public void UrunTestMetot()
        {
            Console.WriteLine("Urun Test Metot");
        }
    }
}
