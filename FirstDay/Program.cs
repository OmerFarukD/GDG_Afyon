
// Ö Ü ü ö İ ı Ğ Değişken ismi tanımlanırken kullanılmayacak kelimeler.
// Değişken ismi tanımlanırken eğer rakamsal ifade kullanılacaksa değişken ismi rakam ile başlamamalı.
// . ! ? - * / Değişken tanımlamsı yapılırken kullanılmaycak semboller. 
// değişken ismi tanımlanırken küçük harfle başlar küçük harfle biter Eğer 2. kelime ihtiyacı olursa 2. Kelimenin ilk harfi
// Büyük sonraki harfleri tekrar küçük olur.

// veri_tipi değişken_adı = değişkenin_değeri;
// string : Metinsel ifadeleri tutan veri tipidir.

string metin = "C# Çok güzel bir programlama dilidir.";

Console.WriteLine(metin);
Console.WriteLine(metin);
Console.WriteLine(metin);
Console.WriteLine(metin);

// int : Tam sayıları tutan bir veri tipidir.



int sayi1 = 697;
int sayi2 = 10;

int toplam = sayi1 + sayi2;
int cikarma = sayi1 - sayi2;
int carpma = sayi1 * sayi2;
int bolme = sayi1 / sayi2;



Console.WriteLine(toplam);
Console.WriteLine(cikarma);
Console.WriteLine(carpma);
Console.WriteLine(bolme);


// double : Ondalıklı sayılar üzerinde daha hassas hesaplama yapar.
Console.WriteLine("Double veri tipi ile alakalı işlemler aşağı da gösterilmektedir.");
double number1= 654.25;
double number2 = 125.78;

double sum = number1 + number2;
double difference = number1 - number2;
double multiply  = number1 * number2;
double divide = number1 / number2;

Console.WriteLine(sum);
Console.WriteLine(difference);
Console.WriteLine(multiply);
Console.WriteLine(divide);

// bool : True , False Doğruluk değerlerini tuttuğumuz veri tipidir.
bool dogru = true;
Console.WriteLine(dogru);

bool yanlis = false;
Console.WriteLine(yanlis);

// Operatörler

// Aritemtik operatörler (+, -,*,/, % )

// % : bir sayının diğerinden kalanını bulmak için kullanılır. 10 ile 3 ün bölümünden kalan 1
Console.WriteLine(10%3);

// Karşılaştırma Operatörleri

// < küçüktür operatörü
// > büyüktür operatörü
// == eşit midir 
// != eşit değil midir ? 
// <= küçük eşit midir ?
// >= büyük eşit midir ? 
Console.WriteLine("Karşılaştırma Operatörleri.");

Console.WriteLine(3<5); // True
Console.WriteLine(5>3); // True
Console.WriteLine(15==15); //True
Console.WriteLine(25!=25); // False 
Console.WriteLine(23<=23); // True
Console.WriteLine(78>=56); // True

// Mantıksal Operatörler 
// ve (&&) : Her iki koşul True ise True döner aksi durumlarda ise False cevabını verir.
// veya (||): Koşullardan herhangi biri True ise True değerini döner.
// Değil (!) : Koşulun sonucunun tersini alır

Console.WriteLine("Mantıksal Operatörler.");

bool sonuc = 3 < 5 && 5 > 9;
//              True   ve  False  = False

bool sonuc1 = 3 < 5 || 5 > 9;
//             True  veya False = True
Console.WriteLine(sonuc);
Console.WriteLine(sonuc1);

Console.WriteLine(!sonuc);
Console.WriteLine(!sonuc1);

// Atama Operatörleri : (=, +=, *=,/=, %=)

int a = 40;


// Toplam atama 
//1. Yöntem 
//a = a + 5;

// 2. Yöntem
//a += 5;


// Çarpım atama 
//a = a * 5;

a *= 5;

// Bölüm atama 
//a = a / 10;
//a /= 10;

//a = a % 20;
a %= 20;
Console.WriteLine(a);

// Arttırma ve azaltma operatörleri  (++,--)

Console.WriteLine("Arttırma ve azaltma operatörleri.");
int b = 10;


// Prefix increment 
Console.WriteLine(++b);

int x = 25;
Console.WriteLine(--x);

// Postfix increment 
Console.WriteLine(x++);

// Prefix increment  Örneği
Console.WriteLine("Prefix increment");
int m = 5;
int n = ++m;

Console.WriteLine(m); //6
Console.WriteLine(n); // 6


// Postfix increment  Örneği
Console.WriteLine("Postfix increment");

int j = 5;
int k = j++; 
Console.WriteLine(j);
Console.WriteLine(k);

string ad = "Ömer Faruk ";
Console.WriteLine(ad+="Doğan");

// Ternary Koşul operatörü(?);

// bir tane yaş değişkeni tanımlayınız ve bu yaş değişkeninin değeri 18 den büyük eşit ise 
// Ekran çıktısı olarak Ehliyet alabilir yazısı çıksın aksi durumda ise Ehliyet alamaz

int yas = 10;
string ehliyet = yas >= 18 ? "Eyliyet alabilir" : "Ehliyet alamaz.";
Console.WriteLine(ehliyet);

int number3 = 25;
int number4 = 25;


int age = 38;
string name = "Mehmet";
string surname = "Eroğlu";

string cikti = "Merhaba benim adım " + name + ", Soyadım " + surname + " Yaşım " + age;
Console.WriteLine(cikti);

string buyuktur = number3 > number4 || number3==number4  ? number3 + " " + number4 + " den büyüktür"  : number4 + " " + number3 + "den büyüktür";
Console.WriteLine(buyuktur);
