using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Musteri
    {
        public string ad;
        public string soyad;
        public int hesapNumarasi;
        public double hesapBakiye;
        public double paraYatirma;
        public double paraCekme;

        public Musteri()
        {

        }

        public Musteri(double giris)
        {
            hesapBakiye = giris;

            Console.WriteLine("Para yatırma işlemi = 1 ");
            Console.WriteLine("Para çekme işlemi   = 2 ");
            Console.WriteLine(" ");

            Console.Write("Lütfen gerçekleştirmek istediğiniz işlemi seçiniz : ");
            int kullaniciSecim = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (kullaniciSecim == 1)
            {
                Console.Write("Lütfen yatırmak istediğiniz tutarı giriniz : ");
                paraYatirma = Convert.ToInt32(Console.ReadLine());

                hesapBakiye = hesapBakiye + paraYatirma;
            }

            else if (kullaniciSecim == 2)
            {
                Console.Write("Lütfen çekmek istediğiniz tutarı giriniz : ");
                paraCekme = Convert.ToInt32(Console.ReadLine());

                hesapBakiye = hesapBakiye - paraCekme;
            }

            else
            {
                Console.WriteLine("Lütfen geçerli bir işlem numarası seçiniz!");
            }
        }
        public void Goster()
        {
            Console.Clear();
            Console.WriteLine("Müşteri Adı : " + ad);
            Console.WriteLine("Müşteri Soyadı : " + soyad);
            Console.WriteLine("Müşteri Hesap Numarası : " + hesapNumarasi);

            if (hesapBakiye < 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Çekmek istediğiniz miktar hesabınızda bulunmuyor!");
            }
            else
            {
                if (paraCekme != 0)
                {
                    Console.WriteLine("Müşteri Hesabından Çekilen Tutar : " + paraCekme);
                }
                else if (paraYatirma != 0)
                {
                    Console.WriteLine("Müşteri Hesabına Yatırılan Tutar : " + paraYatirma);
                }
                Console.WriteLine("Müşteri Kullanılabilir Hesap Bakiyesi : " + hesapBakiye);
            }
        }
    }
}
