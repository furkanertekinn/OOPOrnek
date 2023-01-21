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

        private double _hasarkaydi { get; set; }
        public double hasarKaydi
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

        public double _alinabilirlik1 { get; set; }
        public double _alinabilirlik2 { get; set; }
        public double _alinabilirlik3 { get; set; }
        public double alinabilirlik
        {
            get
            {
                this._alinabilirlik1 = this.fiyat;
                this._alinabilirlik2 = this.hasarKaydi;
                this._alinabilirlik3 = _alinabilirlik1 - _alinabilirlik2;
                return this._alinabilirlik3;
            }
            set
            {
                this.hasarKaydi = value;
            }
        }

        public double _pazarlikPayi { get; set; }

        public double PazarlikPayi
        {
            get
            {
                if (200000 < this.alinabilirlik)
                {
                    this._pazarlikPayi = 15000;
                    return this._pazarlikPayi;
                }
                else if (150000 < this.alinabilirlik)
                {
                    this._pazarlikPayi = 10000;
                    return this._pazarlikPayi;
                }
                else
                {
                    this._pazarlikPayi = 5000;
                    return this._pazarlikPayi;
                }
            }
            set
            {
                this._pazarlikPayi = value;
            }
        }
    }
}
