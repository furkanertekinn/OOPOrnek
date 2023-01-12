using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdev
{
    public class Urun : baseClass
    {
        public string marka { get; set; } 
        public string model { get; set; }

        private double _alisFiyat;
        
        public double alisFiyat
        {
            get
            {
                return _alisFiyat;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alış fiyatı sıfırdan küçük veya eşit olamaz!");
                }
                else
                {
                    _alisFiyat = value;
                }
            }
        }

        private double _satisFiyat;
        public double satisFiyat
        {
            get
            {
                return _satisFiyat;
            }

            set
            {
                if (value < _alisFiyat)
                {
                    Console.WriteLine("Ürünün satış fiyatı, alış fiyatından küçük olamaz!");
                }
                else
                {
                    _satisFiyat = value;
                }
            }
        }

        private double _kampanyaFiyat;
        public double kampanyaFiyat
        {
            get
            {
                return _kampanyaFiyat;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyatı sıfırdan küçük veya eşit olamaz!");
                }
                else
                {
                    _kampanyaFiyat = value;
                }

            }
        }

    }
}
