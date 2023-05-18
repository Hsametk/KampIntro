    // See https://aka.ms/new-console-template for more information
    Kurs kurs1 = new Kurs();
    kurs1.KursAdi = ("c#");
    kurs1.Egitmen = ("Engin");
    kurs1.izlenmeOrani = 1200;

    Kurs kurs2 = new Kurs();
    kurs2.KursAdi = (".net");
    kurs2.Egitmen = ("Samet");
    kurs2.izlenmeOrani = 100;

    //Console.WriteLine(kurs1.KursAdi + ": "+kurs1.Egitmen);
    Kurs[] kurslar = new Kurs[] { kurs1, kurs2};
    foreach (var kurs in kurslar)
    {
        Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
    }

//Ödev 3
int day = 5;
switch (day)
{
    case 0:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("1 ile 7 arasında bir rakam giriniz. ");
        break;
}
//Ödev 4
int i = 0;
while (i<10)
{
    Console.WriteLine(i);
    i++;
}
//Ödev6
    Product product1 = new Product();
    product1.ıd = 5;
    product1.productName = ("Computer");
    product1.productValue = 3000;

Product product2 = new Product();
product2.ıd = 6;
product2.productName = ("Mac");
product2.productValue = 4000;
Product[] urunler = new Product[] { product1,product2 }; 

foreach (var product in urunler)
{
    Console.WriteLine("ID:"+product.ıd+" "+"urun adi:"+product.productName+" "+"Ürün Değeri"+product.productValue);   
}
Console.WriteLine("foreach bitt");
for (int j= 0; j < urunler.Length; j++)
{
    Console.WriteLine("ID:" + urunler[i].ıd + " " + "urun adi:" + urunler[i].productName + " " + "Ürün Değeri" + urunler[i].productValue);
    j++;
}
Console.WriteLine("for bitti");
int k = 0;
while (k < urunler.Length)
{
    Console.WriteLine("ID:" + urunler[i].ıd + " " + "urun adi:" + urunler[i].productName + " " + "Ürün Değeri" + urunler[i].productValue);
    k++;
}
class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
class Product
{
    public int ıd { get; set; }
    public string productName { get; set; }
    public int productValue { get; set; }
}
//ClassIntro Ödev 1
// Diğer veri türler nelerdir?
// char , double,decimal,float gibi
//***********************************

/*
C# dilinde "ternary operatörü" araştırınız. Ternary Operatörü bilmeyen birine yazıyla anlatmanız gerekseydi, nasıl anlatırdınız?
    Bir if koşulunu tek satırda yazmamızı sağlar.
    örnek
            int number = 2;
			bool isEven;

			isEven = (number % 2 == 0) ? true : false ;  
			Console.WriteLine(isEven);
*/


