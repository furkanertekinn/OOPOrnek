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
            temelDizi = new int[veri.Length];
            yeniDizi = new int[veri.Length];

            Console.Write("{");

            for (int i = 0; i < veri.Length; i++)
            {
                Console.Write(veri[i]);
                if (i<veri.Length-1)
                {
                    Console.Write(",");
                    Console.Write(" ");
                }
                temelDizi[i] = (int)Char.GetNumericValue(veri[i]);
            }

            Console.Write("}");
            
        }

        public void Ayarla(bool yon)
        {
            
            yon = true;

            if (yon)
            {
                Console.Write("{");
                temelDizi[7] = yeniDizi[7];
                Console.Write(yeniDizi[7]);

                for (int i = 7; i <= yeniDizi.Length; i--)
                {
                    int cikartma = temelDizi[i - 1] - temelDizi[i];
                    Console.Write(cikartma);
                    Console.Write(",");
                }
                Console.WriteLine("}");
            }

            else if (!yon)
            {
                Console.Write("{");
                temelDizi[0] = yeniDizi[0];
                Console.Write(yeniDizi[0]);

                for (int i = 0; i < yeniDizi.Length; i++)
                {
                    int cikartma = temelDizi[i + 1] - temelDizi[i];
                    Console.Write(cikartma);
                    Console.Write(",");
                }
                Console.WriteLine("}");
            }

            else
            {
                Console.WriteLine("Geçersiz giriş!");
            }
        }
    }
}
