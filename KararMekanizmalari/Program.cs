// if else  
// kullanıcıdan konsol yardımı ile bir yaş alınız eğer girrmiş olduğu yaş değeri
//18 den büyük eşit ise Ehliyet alabilir aksi durumda ehliyet alamaz

//Console.WriteLine("Lütfen Yaşınızı Giriniz : ");
//int yas =Convert.ToInt32(Console.ReadLine());
//1. Yöntem ternary operatörü(?)
//string sonuc = yas >= 18 ? "Ehliyet alabilir" : "Ehliyet alamaz.";
//Console.WriteLine(sonuc);
// Çoklu satırları yorum satırına alan kısayol : Ctrl + k + C
// 2. Yöntem if else 

//if (yas>=18)
//{
//    Console.WriteLine("Ehliyet alabilir...");
//}
//else
//{
//    Console.WriteLine("Ehliyet Alamaz...");
//}


//görev : Kullanıcıdan age değişken adlı integer değer alan konsoldan bir girdi alınız.
// age < 13 Çocuk 
// age <18 Ergen
// age< 55 yetişkin aksi durumda ie Yaşlı 
// else if
//Console.WriteLine("Lütfen Bir yaş değeri giriniz. ");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age<13)
//{
//    Console.WriteLine("Çocuk");
//}

//else if (age < 18)
//{
//    Console.WriteLine("Ergen");
//}


//else if ( age < 55)
//{
//    Console.WriteLine("Yetişkin.");
//}
//else
//{
//    Console.WriteLine("Yaşlı");
//}


// Kullanıcının sisteme giriş yapmasını istiyoruz bilgiler doğruysa
// giriş yapıldı.
// Aksi durumda giriş yapılırken hangi alan hatalıysa o alanla alakalı bilgi verilsin.


//string username = "admin";
//string password = "12345";

//Console.WriteLine("Lütfen kullanıcı adınızı giriniz : ");
//string usernameInput = Console.ReadLine();

//Console.WriteLine("Lütfen parolanızı giriniz: ");
//string passwordInput = Console.ReadLine();


//if (username !=usernameInput || password != passwordInput)
//{
//    Console.WriteLine("Lütfen bilgilerinizi kontrol ediniz.");
//    Console.WriteLine("Parola veya kullanıcı adı hatalıdır.");
//}

//else
//{
//    Console.WriteLine("Giriş başarılı.");
//}

// Bir e ticaret sitesinden seçmiş olduğu üründen kaç tane aldığını ve 
// yapmış olduğu alışveriş sonucunda ne kadar indirim uygulanacığını hesaplayan bir sistem 

// Kullanıcının  bütçesi : 10000
// Pantolon : 1500
// gömlek : 2500
// Takım Elbise 1 : 5000
// Takım Elbise 2 : 10000
// Saat : 3500

// kullanıcıdan kaç adet almak istediğini sor
// adet sayısı * ürün = total ücret
// total ücret = 5000 den fazla ise total ücrete %15 indirim yap
// total ücret = 7000 den fazla ise total ücrete %20 indirim yap
// total ücret = 8000 den fazla ise total ücrete %25 indirim yap
// kullanıcının bütçesi 10000 i aşarsa ekran yazısı olarak Yetersiz Bakiy yazsın

double budget = 10000;
double pant = 1500;
double shirt = 2500;
double suit1 = 5000;
double suit2 = 10000;
double watch = 3500;

Console.WriteLine("Pantolon fiyatı: "+pant);
Console.WriteLine("Gömlek fiyatı: " + shirt);
Console.WriteLine("Takım elbise 1 fiyatı: " + suit1);
Console.WriteLine("Takım elbise 2 fiyatı: " + suit2);
Console.WriteLine("Saat fiyatı: " + watch);

Console.WriteLine("Kaç adet pantolon almak istersiniz ?");
int countPant = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kaç adet gömlek almak istersiniz ?");
int shirtCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kaç adet Takım elbise 1 almak istersiniz ?");
int countSuit1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kaç adet Takım elbise 2 almak istersiniz ?");
int countSuit2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kaç adet Saat almak istersiniz ?");
int countWatch = Convert.ToInt32(Console.ReadLine());

// (pantolon_ücreti* pantolon adet) + (gömlek_ücreti* gömlek adet)

double pantTotal = pant * countPant;
double shirtTotal = shirt * shirtCount;
double suitTotal = suit1 * countSuit1;
double suit2Total = suit2 * countSuit2;
double watchTotal = watch * countWatch;

double totalPrice = pantTotal + shirtTotal+ suitTotal + suit2Total+watchTotal;

if (totalPrice > 10000)
{
    Console.WriteLine("Yetersiz bakiye.");
    return;
}


if (totalPrice > 5000)
{
    double indirimsiz = totalPrice;
    Console.WriteLine("İndirimsiz fiyatı : " + indirimsiz);
    totalPrice = totalPrice - totalPrice * 0.15;
    Console.WriteLine("İndirimli fiyatı: "+totalPrice);

    double fark = indirimsiz - totalPrice;
    Console.WriteLine("Aradaki ücret farkı :" + fark);
}
 else if (totalPrice > 7000)
{
    double indirimsiz = totalPrice;
    Console.WriteLine("İndirimsiz fiyatı : " + indirimsiz);
  
    totalPrice = totalPrice - totalPrice * 0.20;
    Console.WriteLine("İndirimli fiyatı: " + totalPrice);

    double fark = indirimsiz - totalPrice;
    Console.WriteLine("Aradaki ücret farkı :" + fark);
}

else if (totalPrice > 8000)
{
    double indirimsiz = totalPrice;
    Console.WriteLine("İndirimsiz fiyatı : "+indirimsiz);
    
    totalPrice = totalPrice - totalPrice * 0.25;
    Console.WriteLine("İndirimli fiyatı: " + totalPrice);

    double fark = indirimsiz - totalPrice;
    Console.WriteLine("Aradaki ücret farkı :"+fark);
}