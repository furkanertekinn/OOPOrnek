using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOdev
{
    public class Musteri
    {
        static ArrayList MusteriDataBase;
        static Musteri()
        {
            MusteriDataBase = new ArrayList();
        }

        public int MusteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailadres { get; set; }
        public string Sifre { get; set; }


        public string _kullaniciAdi;
        public string KullaniciAdi
        {
            get { return this._kullaniciAdi; }

            set
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı.");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }

        static bool musteriKullaniciAdiKontrol(string _kullaniciAdi)
        {
            bool Kontrol = false;

            for (int i = 0; i < MusteriDataBase.Count; i++)
            {
                Musteri Temp = (Musteri)MusteriDataBase[i];

                if (Temp.KullaniciAdi == _kullaniciAdi)
                {
                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;
        }

        public static void MusteriEkle(Musteri M)
        {
            if (M != null && !string.IsNullOrEmpty(M.KullaniciAdi)&& !string.IsNullOrEmpty(M.emailadres))
            {
                bool emailAdresKontrol = musteriEmailAdresKontrol(M.emailadres);

                if (emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı.");
                }
                else
                {
                    MusteriDataBase.Add(M);
                    Console.WriteLine("Yeni kayıt işlemi başarılı");
                }
            }
        }

        static bool musteriEmailAdresKontrol(string _emailAdres)
        {
            bool Kontrol = false;
            for (int i = 0; i < MusteriDataBase.Count; i++)
            {
                Musteri Temp = (Musteri)MusteriDataBase[i];
                if (Temp.emailadres == _emailAdres)
                {
                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;
        }

    }
}
