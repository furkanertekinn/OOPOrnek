using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donustur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen okul numaranızı giriniz : ");
            string kullaniciVeri = Console.ReadLine();

            if (kullaniciVeri.Length == 8)
            {
                Donustur D1 = new Donustur(kullaniciVeri);

                D1.Ayarla(true);
            }

            else
            {
                Console.WriteLine("Lütfen okul numaranızı kontrol ediniz !");
            }

            Console.ReadLine();
        }
    }
}
