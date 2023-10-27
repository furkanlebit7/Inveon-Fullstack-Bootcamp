using OOPOrnek.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    internal class HiperaktifCocuk:Cocuk,IEhliyetAl
    {
        public void EhliyetAl(String adi)
        {
            Console.WriteLine(adi + " Ehliyet Alıyor"); 
        }
    }
}
