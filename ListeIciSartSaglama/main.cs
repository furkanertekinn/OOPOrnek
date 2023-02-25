using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOdev
{
    class Program
    {
        static bool isimBaslangic(Musteri m)
        {
            if (m.isim[0] == 'A')
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            dataSource ds = new dataSource();
            List<Musteri> musteriListe = ds.musteriListesi();

            Func<Musteri, bool> isimdeBulunan = new Func<Musteri, bool>(isimBaslangic);

            var sonuc = musteriListe.Where(isimdeBulunan);
            Console.Write("İsmi 'A' harfi ile başlayan kişi sayısı : " + sonuc.Count());
            Console.WriteLine();

            var isimdeBbulma = musteriListe.Where(m => m.isim.EndsWith("n")).Count();
            Console.Write("İsmi 'n' harfi ile biten kişi sayısı : " + isimdeBbulma);
            Console.WriteLine();

            var soyisimdeBulunan = musteriListe.Where(i => i.soyisim.Contains('e'));
            Console.Write("Soyisminde 'E' harfi bulunan kişi sayısı : " + soyisimdeBulunan.Count());
            Console.WriteLine();

            var dogumYiliBulunan = musteriListe.FindAll(delegate (Musteri m) { return m.dogumTarih.Year > 1985; });
            Console.Write("1985 yılından sonra doğmuş kişi sayısı : " + dogumYiliBulunan.Count());
            Console.WriteLine();

            var hepsiBir = from I in musteriListe
                           where I.isim.StartsWith("A") && I.isim.EndsWith("n") && I.soyisim.Contains("e") && I.dogumTarih.Year > 1985
                           select I;
            Console.Write("Bütün şartların sağlandığı kişi sayısı : " + hepsiBir.Count());

            Console.ReadLine();
        }
    }
}
