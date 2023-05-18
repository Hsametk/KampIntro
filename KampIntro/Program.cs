// See https://aka.ms/new-console-template for more information
    string KategoriEtiketi = "Kategoriler";
    int ogrenciSayisi = 3200;
    double faizOrani = 1.45;
    bool sistemeGirisYapmisMi = true;
    double dolarDun = 7.55;
    double dolarBugun = 7.55;


    if (dolarDun > dolarBugun)
    {
        Console.WriteLine("Azalış butonu");
    }
    else if (dolarDun < dolarBugun)
    {
        Console.WriteLine("Artış butonu");
    }
    else
    {
        Console.WriteLine("değişmedi butonu");
    }


    if (sistemeGirisYapmisMi == true)
    {
        Console.WriteLine("Kullanici Ayarlar Butonu");
    }
    else
    {
        Console.WriteLine("Giris Yap Butonu");
    }

    Console.WriteLine(KategoriEtiketi);
