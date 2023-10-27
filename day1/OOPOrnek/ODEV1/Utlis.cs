using OOPOrnek.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.ODEV1
{
    public class Utlis
    {
        public static void RunLoggers(ILogger[] loggers,string value)
        {
            foreach(ILogger logger in loggers)
            {
                logger.Yazdir(value);
            }
        }
    }
}
