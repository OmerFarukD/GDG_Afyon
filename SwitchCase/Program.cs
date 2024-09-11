// Kullanıcıdan 1 den 7 ye kadar bir rakam alınız ve bu rakama göre
// haftanın hangi gününe denk geliyorsa o günü ekran çıktısı olarak yazınız.

//Console.WriteLine("Lütfen bir rakam giriniz ? ");
//int day = Convert.ToInt32(Console.ReadLine());

//// Geleneksel yöntem
//switch (day)
//{
//    case 1: Console.WriteLine("Paartesi");
//        break;
//    case 2: Console.WriteLine("Salı");
//        break;
//    case 3: Console.WriteLine("Çarşamba");
//        break;
//    case 4: Console.WriteLine("Perşembe");
//        break;
//    case 5: Console.WriteLine("Cuma");
//        break;
//    case 6: Console.WriteLine("Cumartesi");
//        break;
//    case 7: Console.WriteLine("Pazar");
//        break;

//    default: Console.WriteLine("Lütfen 1 ile 7 arasında bir rakam giriniz.");
//        break;
//}

// switch expression
// kullanıcıdan 1 ile 4 arasında bir rakam alalım ve bu rakama göre mevsimleri  sırasıyla ekrana
// yazan sistemi kodlayınız.
// Kış ilkbahar yaz sonbahar

//Console.WriteLine("Lütfen bir rakam giriniz:");
//int mevsimSayisi = Convert.ToInt32(Console.ReadLine());

//string mevsimAdi = mevsimSayisi switch
//{
//    1 => "Kış",
//    2 => "İlk Bahar",
//    3 => "Yaz",
//    4 => "Son Bahar",
//    _ => "Lütfen 1 ile 4 arasında bir rakam giriniz."
//};
//Console.WriteLine(mevsimAdi);

// görev : Kullanıcıdan age değişken adlı integer değer alan konsoldan bir girdi alınız.
//0<age < 13 Çocuk 
// 13<age <18 Ergen
// 18<age< 55 yetişkin aksi durumda ie Yaşlı 

using OOP_Giris;
using System.Net.Http.Headers;

Console.WriteLine("Lütfen bir yaş giriniz : ");
int age = Convert.ToInt32(Console.ReadLine());
string category;

// geleneksel yöntem:

switch (age)
{
    case int a when (a > 0 && a < 13):
        category = "küçük";
        break;
    case int a when (a > 13 && a < 18):
        category = "Genç";
        break;
    case int a when (a > 18 && a < 55):
        category = "Yetişkin";
        break;

    case int a when a >= 55:
        category = "Yaşlı";
        break;
    default:
        category = "Geçersiz Kategori";
        break;
}
Console.WriteLine(category);

// görev : Kullanıcıdan age değişken adlı integer değer alan konsoldan bir girdi alınız.
//0<age < 13 Çocuk 
// 13<age <18 Ergen
// 18<age< 55 yetişkin aksi durumda ie Yaşlı 
// Switch Expression : 
//category = age switch
//{
//    > 0 and < 13 => "Çocuk",
//    > 13 and < 18 => "Ergen",
//    30 => "Yaşınız 30 dikkat edin.",
//    > 18 and < 55 => "Yetişkin",
//    > 55 => "Yaşlı",
//    _ => "Geçersiz Kategori."
//};

// metnin değeri a olur ise ekran yazısı olarak a yazısını yazdınız.

// metnin değeri b olur ise ekran yazısı olarak b yazısını yazdınız.
string metin = "a";

switch (metin)
{
    case "a":
        Console.WriteLine("a yazısını girdiniz.");
        break;
    case "b":
        Console.WriteLine("b yazısını girdiniz.");
        break;
}

