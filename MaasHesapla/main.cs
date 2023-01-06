using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekleme
{
    class Program
    {
        static void Main(string[] args)
        {
            double girilenSene;

            while (true)
            {
                Console.Write("Kaç senelik maaşınızı girmek istiyorsunuz? : ");
                girilenSene = Convert.ToDouble(Console.ReadLine());

                if (Convert.ToInt32(girilenSene) > 0 && Convert.ToInt32(girilenSene) < 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen belirtilen koşula göre giriş yapınız!");
                }
            }

            double[] dizi = new double[Convert.ToInt32(girilenSene)];

            while (true)
            {
                for (int i = 0; i < girilenSene; i++)
                {
                    Console.Write("{0}. seneki maaşınızı giriniz : ", i + 1);
                    dizi[i] = Convert.ToDouble(Console.ReadLine());
                }
                break;
            }

            if (Convert.ToInt32(girilenSene) == 1)
            {
                Hakkinda H1 = new Hakkinda(dizi[0]);
            }

            else if (Convert.ToInt32(girilenSene) == 2)
            {
                Hakkinda H1 = new Hakkinda(dizi[0], dizi[1]);
            }

            else if (Convert.ToInt32(girilenSene) == 3)
            {
                Hakkinda H1 = new Hakkinda(dizi[0], dizi[1], dizi[2]);
            }

            Console.ReadLine();
        }
    }
}
