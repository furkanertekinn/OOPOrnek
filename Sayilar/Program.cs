using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayilarOdev
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sayilar S1 = new Sayilar(5);

            S1.Bul();
            Console.WriteLine("Sonuç : " + S1.ortalama);




            Sayilar2 S2 = new Sayilar2();

            S2.Bul2();





            Console.ReadLine();

        }
    }
}
