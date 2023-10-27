using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.Constructor
{
    public class YeniInsan
    {
        public Kafa kafa;
        public string ad;
        public string soyad;

        public YeniInsan(Kafa kafa, string ad, string soyad)
        {
            this.kafa = kafa;
            this.ad = ad;
            this.soyad = soyad;
        }

        public void EkranaYaz()
        {
            Console.WriteLine("Adı : " + ad + "\nSoyadı : " + soyad + "\nGöz Rengi : " 
                + kafa.goz.renk +"\nBurun Tipi : "+kafa.burun.tipi+"\nKulak Şekli : "+kafa.kulak.sekil);
        }
    }
}
