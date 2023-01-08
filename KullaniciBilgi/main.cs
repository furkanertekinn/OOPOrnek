using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1= new Musteri();

            M1.EmailAdres = "furkan.ertekin@hotmail.com";

            Console.WriteLine("Kullanıcı Bilgileri ");
            Console.WriteLine("-------------------");

            Console.WriteLine("Email adres : "+M1.EmailAdres);
            Console.WriteLine(" ");
            Console.WriteLine("ID numarası : "+M1.ID.ToString());
            Console.ReadLine();
        }
    }
}
