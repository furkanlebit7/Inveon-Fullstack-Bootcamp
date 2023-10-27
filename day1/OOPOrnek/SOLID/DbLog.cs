using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.SOLID
{
    public class DbLog
    {
        public void DbKayit(string value)
        {
            Console.WriteLine(value + " db e kaydedildi");
        }
    }
}
