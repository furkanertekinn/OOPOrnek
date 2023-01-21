using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme3
{
    class Program
    {
        public static void SecilenDeger(int secilenMadde)
        {
            Console.Write("Arabanın Sorunları : ");
            while (true)
            {
                int[] dizi = new int[6];


                if (0 < secilenMadde && secilenMadde < 7)
                {
                    if (secilenMadde == 1)
                    {
                        Console.WriteLine("Arabada Kaput Değişmesi vardır.");
                    }
                    else if (secilenMadde == 2)
                    {
                        Console.WriteLine("Arabada Kapı Değişmesi vardır.");
                    }
                    else if (secilenMadde == 3)
                    {
                        Console.WriteLine("Arabada Tampon Değişmesi vardır.");
                    }
                    else if (secilenMadde == 4)
                    {
                        Console.WriteLine("Arabada Motor Arızası vardır.");
                    }
                    else if (secilenMadde == 5)
                    {
                        Console.WriteLine("Araba Tamamen Boyalıdır.");
                    }
                    else if (secilenMadde == 6)
                    {
                        Console.WriteLine("Araba Lokal Boyalıdır.");
                    }
                    Console.Clear();
                }

                else
                {
                    Console.WriteLine("Lütfen maddelerden birini seçiniz!");
                }

                Console.WriteLine("Eklemek istediğiniz başka madde var mı ?  (E/H)");
                string eorh = Console.ReadLine();
                Console.Clear();

                if (eorh.ToUpper() == "E")
                {
                    Console.Write("Eklemek istediğiniz diğer maddeyi giriniz : ");
                    secilenMadde = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
                else if (eorh.ToUpper() == "H")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen istenilen seçeneklerden birini seçiniz, baştan tekrar deneyiniz!");
                    break;
                }
            }
        }
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
            SecilenDeger(secilenMadde);

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
