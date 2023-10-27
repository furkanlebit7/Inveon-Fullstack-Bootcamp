using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Insan
    {
        public string ad;
        public string soyad;
        public int yas;
        public double maas;
        public bool cinsiyet;


        public Insan() { }
        public Insan(String ad,String soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }
        public Insan(String ad, String soyad,int yas,double maas, bool cinsiyet)
        {
            this. ad = ad;
            this.soyad = soyad;
            this.yas = yas;
            this.maas = maas;
            this.cinsiyet = cinsiyet;
            
        }

        public void uyu(String isim,String soyisim) {
            Console.WriteLine(isim + " " + soyisim + " Uyuyor");
        }

        public void tanıt(String isim,String soyad)
        {
            Console.WriteLine("Kişinin adı " + isim + " Kişinin Soyadı " + soyad);
        }
    }
}
