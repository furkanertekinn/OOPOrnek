using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme
{
    public class Ogrenci : Genel
    {
        public int _no = 1;

        public int No
        {
            get { return this._no; }

            set
            {
                for (int i = 0; i < 8000; i++)
                {
                    _no = _no + 1;
                }

                this._no = value;
            }
        }

        public Ogrenci()
        {
            this._ogrencisistemsifre = SifreUret();
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
            Random rnd = new Random();
            return rnd.Next(1000, 10000);
        }
    }
}
