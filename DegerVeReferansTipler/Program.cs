 // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
//sayi1 ?? 30

int[] sayilar1 = new int[] { 10, 20, 30 };
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
//sayilar1[0] 999

/*
        int,float,double,decimal ,bool tipleri değer tiplerdir.
        
        array,class,interface ler = referans tiplerdir.

        stack ve heap 
        steak de değer tipler bulunur.
        
        referans tipler in tipi (yukarıdaki örnekte int) ve adı stack de bulunur ve bir adres belirlenir.
        new demek bellekte yeni bir adres oluşur demektir.

 */
