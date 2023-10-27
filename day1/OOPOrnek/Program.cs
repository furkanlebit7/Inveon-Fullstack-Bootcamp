using OOPOrnek;
using OOPOrnek.Abstracts;
using OOPOrnek.Constructor;
using OOPOrnek.ODEV1;
using OOPOrnek.SOLID;
using System.Reflection;
using System.Reflection.Metadata;

//Insan insan =new Insan();
//insan.ad = "Furkan";
//insan.soyad = "Lebit";
//insan.uyu("Furkan","Lebit");


//Araba araba = new Araba();
//araba.marka = "BMW";
//araba.model = "x6";
//araba.Git(araba.marka,araba.model);


//Anne an = new Anne();

//an.ad = "Aynur";
//an.soyad = "Lebit";

//an.uyu(an.ad,an.soyad);

//Anne anne = new Anne();
//Baba baba = new Baba();
//Cocuk cocuk = new Cocuk();

//anne.tanıt("Aynur", "Lebit");
//baba.tanıt("Hayrettin", "Lebit");
//cocuk.tanıt("Furkan", "Lebit");

//AkilliCocuk ak = new AkilliCocuk();
//ak.ad = "Furkan";
//ak.soyad = "Lebit";
//ak.sifat = "Akıllıdır";

//ak.AdSoyadSifatYaz(ak.ad, ak.soyad, ak.sifat);

//UsluCocuk us = new UsluCocuk();
//us.ad = "Muhammed Emin";
//us.soyad = "Lebit";
//us.sifat = "Usludur";
//us.AdSoyadSifatYaz(us.ad, us.soyad, us.sifat);

//HiperaktifCocuk hp = new HiperaktifCocuk();

//anne.Oku("Anne");
//anne.Yaz("Anne");
//anne.Dinle("Anne");

//baba.Oku("Baba");
//baba.Dinle("Baba");
//baba.Yaz("Baba");

//ak.AskereGit("AK");
//ak.EhliyetAl("AK");
//ak.KulubeGit("AK");

//us.AskereGit("US");
//us.EhliyetAl("US");

//hp.EhliyetAl("HP");

//GenelMudur gm = new GenelMudur();
//Mudur md = new Mudur();
//Programci pr = new Programci();
//Stajyer st = new Stajyer();


//double toplamMaas = 0;

//toplamMaas += gm.MaasinizNedir();
//toplamMaas += md.MaasinizNedir();
//toplamMaas += pr.MaasinizNedir();
//toplamMaas += st.MaasinizNedir();

//Console.WriteLine("Toplam Maaş : "+ toplamMaas+" TL'dir");

//Insan insan = new Insan("Furkan","Lebit");

//Goz goz = new Goz("Yeşil");
//Kulak kulak = new Kulak("Kepçe");
//Burun burun = new Burun("Kemer");

//Kafa kafa = new Kafa(goz,burun,kulak);

//YeniInsan yi = new YeniInsan(kafa,"Furkan","Lebit");

//yi.EkranaYaz();

//DbLog dblog = new DbLog();
//dblog.DbKayit("DB");

//XmlLog xmllog = new XmlLog();
//xmllog.XmlKayit("Xml");

//Logger logger = new Logger(dblog, xmllog);

//logger.LogYaz(LogType.Xml, "303 nolu hata kodu oluştu");



ILogger[] loggers = { new XmlLogger(), new CloudLogger()};

CustomerManager cm = new CustomerManager(loggers);
cm.Add("Customer1");

Type t = typeof(MyClass);
MethodInfo[] mi = t.GetMethods();
foreach (MethodInfo info in mi)
{
    ParameterInfo[] pi = info.GetParameters();
    Console.WriteLine("Metod ado : " + info.Name + ", Dönüş tipi : " + info.ReturnType);
    if(pi.Length > 0)
    {
        Console.WriteLine("parametre var");
    }
    for(int iX=0; iX < pi.Length; iX++)
    {
        Console.WriteLine(iX+1+". parametre : Dönüş değeri : "+ pi[iX].ParameterType.Name + ",  Adı : " + pi[iX].Name );
    }
}

MyClass my = new MyClass();
my.GetType().GetMethods().ToList().ForEach(method =>
{
    if(method.Name == "CostSalary")
    {
        var sonuc =method.Invoke(my,new object[] { 3,5 });
        Console.WriteLine("Maaş : " + sonuc);
    }
});