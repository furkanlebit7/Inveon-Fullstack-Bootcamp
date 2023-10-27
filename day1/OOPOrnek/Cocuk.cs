using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    internal class Cocuk:Insan
    {
        public string sifat;
        
        public void AdSoyadSifatYaz(String isim,String soyisim,string sifat)
        {
            Console.WriteLine(isim+" "+soyisim+" "+sifat);
        }
    }
}
