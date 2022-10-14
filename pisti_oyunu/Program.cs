using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisti_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kart kart = new Kart("Karo", "10");
            Console.WriteLine(kart);

            Deste deste= new Deste();
            Console.WriteLine(deste);
            deste.Karistir();
            Console.WriteLine(deste);
             deste= new Deste();
            Console.WriteLine(deste);

            Console.WriteLine(deste.KartSay());//52
            List<Kart> verilenler = deste.KartVer(4);
            Console.WriteLine(deste.KartSay());//48
            Console.WriteLine(String.Join(",",verilenler));

            Masa masa = new Masa(4);
            Console.WriteLine(masa);
            masa.ElOyna();
            Console.WriteLine();
            Console.WriteLine(masa);
            masa.OyunOyna();
            Console.WriteLine(masa);
        }
    }
}
