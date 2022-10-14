using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisti_oyunu
{
    public class Masa
    {
        private Oyuncu[] oyuncular;
        private Deste deste;
        private List<Kart> yer;

        private static readonly Random random = new Random();

        public Masa(int oyuncu_sayisi)
        {
            oyuncular = new Oyuncu[oyuncu_sayisi];
            deste = new Deste();
            deste.Karistir();
            yer = new List<Kart>();
            for (int i = 0; i < oyuncu_sayisi; i++)
            {
                oyuncular[i] = new Oyuncu("Oyuncu"+ i);
            }
            yer = deste.KartVer(4);
        }

        private void Dagit()
        {
            if (deste.KartSay() > 0)
            {
                foreach (Oyuncu o in oyuncular)
                {
                    o.Al(deste.KartVer(4));
                }
            }
        }

        private bool KuralKontrol(Kart atilan)
        {
            if (yer.Count > 0)
            {
                Kart en_ustteki_kart = yer.LastOrDefault();

                if (atilan.ValeMi() || atilan.BenzerMi(en_ustteki_kart))
                {
                    return true;
                }
            }
            return false;
        }

        private void TurOyna()
        {
            foreach (Oyuncu o in oyuncular)
            {
                int atilacak_kart_index = random.Next(o.KartSay());
                Kart atilan = o.At(atilacak_kart_index);
                if (KuralKontrol(atilan))
                {
                    yer.Add(atilan);
                    o.Topla(yer);
                    yer.Clear();
                }
                else
                {
                    yer.Add(atilan);
                }
            }
        }

        public void ElOyna()
        {
            Oyuncu son_oyuncu = oyuncular.LastOrDefault();
            Dagit();
            do
            {
                TurOyna();
            } while (son_oyuncu.KartSay() > 0);
        }
        public void OyunOyna()
        {
            while (deste.KartSay() > 0)
            {
                ElOyna();
            }
        }

        public override string ToString()
        {
            string oyuncular_str = string.Join("\n", oyuncular.ToList());
            string yer_str = string.Join(",", yer);
            return string.Format("Deste({0}):\nOyuncular:\n{2}\n\nyer:{1}", deste.KartSay(), yer_str, oyuncular_str);
        }




    }
}
