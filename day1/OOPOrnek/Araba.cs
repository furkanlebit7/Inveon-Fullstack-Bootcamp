using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    internal class Araba
    {
        public string marka;
        public string model;
        public int kapiSayisi;
        public int pencereSayisi;

        public void Git(String marka,String model)
        {
            Console.WriteLine(marka+" "+model+" Gidiyor");
        }
    }
}
