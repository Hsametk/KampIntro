// See https://aka.ms/new-console-template for more information

using Metotlar;
string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "Amasya elması";

string[] meyveler = new string[] { "Elma", "Karpuz" };

Product urun1 = new Product();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Product urun2 = new Product();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Product[] urunler = new Product[] { urun1, urun2 };

//type-safe -- tip güvenli
foreach (var urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("--------------------");
}

Console.WriteLine("------------Metotlar---------------");
//instance - örnek
//encapsulation

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
//Ekle2 gibi kullanırsan yeni bir özellik eklemek istediğin zaman her sayfaya tek tek eklemen gerekir.
// Fakat ekle gibi class kullanarak yaparsan işin daha çok kolaylaşır ve tavsiye edilen kullanım şeklindedir.
// Dont repead yourself - DRY - Clean Code - Best Practice