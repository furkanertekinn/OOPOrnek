using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TC T1 = new TC();

            Console.Write("Lütfen TC kimlik numaranızı giriniz : ");

            T1.TcKimlikNumarasi = Console.ReadLine();

            string TC = T1.TcKimlikNumarasi;

            Console.WriteLine("TC kimlik numaranızın ilk '3' hanesi : " + TC);

            Console.ReadLine();
        }
    }
}
