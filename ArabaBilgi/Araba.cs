using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme3
{
    public class Araba
    {
        public string marka { get; set; }
        public string model { get; set; }
        public string renk { get; set; }

        public double _fiyat;
        public double fiyat
        {
            get
            {
                return this._fiyat;
            }
            set
            {
                if (value < 100000)
                {
                    Console.WriteLine("Bu fiyatlara araba bulundurmuyoruz");
                }
                else
                {
                    this._fiyat = value;
                }
            }
        }

        private int _hasarkaydi { get; set; }
        public int hasarKaydi
        {
            get
            {
                return this._hasarkaydi;
            }
            set
            {
                this._hasarkaydi = value;

                if (value < 75000)
                {
                    Console.WriteLine("Hasar kaydınız çok yüksek !");
                }
            }
        }
    }
}
