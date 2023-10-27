using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.ODEV1
{
    public class CloudLogger : ILogger
    {
        public void Yazdir(string value)
        {
            Console.WriteLine(value + " Cloud'a kaydedildi...");
        }
    }
}
