using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdev
{
    public class baseClass
    {
        public static int sayac = 1;

        public baseClass()
        {
            _id = sayac;
            sayac++;
        }

        private int _id;
        public int id
        {
            get
            {
                return _id;
            }

            private set
            {

            }

        }


        private string _barkod;

        public string barkod
        {
            get
            {
                return _barkod;
            }

            set
            {
                bool kontrolIslemi = SanalDataBase.dbBarkodKontrol(value);
                if (!kontrolIslemi)
                {
                    _barkod= value;
                }
                else
                {
                    Console.WriteLine("Sanal data base içerisinde bu barkod daha önce girilmiştir!");
                }

            }
        }
        public DateTime olusturmaTarihiAlanı { get; set; }
        public int olusturanKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }

    }
}
