using OOPOrnek.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    internal class Anne : Insan, IOku, IDinleveYaz
    {
        public void Oku(string adi)
        {
            Console.WriteLine(adi + " Okuyor");
        }
       public void Dinle(string adi)
        {
            Console.WriteLine(adi + " Dinliyor");
        }

       public void Yaz(string adi)
        {
            Console.WriteLine(adi + " Yazıyor");
        }

    }
}
