using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeInveonOrnek
{
    public static class ZorunlulukKontrolu
    {
        public static bool Dogrula(object dogrulanacakNesne)
        {
            Type dogrulanacakTur = dogrulanacakNesne.GetType();
            FieldInfo[] dogrulanacakTurAlanlari = dogrulanacakTur.GetFields(BindingFlags.Instance | BindingFlags.Public);
            foreach(FieldInfo dogrulanacakTurAlani in dogrulanacakTurAlanlari)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakTurAlani.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if (zorunluAlanOznitelikleri.Length >= 0)
                {
                    string alanDegeri = dogrulanacakTurAlani.GetValue(dogrulanacakNesne) as string;
                    if(string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
