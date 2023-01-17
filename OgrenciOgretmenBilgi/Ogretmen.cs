using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme
{
    public class Ogretmen : Genel
    {
        public Ogretmen()
        {
            this._ogretmensistemsifre = SifreUret();
            this._ogretmenSirasi = OgretmenSirasiUret();
        }

        int _ogretmenSirasi;

        public int OgretmenSirasi
        {
            get
            {
                return this._ogretmenSirasi;
            }

            private set
            {
                this._ogretmenSirasi = value;
            }
        }

        public int OgretmenSirasiUret()
        {
            Random rnd3 = new Random();
            return rnd3.Next(0, 100);
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
            Random rnd4 = new Random();
            return rnd4.Next(10001, 20000);
        }
    }
}
