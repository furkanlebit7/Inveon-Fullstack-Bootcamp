﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormApp
{
    public class MailOrder:IOdemeTipi
    {
        public string Ode(double tutar)
        {
            return tutar.ToString() + " TL Mail Order Ödeme Gerçekleşti";
        }
    }
}
