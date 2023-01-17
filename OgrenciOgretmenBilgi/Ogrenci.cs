using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme
{
    public class Ogrenci : Genel
    {
        public Ogrenci()
        {
            this._ogrencisistemsifre = SifreUret();
            this._no = NoUret();
        }

        int _no;
        public int No
        {
            get
            {
                return this._no;
            }
            private set
            {
                this._no = value;
            }
        }

        public int NoUret()
        {
            Random rnd1 = new Random();
            return rnd1.Next(0, 1000);
        }

        int _ogrencisistemsifre;

        public int OgrenciSistemSifre
        {
            get
            {
                return this._ogrencisistemsifre;
            }

            private set
            {
                this._ogrencisistemsifre = value;
            }
        }
        public int SifreUret()
        {
            Random rnd2 = new Random();
            return rnd2.Next(1000, 10000);
        }
    }
}
