using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekleme
{
    class Hakkinda
    {
        public Hakkinda(double _sene1)
        {
            double artis1 = (_sene1 * 30) / 100;
            double toplamYilBoyuAldigiMaas1 = (_sene1 + artis1) * 12;

            double toplam = toplamYilBoyuAldigiMaas1;
            SonucGösterme(toplam);
        }

        public Hakkinda(double _sene1, double _sene2)
        {
            double artis1 = (_sene1 * 30) / 100;
            double toplamYilBoyuAldigiMaas1 = (_sene1 + artis1) * 12;

            double artis2 = (_sene2 * 40) / 100;
            double toplamYilBoyuAldigiMaas2 = (_sene2 + artis2) * 12;

            double toplam = toplamYilBoyuAldigiMaas1 + toplamYilBoyuAldigiMaas2;
            SonucGösterme(toplam);
        }

        public Hakkinda(double _sene1, double _sene2, double _sene3)
        {
            double artis1 = (_sene1 * 30) / 100;
            double toplamYilBoyuAldigiMaas1 = (_sene1 + artis1) * 12;

            double artis2 = (_sene2 * 40) / 100;
            double toplamYilBoyuAldigiMaas2 = (_sene2 + artis2) * 12;

            double artis3 = (_sene3 * 50) / 100;
            double toplamYilBoyuAldigiMaas3 = (_sene3 + artis3) * 12;

            double toplam = toplamYilBoyuAldigiMaas1 + toplamYilBoyuAldigiMaas2 + toplamYilBoyuAldigiMaas3;
            SonucGösterme(toplam);
        }

        public void SonucGösterme(double toplamYilBoyuAldigiMaas)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Sonuç : "+toplamYilBoyuAldigiMaas);

            if (toplamYilBoyuAldigiMaas<50000)
            {
                Console.WriteLine("Düşük gelirlisiniz.");
            }

            else if (toplamYilBoyuAldigiMaas>=50000||toplamYilBoyuAldigiMaas<100000)
            {
                Console.WriteLine("Orta gelirlisiniz.");
            }

            else
            {
                Console.WriteLine("Yüksek gelirilsiniz.");
            }
            Console.ReadLine();
        }
    }
}
