﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayilarOdev
{
    public class Sayilar2 : Sayilar
    {
        public int[] asallar = new int[5];

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
                    }
                    break;

                }
                if (kontrol)
                {
                    if (sayi % 5 == 0 || sayi % 3 == 0)
                    {

                    }
                    else
                    {
                        asallar[sonuc] = sayi;
                        sonuc++;
                    }
                }
            }

            Console.WriteLine(" ");
            Console.Write("Girilen değerler içerisinde ki asal sayılar :");
            for (int a = 0; a < sonuc; a++)
            {
                Console.Write(asallar[a] + " ");
                continue;
            }
            Console.ReadLine();
        }
    }
}