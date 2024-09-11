//// şehirleri tutan bir dizi oluşturunuz.
//string[] sehirler = {"İstanbul","Afyon","İzmir","Ankara","Eskişehir" };
////                        0          1      2       3         4

//Console.WriteLine(sehirler[1]);
//Console.WriteLine($"Uzunluğu  : {sehirler.Length}");
//Console.WriteLine("Hepsini Yazdır.");
//for (int i = 0; i<sehirler.Length; i++)
//{
//    Console.WriteLine(sehirler[i]);
//}

//// foreach yöntemi : 
//Console.WriteLine("Foreach yöntemi : ");
//foreach (string sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}
int[] sayilar = { 25, 6, 3, 2, 1, 4, 7, 8, 66, 55, 88, 74, 100 };
Console.WriteLine($"Sayılar dizisindeki tüm elemanların toplamı : {sayilar.Sum()}");
Console.WriteLine($"Sayılar dizisindeki en küçük eleman : {sayilar.Min()}");
Console.WriteLine($"Sayılar dizisindeki en büyük eleman : {sayilar.Max()}");
Console.WriteLine($"Sayılar dizinin ortalaması : {sayilar.Average()}");


// diziyi küçükten büyüğe sırala : 

Array.Sort(sayilar);
Console.WriteLine("Verileri küçükten büyüğe sıralayan kod: ");
foreach( var say in sayilar)
{
    Console.WriteLine(say);
}

Console.WriteLine("Büyükten küçüğe doğru sırala : ");
Array.Reverse(sayilar);

foreach( var say in sayilar)
{
Console.WriteLine(say); 
}

// sayilar dizisinde 25 ten büyük olan bütün sayıları ekrana bastıran kodu yazınız.
//1. Yöntem
Console.WriteLine("25 ten büyük olan verileri listele");
//foreach ( var say in sayilar)
//{
//    if (say > 25)
//    {
//        Console.WriteLine(say);
//    }
//}

//int[] filteredNumbers = Array.FindAll(sayilar,x=> x>25);
//Array.ForEach(filteredNumbers, x => Console.WriteLine(x));

//Console.WriteLine("3. Yöntem");
//Array.ForEach(sayilar, x =>
//{
//    if (x > 25)
//    {
//        Console.WriteLine(x);
//    }
//});

// meyveler adında bir dizi olsun meyve isimlerinde E e geçen meyveleri listelesin.

string[] meyveler = {"Elma","Armut","Kiraz","Şeftali","Erik","Çilek","Ayva","Hurma"};

//foreach (string meyve in meyveler)
//{
//    //1. Yöntem : meyve.ToLower().Contains("e")
//    //2. Yöntem : meyve.Contains("e")|| meyve.Contains("E")
//    // 3. Yöntem : meyve.Contains("e",StringComparison.InvariantCultureIgnoreCase)
//    if (meyve.Contains("e",StringComparison.InvariantCultureIgnoreCase))
//    {
//        Console.WriteLine(meyve);
//    }
//}

//string[] filteredFruits = Array.FindAll(meyveler, x=> x.Contains("e",StringComparison.InvariantCultureIgnoreCase));
//Array.ForEach(filteredFruits, x=> Console.WriteLine(x));

Array.ForEach(meyveler, x =>
{
    if (x.Contains("e",StringComparison.InvariantCultureIgnoreCase))
    {
        Console.WriteLine(x);
    }
});

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 83, 96, 102, 105, 88, 95 };
int[] ciftSayilar = Array.FindAll(numbers, x=> x%2==0);
int[] tekSayilar = Array.FindAll(numbers, x=> x%2==1);

Console.WriteLine("Tek sayılar: ");
Array.ForEach(tekSayilar, x => Console.WriteLine(x));

Console.WriteLine("Çift sayılar: ");
Array.ForEach(ciftSayilar, x=> Console.WriteLine(x));


double[] doubles = { 10.5, 11, 12, 100.25, 68.78 };

Console.WriteLine("While döngüsü ile yazıldı.");
int i = 0;
while (i<doubles.Length)
{
    Console.WriteLine(doubles[i]);

    if (doubles[i] == 11)
    {
        Console.WriteLine("11 e geldin dur");
        i++;
        continue;
    }
    else
    {
        i++;
    }


}
