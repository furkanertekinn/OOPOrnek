using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen hesap bakiyenizi giriniz : ");
            int kullaniciGiris = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Musteri M1 = new Musteri(kullaniciGiris);

            Console.Clear();

            Console.Write("Lütfen adınızı giriniz : ");
            M1.ad = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Lütfen soyadınızı giriniz : ");
            M1.soyad = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Lütfen hesap numaranızı giriniz : ");
            M1.hesapNumarasi = Convert.ToInt32(Console.ReadLine());

            M1.Goster();

            Console.ReadLine();
        }
    }
}
