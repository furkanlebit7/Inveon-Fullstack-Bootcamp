using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormApp
{
    public class KrediKartı : IOdemeTipi
    {
        public string Ode(double tutar)
        {
            return tutar.ToString() + " TL Kredi Kartı Ödeme Gerçekleşti";
        }
    }
}
