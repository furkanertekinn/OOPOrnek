using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayilarOdev
{
    public class Sayilar
    {
        public int enBuyuk = int.MinValue;
        public int enKucuk = int.MaxValue;
        public double ortalama = 0;
        public int[] veriler = new int[6];

        public Sayilar()
        {

        }

        public Sayilar(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                while (true)
                {
                    Console.Write("Lütfen bir sayı giriniz : ");
                    int kullaniciSayi = Convert.ToInt32(Console.ReadLine());
                    veriler[i] = kullaniciSayi;
                    Console.WriteLine(" ");
                    break;
                }
            }
        }

        public void Bul()
        {
            for (int i = 0; i < veriler.Length; i++)
            {
                if (veriler[i] > enBuyuk)
                {
                    enBuyuk = veriler[i];
                }
                if (veriler[i] < enKucuk)
                {
                    enKucuk = veriler[i];
                }
                ortalama = ortalama + veriler[i];
            }
            ortalama = ortalama / veriler.Length;
        }
    }
}
