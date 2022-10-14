using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisti_oyunu
{
    public class Kart
    {
        private string yuz;
        private string deger;
        private int puan;

        public Kart(string y,string d)
        {
            yuz = y;
            deger = d;

            if (d=="Vale"|| d=="As")
            {
                puan = 1;
            }
            else if (d=="2"&& y=="Sinek")
            {
                puan = 2;
            }
            else if(d=="10"&& y=="Karo")
            {
                puan=3; 
            }
            else
            {
                puan = 0;
            }
        }
        public override string ToString()
        {
            return $"[{yuz} {deger}  ({puan})]";
        }

        public bool ValeMi()
        {
            return deger == "Vale";
        }
        public bool BenzerMi(Kart kart)
        {
            return deger==kart.deger;
        }
    }
}
