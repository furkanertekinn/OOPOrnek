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
            Console.Write("Lütfen bir veri giriniz : ");
            string kullaniciVeri=Console.ReadLine();

            Donustur D1 = new Donustur(kullaniciVeri);
           
            D1.Ayarla(true);

            Console.Write(D1.yeniDizi);
            Console.Write(D1.temelDizi);

            Console.ReadLine();

        }
    }
}
