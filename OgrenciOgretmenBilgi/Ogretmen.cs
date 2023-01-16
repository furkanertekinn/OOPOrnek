using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme
{
    public class Ogretmen : Genel
    {
        public int _ogretmenSirasi;

        public int OgretmenSirasi
        {
            get { return this._ogretmenSirasi; }

            set
            {
                for (int i = 0; i < 55000; i++)
                {
                    _ogretmenSirasi = _ogretmenSirasi + 10;
                }

                this._ogretmenSirasi = value;
            }
        }
        
        public Ogretmen()
        {
            this._ogretmensistemsifre = SifreUret();
        }

        int _ogretmensistemsifre;

        public int OgretmenSistemSifre
        {
            get
            {
                return this._ogretmensistemsifre;
            }

            private set
            {
                this._ogretmensistemsifre = value;
            }
        }
        public int SifreUret()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 10000);
        }
    }
}
