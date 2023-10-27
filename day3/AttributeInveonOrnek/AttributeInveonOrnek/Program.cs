using AttributeInveonOrnek;

Ogrenci ogr= new Ogrenci();


ogr.adi = "Furkan";
ogr.soyadi = "Lebit";
ogr.bolum = "Yazılım";

if (!ZorunlulukKontrolu.Dogrula(ogr))
{
    Console.WriteLine("öğrenci bilgileri girilmesi zorunludur");
}
else
{
    Console.WriteLine("form başarılı");
}