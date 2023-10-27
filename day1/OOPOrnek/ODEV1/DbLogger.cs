using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.ODEV1
{
    public class DbLogger : ILogger
    {
        public void Yazdir(string value)
        {
            Console.WriteLine(value + " Db'ye kaydedildi...");
        }
    }
}
