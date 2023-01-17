using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Ogrenci O1 = new Ogrenci();

                Console.WriteLine("Öğrenci");
                Console.WriteLine("-------");
                Console.WriteLine(" ");

                Console.Write("Lütfen isminizi giriniz : ");
                O1.isim = Console.ReadLine();

                Console.Write("Lütfen soyisminizi giriniz : ");
                O1.soyisim = Console.ReadLine();

                Console.Write("Lütfen TC kimlik numaranızı giriniz : ");
                O1._tcno = Console.ReadLine();

                O1.NoUret();

                Console.WriteLine("Öğrenci numaranız : " + O1.No.ToString());

                Console.WriteLine("Öğrenci sistem giriş şifresi : " + O1.OgrenciSistemSifre.ToString());
                Console.WriteLine(" ");

                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine(" ");

                Console.WriteLine("Öğretmen");
                Console.WriteLine("--------");
                Console.WriteLine(" ");

                Ogretmen O2 = new Ogretmen();

                Console.Write("Lütfen isminizi giriniz : ");
                O2.isim = Console.ReadLine();

                Console.Write("Lütfen soyisminizi giriniz : ");
                O2.soyisim = Console.ReadLine();

                Console.Write("Lütfen TC kimlik numaranızı giriniz : ");
                O2._tcno = Console.ReadLine();

                Console.WriteLine("Öğretmen sıranız : " + O2.OgretmenSirasi.ToString());

                Console.Write("Öğretmen sistem giriş şifresi : " + O2.OgretmenSistemSifre.ToString());

                System.Threading.Thread.Sleep(3000);
                Console.Clear();

                Console.WriteLine("Yeni bir değer girmek istiyor musunuz ? (E/H)");
                string kullaniciSecim = Console.ReadLine();

                if (kullaniciSecim.ToUpper() == "E")
                {
                    Console.Clear();
                    continue;
                }

                else if (kullaniciSecim.ToUpper() == "H")
                {
                    Console.WriteLine("İşleminiz sonlandı.");
                    break;

                }

                else
                {
                    Console.WriteLine("Lütfen istenilen değerlerden birini giriniz !");
                }

                Console.ReadLine();
            }
        }
    }
}
