using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisti_oyunu
{
    public class Oyuncu
    {
        private string ad;
        private int puan;
        private List<Kart> toplanan;
        private List<Kart> el;

        public Oyuncu(string a)
        {
            ad = a;
            puan = 0;
            toplanan = new List<Kart>();
            el = new List<Kart>();

        }
        public void Al(List<Kart> kartlar)
        {
            el = kartlar;
        }
        public void Topla(List<Kart> yerdekiler)
        {
            toplanan.AddRange(yerdekiler);
        }

        public Kart At(int kart_index)
        {
            Kart atilacak = el[kart_index];
            el.RemoveAt(kart_index);
            return atilacak;
        }
        public int KartSay()
        {
            return el.Count;
        }
        public override string ToString()
        {
            string el_str = string.Join(",", el);
            string toplanan_str = string.Join(",", toplanan);
                return string.Format("{0} ({1}):\nEl:{2}\nToplanan:{3}", ad, puan, el_str, toplanan_str);
        }
    }
}
