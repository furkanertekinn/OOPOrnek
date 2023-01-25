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
            Console.Clear();
            Console.WriteLine("Girilen en büyük değer : " + S1.enBuyuk);
            Console.WriteLine(" ");
            Console.WriteLine("Girilen en küçük değer : " + S1.enKucuk);
            Console.WriteLine(" ");
            Console.WriteLine("Ortalama Sonuç : " + S1.ortalama);

            Sayilar2 S2 = new Sayilar2();

            S2.veriler = S1.veriler;
            S2.Bul2();

            Console.ReadLine();
        }
    }
}
