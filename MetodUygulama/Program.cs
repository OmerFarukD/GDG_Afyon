// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(Topla(35, 85));

int toplam = Topla(69,74);
Console.WriteLine(toplam);

double kuvvet = F(5,10.89);
Console.WriteLine(kuvvet);

int bolum;
int kalan;
Divide(11,3,out bolum, out kalan);
Console.WriteLine($"sayının bölümünün sonucu {bolum}");
Console.WriteLine($"sayının modunun sonucu {kalan}");



// Bir bölme işleminde sonuç , hemde kalanı bulmak istiyoruz

int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}
void Topla2(int sayi1, int sayi2)
{
    Console.WriteLine(sayi1 + sayi2);
}

double F(double m, double a)
{
    return m * a;
}

// out: bir metodun birden fazla değer döndürmesini istiyorsak out keywordunu kullanmak gerekir

void Divide(int bolunen, int bolen, out int sonuc, out int kalan)
{
    sonuc = bolunen / bolen;
    kalan = bolunen % bolen;
} 
