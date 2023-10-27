using OOPOrnek.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    internal class AkilliCocuk : Cocuk, IAskereGit, IEhliyetAl, IKulubeGit  
    {
        public void AskereGit(string adi)
        {
            Console.WriteLine(adi + " Askere Gidiyor");
        }

        public void EhliyetAl(string adi)
        {
            Console.WriteLine(adi + " Ehliyet Alıyor");
        }

        public void KulubeGit(string adi)
        {
            Console.WriteLine(adi + " Kulübe Gidiyor");
        }
    }
}
