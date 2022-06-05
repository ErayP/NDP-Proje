using System;
using System.Collections.Generic;
using System.Text;

namespace eray
{
    class Urun
    {
        public string urunkodu; 
        public int depo, raftaki, satılanurunfiyatı, birimadedi;

    }
    class Müsteri
    {
        public  string adsoy;
        public  string TC;
    }
    class Tedarikci
    {
        public  string numarasi;
        public  int fiyati;
        public int gelenurun;
        public string adsoyad;
    }
    class Gider
    {
        public string gidersebebi;
        public int toplam_gider;
        public Gider()
        {
            toplam_gider = 0;
        }
    }
    class kar
    {
        public int netgelir;
        public int gider;
    }
}
