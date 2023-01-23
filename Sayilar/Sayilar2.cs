using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayilarOdev
{
    public class Sayilar2 : Sayilar
    {
        public int[] asallar=new int[5];

        public void Bul2()
        {
            int sonuc = 0;
            for (int j = 0; j < veriler.Length; j++)
            {
                bool kontrol = true;
                int sayi = veriler[j];
                for (int i = 2; i < sayi; i++)
                {
                    int kalan = sayi % i;
                    if (kalan == 0)
                    {
                        kontrol = false;
                        break;
                    }
                }
                if (kontrol)
                {
                    asallar[sonuc] = sayi;
                    sonuc++;
                }
            }
            Console.Write("Girilen değerler içerisinde ki asal sayılar :");
            for (int a = 0; a < sonuc; a++)
            {
                Console.Write(asallar[a] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
