using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme3
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba A1 = new Araba();

            Console.Write("Lütfen arabanın 'markasını' giriniz : ");
            A1.marka = Console.ReadLine();

            Console.Write("Lütfen arabanın 'modelini' giriniz : ");
            A1.model = Console.ReadLine();

            Console.Write("Lütfen arabanın 'rengini' giriniz : ");
            A1.renk = Console.ReadLine();

            Console.Write("Lütfen arabanın 'fiyatını' giriniz : ");
            A1.fiyat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lütfen arabanın 'hasar kaydını' giriniz : ");
            A1.hasarKaydi = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Arabanın değişen veya sorunlu halleri :");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1-) Kaput Değişmesi");
            Console.WriteLine("2-) Kapı Değişmesi");
            Console.WriteLine("3-) Tampon Değişmesi");
            Console.WriteLine("4-) Motor Arızası");
            Console.WriteLine("5-) Tamamen Boyalı");
            Console.WriteLine("6-) Lokal Boyalı");
            Console.WriteLine(" ");

            Console.Write("Bir madde seçiniz : ");
            int secilenMadde = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Araba ve durumu : ");
            Console.WriteLine("-----------------");
            Console.WriteLine(" ");

            Console.WriteLine("Marka : " + A1.marka);
            Console.WriteLine("Model : " + A1.model);
            Console.WriteLine("Renk : " + A1.renk);
            Console.WriteLine("Fiyat : " + A1.fiyat);
            Console.WriteLine("Hasar Kaydı : " + A1.hasarKaydi);
            Console.WriteLine(" ");
            Console.WriteLine("Arabanın alınabilir fiyatı : " + A1.alinabilirlik);
            Console.WriteLine("Pazarlık payı : " + A1.PazarlikPayi);

            dataBase D1 = new dataBase();
            ArabaPlakaSorgulama arabaKayitSonuc = D1.arabaYeniKayit(A1);

            int enumInt = (int)ArabaPlakaSorgulama.Tokat;
            Console.WriteLine("Kayıtlı olduğu plaka : " + enumInt + " / " + ArabaPlakaSorgulama.Tokat.ToString());

            Console.ReadLine();
        }
    }
}
