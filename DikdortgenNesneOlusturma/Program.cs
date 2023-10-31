using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenNesneOlusturma
{ 

    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(13, 40);
            Console.WriteLine("Dikdörtgenin alanı ="+dikdortgen.alanHesapla());
            Console.WriteLine("Dikdörtgenin çevresi =" + dikdortgen.cevreHesapla());
        }
    }
    class Dikdortgen
    {
        private uint kisakenar, uzunkenar;
        public Dikdortgen(uint kisakenar , uint uzunkenar )
        {
            this.kisakenar = kisakenar;
            this.uzunkenar = uzunkenar;
        }
        public uint alanHesapla()
        {
            return kisakenar * uzunkenar;
        }
        public uint cevreHesapla()
        {
            return 2 * (kisakenar + uzunkenar);
        }
    }
}
