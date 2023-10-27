using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormApp
{
    public class OdemeIslemiFactory
    {
        public IOdemeTipi GetInstance(string className)
        {
            var yeniclass = Assembly.GetAssembly(typeof(IOdemeTipi)).CreateInstance("OdemeFormApp."+className);

            return (IOdemeTipi)yeniclass;
        }
    }
}
