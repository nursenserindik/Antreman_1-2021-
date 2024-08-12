static void Main(string[] args)
{

    Console.ReadKey();
}

static void Soru9()
{
    string[,] dizi = new string[5, 10];

    for (int x = 0; x < 5; x++)
    {
        for (int y = 0; y < 10; y++)
        {
            if (y == 4 || y == 5)
                dizi[x, y] = "*";
            if (x == 4 || x == y || (dizi.GetLength(1) - 1) - y == x)
                dizi[x, y] = "*";
        }
    }

    for (int x = 0; x < dizi.GetLength(0); x++)
    {
        for (int y = 0; y < dizi.GetLength(1); y++)
        {
            if (dizi[x, y] == "*")
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
    dizi = new string[5, 10];

    for (int x = 0; x < dizi.GetLength(0); x++)
    {
        for (int y = 0; y < dizi.GetLength(1); y++)
        {
            if (y == 4 || y == 5)
                dizi[x, y] = "*";

            if (x == 0 || x + y == 4 || y - x == 5)
                dizi[x, y] = "*";
        }
    }

    for (int x = 0; x < dizi.GetLength(0); x++)
    {
        for (int y = 0; y < dizi.GetLength(1); y++)
        {
            if (dizi[x, y] == "*")
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }

}


static void Soru8()
{
    /*
     *  5x5 lik bir dizi tanımlayınız. Dizi içerisine rastgele 0 ile 100 arasında değerler atayınız. Eğer aynı indeks
        numaraları satır ve sütunun değerlerinin toplamı eşitse bunlar kardeş kolonlardır. Örneğin 0. indeks numarasına
        sahip satırın elemanları toplamı ile 0. indeks numarasına sahip sütunun elemanları toplamı eşitse bunlar kardeş
        satırlardır. Ekrana kardeş kolonları yazan programı yazınız. Örneğin:"1. satır ile 1. sütun kardeş kolonlardır."
     */

    int[,] dizi = new int[5, 5];
    Random rnd = new Random();
    bool kardesVar = false;

    for (int x = 0; x < 5; x++)
    {
        for (int y = 0; y < 5; y++)
        {
            dizi[x, y] = rnd.Next(0, 10);
            Console.Write("{0,2}", dizi[x, y]);
        }
        Console.WriteLine();
    }

    for (int x = 0; x < 5; x++)
    {
        int t1 = 0;
        int t2 = 0;
        for (int y = 0; y < 5; y++)
        {
            t1 += dizi[x, y];
            t2 += dizi[y, x];
        }

        if (t1 == t2)
        {
            Console.WriteLine("{0}. satır ile {0}. sütun kardeş kolonlardır", x);
            kardesVar = true;
        }

    }

    if (kardesVar == false)
        Console.WriteLine("\nKardeş kolon bulunmadı.");

}

static void Soru7()
{
    /*
     * 3x3 lük iki tane matris tanımlayın ve bu matrisler içerisine dönhüler yardımı ile dışarıdan değer giriniz.
       Program tarafından matrislerin toplamımı yoksa farkımı istendiği sorulsun. Kullanıcının isteğine göre işlemi
       yapan programı yazınız.
     */

    int[,] dizi1 = new int[3, 3];
    int[,] dizi2 = new int[3, 3];

    for (int x = 0; x < 3; x++)
    {
        for (int y = 0; y < 3; y++)
        {
            Console.Write("Sayı: ");
            dizi1[x, y] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine();
    for (int x = 0; x < 3; x++)
    {
        for (int y = 0; y < 3; y++)
        {
            Console.Write("Sayı: ");
            dizi2[x, y] = Convert.ToInt32(Console.ReadLine());
        }
    }

    Console.Write("Matrislerin toplamı için t, farkı için f gir: ");
    string secim = Console.ReadLine();

    for (int x = 0; x < 3; x++)
    {
        for (int y = 0; y < 3; y++)
        {
            if (secim == "t")
                Console.WriteLine(dizi1[x, y] + dizi2[x, y]);
            else if (secim == "f")
                Console.WriteLine(dizi1[x, y] - dizi2[x, y]);
        }
    }

}
static void Soru5()
{
    /*
     * Eleman sayıları aynı olan iki adet dizi tanımlayınız. Birinci diziye rastgele elemanlar atayınız. Birinci dizinin
       ilk elemanı ikinci dizinin son elemanı olacak şekilde tersten birinci dizi elemanlarını ikinci dizi içersine
       kopyalayınız.
     */

    int[] dizi = new int[5];
    int[] kopya = new int[5];
    Random rnd = new Random();

    for (int x = 0; x < dizi.Length; x++)
        dizi[x] = rnd.Next(42);

    for (int x = 0, y = 4; x < dizi.Length; x++, y--)
    {
        kopya[y] = dizi[x];
    }

}

static void Soru4()
{
    /*
     * Tek boyutlu, int tipinde değer alabilen 4 elemanlı bir dizi oluşturun. Dizi içersine değerleri dışarıdan girin.
       Dizi içersindeki elemanların toplamını dizinin ilk elemanı, dizi elemanlarının çarpımını dizinin 2. elemanı, tek
       sayıların toplamını dizinin 3. elemanı, çift sayıların toplamını ise dizinin 4. elemanı olarak atayınız.
     */

    int[] dizi = new int[4];

    for (int x = 0; x < dizi.Length; x++)
    {
        Console.Write("Sayı gir: ");
        dizi[x] = Convert.ToInt32(Console.ReadLine());
    }

    int toplam = 0, carpim = 1, tekToplam = 0, ciftToplam = 0;

    for (int x = 0; x < dizi.Length; x++)
    {
        toplam += dizi[x];
        carpim *= dizi[x];

        if (dizi[x] % 2 == 0)
            ciftToplam += dizi[x];
        else
            tekToplam += dizi[x];
    }

    dizi[0] = toplam;
    dizi[1] = carpim;
    dizi[2] = tekToplam;
    dizi[3] = ciftToplam;
}

static void Soru2()
{
    /*
     *  Bir sınıfta 20 öğrenci bulunmaktadır. Öğrencilerin adı, soyadı, numarası, fizik, kimya, derslerine ait notları
        saklanacaktır.
         Program ilk açıldığını da size yapacağınız işlem sorulacaktır. Yapılacak işlemler aşağıda listelenmiştir.
        i) Öğrenci bilgisi girmek için "o" tuşuna basınız.
        ii) Öğrenci notu girmek için "n" tuşuna basınız.
        iii) Bir öğrenciye ait bilgileri ve ders notlarını listelemek için "l" tuşuna basınız.
        iv) Öğrencinin notlarını düzeltmek için "d" tuşuna basınız.
        v) Çıkmak için "c" tuşuna basınız.
         Fizik kimya dersleri için vize, final notu baz alınacaktır.
         Programdan c tuşuna basılmadığı sürece her defasında yapılacak işlemler sorulacaktır.
         Kullanacağınız dizleri 2 boyutlu yada 1 boyutlu yapabilirsiniz.
     */

    string[,] ogrBilgiler = new string[3, 3];
    double[,] ogrNotlar = new double[3, 4];
    bool islemBittiMi = false;
    while (true)
    {
        Console.WriteLine("Öğrenci bilgisi girmek için 'o' tuşuna basınız.");
        Console.WriteLine("Öğrenci notu girmek için 'n' tuşuna basınız.");
        Console.WriteLine("Bir öğrenciye ait bilgileri ve ders notlarını listelemek için 'l' tuşuna basınız.");
        Console.WriteLine("Öğrencinin notlarını düzeltmek için 'd' tuşuna basınız.");
        Console.WriteLine("Çıkmak için 'c' tuşuna basınız.");
        Console.Write("Seçim: ");
        char secim = Convert.ToChar(Console.ReadLine());
        Console.WriteLine();
        switch (secim)
        {
            case 'o':
                {
                    for (int x = 0; x < ogrBilgiler.GetLength(0); x++)
                    {
                        Console.WriteLine((x + 1) + ". öğrencinin: ");
                        Console.Write("Adı: ");
                        ogrBilgiler[x, 0] = Console.ReadLine();
                        Console.Write("Soyadı: ");
                        ogrBilgiler[x, 1] = Console.ReadLine();
                        Console.Write("Numarası: ");
                        ogrBilgiler[x, 2] = Console.ReadLine();
                        Console.WriteLine();
                    }
                    Console.Write("\n");
                    break;
                }
            case 'l':
                {
                    Console.Write("Öğrenci numarası: ");
                    int numara = Convert.ToInt32(Console.ReadLine());

                    for (int x = 0; x < ogrBilgiler.GetLength(0); x++)
                    {
                        if (numara != Convert.ToInt32(ogrBilgiler[x, 2]))
                            continue;

                        Console.WriteLine("Öğrencinin");
                        Console.WriteLine("Adı: " + ogrBilgiler[x, 0]);
                        Console.WriteLine("Soyadı: " + ogrBilgiler[x, 1]);
                        Console.WriteLine("Numarası: " + ogrBilgiler[x, 2]);
                        Console.WriteLine("Fizik Vize Notu: " + ogrNotlar[x, 0]);
                        Console.WriteLine("Fizik Final Notu: " + ogrNotlar[x, 1]);
                        Console.WriteLine("Kimya Vize Notu: " + ogrNotlar[x, 2]);
                        Console.WriteLine("Kimya Final Notu: " + ogrNotlar[x, 3]);
                        Console.Write("\n");
                    }
                    break;
                }
            case 'n':
                {
                    Console.Write("Öğrenci numarası: ");
                    int numara = Convert.ToInt32(Console.ReadLine());

                    for (int x = 0; x < ogrBilgiler.GetLength(0); x++)
                    {
                        if (numara != Convert.ToInt32(ogrBilgiler[x, 2]))
                            continue;

                        Console.WriteLine(numara + " numaralı öğrencinin: ");
                        Console.Write("Fizik Vize Notu: ");
                        ogrNotlar[x, 0] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fizik Final Notu: ");
                        ogrNotlar[x, 1] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Kimya Vize Notu: ");
                        ogrNotlar[x, 2] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Kimya Final Notu: ");
                        ogrNotlar[x, 3] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                    }
                    break;
                }
            case 'd':
                {
                    Console.Write("Öğrenci numarası: ");
                    int numara = Convert.ToInt32(Console.ReadLine());

                    for (int x = 0; x < ogrBilgiler.GetLength(0); x++)
                    {
                        if (numara != Convert.ToInt32(ogrBilgiler[x, 2]))
                            continue;

                        Console.WriteLine(numara + " numaralı öğrencinin: ");
                        Console.Write("Fizik Vize Notu: ");
                        ogrNotlar[x, 0] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fizik Final Notu: ");
                        ogrNotlar[x, 1] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Kimya Vize Notu: ");
                        ogrNotlar[x, 2] = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Kimya Final Notu: ");
                        ogrNotlar[x, 3] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                    }
                    break;
                }
            case 'c':
                {
                    islemBittiMi = true;
                    break;
                }
        }

        if (islemBittiMi)
            break;
    }

}

static void Soru1()
{
    /*
     *  10 elemanlı bir dizi tanımlayınız. Dizi içersine rastgele sayılar yerleştiriniz.
        a) Dizinin elemanlarının toplamını bulunuz.
        b) Dizinin elemanlarının ortalamasını bulunuz.
        c) Dizi içersindeki en büyük sayıyı bulunuz.
        d) Dizi içersindeki en küçük sayıyı bulunuz.
        e) Rastgele yerleştirilen elemanlar içerisinden aynı olan elemanlar var ise bunların sayısını ekrana yazın.
        f) Rastgele yerleştirilen elemanlar içersinden içinde 1 rakamı kaç defa kullanıldığını bulunuz.
        Örneğin: Dizi içersindeki sayılar => 11,58,21,756,1907 olsun burada 1 rakamı 4 defa kullanılmıştır.
     */

    int[] dizi = new int[10];
    Random rnd = new Random();

    for (int x = 0; x < dizi.Length; x++)
        dizi[x] = rnd.Next(10);

    double toplam = 0;
    string strToplam = "";
    int birMiktar = 0;

    for (int x = 0; x < dizi.Length; x++)
    {
        toplam += dizi[x];
        strToplam += dizi[x];
        int sayac = 0;
        for (int y = 0; y < dizi.Length; y++)
        {
            if (dizi[y] == x)
            {
                sayac++;
            }
        }
        if (sayac > 1)
            Console.WriteLine($"{x} sayısı {sayac} adet tekrar etmiştir.");
    }
    foreach (char ch in strToplam)
    {
        if (ch == '1')
            birMiktar++;
    }

    Console.WriteLine();

    double ortalama = toplam / 10;
    Array.Sort(dizi);


    Console.WriteLine("Sayıların Toplamı: " + toplam);
    Console.WriteLine("Sayıların Ortalaması: " + ortalama);
    Console.WriteLine("En Küçük Sayı: " + dizi[0]);
    Console.WriteLine("En Büyük Sayı: " + dizi[dizi.Length - 1]);
    Console.WriteLine("1 rakamı dizide {0} kez kullanılmıştır.", birMiktar);
}

static void Soru11()
{
    /*
     * Tek boyutlu, eleman sayısı 5 ile 14 arasında rastgele belirlenmiş bir dizi tanımlayın. Dizinin elemanlarına
       değer olarak o elemanın indeks numarasının 5 katını atayın. While döngüsü kullanarak yapınız. 
     */
    Random rnd = new Random();
    int[] dizi = new int[rnd.Next(5, 14)];

    int x = 0;
    while (x < dizi.Length)
    {
        dizi[x] = x * 5;
        x++;
    }

    foreach (int sayi in dizi)
        Console.WriteLine(sayi);

}

static void Soru12()
{
    object[,] bilgiler = new object[6, 2]
    {
                {"Defter",6.50},
                {"Kalem", 1d},
                {"Silgi", 0.5},
                {"Not defteri",2.5},
                {"Kalem açacağı",0.5},
                {"Pergel",1.5},
    };

    int[] urunMiktar = new int[6];
    double toplam = 0;

    for (int x = 0; x < bilgiler.GetLength(0); x++)
    {
        Console.Write("{0} ürününden kaç adet istiyorsunuz?: ", bilgiler[x, 0]);
        urunMiktar[x] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    for (int x = 0; x < urunMiktar.Length; x++)
    {
        if (urunMiktar[x] == 0)
            continue;
        toplam += urunMiktar[x] * Convert.ToDouble(bilgiler[x, 1]);
        Console.WriteLine("{0,14} {1,2} adet = {1,2} * {2,4}tl = {3}tl"
            , bilgiler[x, 0], urunMiktar[x], bilgiler[x, 1], urunMiktar[x] * Convert.ToDouble(bilgiler[x, 1]));
    }
    Console.WriteLine("Toplam: {0} TL", toplam);
}
