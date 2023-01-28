using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donustur
{
    public class Donustur
    {
        public int[] temelDizi;
        public int[] yeniDizi;

        public Donustur()
        {

        }
        public Donustur(string veri)
        {
            Console.WriteLine(" ");
            temelDizi = new int[veri.Length];
            yeniDizi = new int[veri.Length];

            Console.Write("Okul numaranızın dizi hali : ");

            Console.Write("{");

            for (int i = 0; i < veri.Length; i++)
            {
                Console.Write(veri[i]);
                if (i < veri.Length - 1)
                {
                    Console.Write(",");
                    Console.Write(" ");
                }
                temelDizi[i] = (int)Char.GetNumericValue(veri[i]);
                yeniDizi[i] = (int)Char.GetNumericValue(veri[i]);
            }

            Console.Write("}");
            Console.WriteLine();
        }

        public void Ayarla(bool yon)
        {

            yon = true;

            if (yon)
            {
                Console.WriteLine();
                Console.Write("Sonuç : ");
                Console.Write("{");

                for (int i = 0; i < yeniDizi.Length - 1; i++)
                {
                    int cikartma = yeniDizi[i] - yeniDizi[i + 1];
                    Console.Write(cikartma);

                    if (i < yeniDizi.Length - 1)
                    {
                        Console.Write(",");
                        Console.Write(" ");
                    }
                }
                Console.Write(yeniDizi[7]);
                Console.Write("}");
            }

            else if (!yon)
            {
                Console.WriteLine();
                Console.Write("{");
                Console.Write(yeniDizi[0]);
                Console.Write(",");
                Console.Write(" ");

                for (int i = 0; i < yeniDizi.Length - 1; i++)
                {
                    int cikartma = yeniDizi[i + 1] - yeniDizi[i];
                    Console.Write(cikartma);

                    if (i < yeniDizi.Length - 2)
                    {
                        Console.Write(",");
                        Console.Write(" ");
                    }
                }
                Console.Write("}");
            }

            else
            {
                Console.WriteLine("Geçersiz giriş!");
            }
        }
    }
}
