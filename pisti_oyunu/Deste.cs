using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisti_oyunu
{
    public class Deste
    {
        private List<Kart> kartlar;

        private static readonly Random random = new Random();

        public Deste()
        {
            kartlar = new List<Kart>();
            string[] yuzler = { "Sinek", "Maça", "Karo", "Kupa" };
            string[] degerler = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kız", "Papaz" };
            foreach (var yuz in yuzler)
            {
                foreach (var deger in degerler)
                {
                    Kart kart = new Kart(yuz, deger);
                    kartlar.Add(kart);
                }
            }
        }
        public void Karistir()
        {
            for (int i = 0; i < 50; i++)
            {
                int ilkYariKartAdresi = random.Next(26);
                int ikinciYariKartAdresi = random.Next(26, 52);
                Kart bos = kartlar[ilkYariKartAdresi];
                kartlar[ilkYariKartAdresi] = kartlar[ikinciYariKartAdresi];
                kartlar[ikinciYariKartAdresi] = bos;
            }
        }

        public int KartSay()
        {
            return kartlar.Count;
        }

        public List<Kart> KartVer(int kart_sayisi)
        {
            List<Kart> verilecekler = kartlar.Take(kart_sayisi).ToList();
            kartlar.RemoveRange(0, kart_sayisi);
            return verilecekler;
        }

        public override string ToString()
        {
            return string.Join(",", kartlar);
        }


    }
}
