Goster();

string metin = "bugün metodlar Konusunun ilk dersi";
Console.WriteLine(metin.ToUpper());
Console.WriteLine(metin.ToLower());
Console.WriteLine(metin.Replace("ilk","2"));
Console.WriteLine(metin.StartsWith('A'));

// Parametreli metodlar
// Parametresiz metodlar

// Değer döndüren metodlar. 
// Değer döndürmeyen metodlar.
// dönüş_tipi fonksiyon_adı(parametre){}


//
void PersonalInfo(string ad, string soyad)
{
    Console.WriteLine("Merhabalar benim adım "+ad+" soyadım "+soyad);
}


void Goster()
{
    string ad = Console.ReadLine();
    string soyad = Console.ReadLine();
    PersonalInfo(ad, soyad);
}

