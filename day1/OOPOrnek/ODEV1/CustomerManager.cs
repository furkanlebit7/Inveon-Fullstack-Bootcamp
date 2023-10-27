using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek.ODEV1
{
    public class CustomerManager
    {
        public ILogger[] loggers;
        public CustomerManager(ILogger[] loggers) {
            this.loggers = loggers;
        }

        public void Add(string value)
        {
            Console.WriteLine(value + " eklendi");
            Utlis.RunLoggers(loggers,value);
        }
    }
}
