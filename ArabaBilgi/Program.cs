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
            while (true)
            {
                if (119 < secilenMadde && secilenMadde < 126)
                {
                    if (secilenMadde == 120)
                    {
                        Console.WriteLine("Arabada Kaput Değişmesi vardır.");
                    }
                    else if (secilenMadde == 121)
                    {
                        Console.WriteLine("Arabada Kapı Değişmesi vardır.");
                    }
                    else if (secilenMadde == 122)
                    {
                        Console.WriteLine("Arabada Tampon Değişmesi vardır.");
                        break;
                    }
                    else if (secilenMadde == 123)
                    {
                        Console.WriteLine("Arabada Motor Arızası vardır.");
                    }
                    else if (secilenMadde == 124)
                    {
                        Console.WriteLine("Araba Tamamen Boyalıdır.");
                    }
                    else if (secilenMadde == 125)
                    {
                        Console.WriteLine("Araba Lokal Boyalıdır.");
                    }
                    break;
                }

                else
                {
                    Console.WriteLine("Lütfen maddelerden birini seçiniz!");
                }

                Console.WriteLine("Eklemek istediğiniz başka madde var mı ?  (E/H)");
                string eorh = Console.ReadLine();

                if (eorh.ToUpper() == "E")
                {
                    continue;
                }
                else if (eorh.ToUpper() == "H")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen istenilen seçeneklerden birini seçiniz!");
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
            Console.WriteLine("1-) 120 = Kaput Değişmesi");
            Console.WriteLine("2-) 121 = Kapı değişmesi");
            Console.WriteLine("3-) 122 = Tampon değişmesi");
            Console.WriteLine("4-) 123 = Motor arızası");
            Console.WriteLine("5-) 124 = Tamamen boyalı");
            Console.WriteLine("6-) 125 = Lokal boyalı");
            Console.WriteLine(" ");

            Console.Write("Bir madde seçiniz : ");
            int secilenMadde = Convert.ToInt32(Console.ReadLine());

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

            dataBase D1 = new dataBase();
            ArabaDurumOgrenme arabaKayitSonuc = D1.arabaYeniKayit(A1);

            int enumInt = (int)ArabaDurumOgrenme.lokalboya;
            Console.WriteLine("Kaza durumu : " + enumInt);

            Console.ReadLine();
        }
    }
}
