
for (int i = 1; i<=10;i++)
{
    Console.WriteLine("Hello, World!");
}

for (int i =1; i<=10;i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Tek Sayılar: ");
for (int i = 1; i<=10;i+=2)
{
    Console.WriteLine(i);
}
Console.WriteLine("Çift Sayıları : ");

for (int i = 0; i<=10; i+=2)
{
    Console.WriteLine(i);
}

for (int i = 0; i<= 10; i++)
{
    if (i%2==0)
    {
        Console.WriteLine($"çift sayı : {i}");
    }
    else
    {
        Console.WriteLine($"Tek Sayı : {i}");
    }
}

Console.WriteLine("Tek sayılar 2. yöntem");
for (int i = 1; i<=10;i++)
{
    if (i % 2 == 0) 
    {
        continue;
    }
    else
    {
        Console.WriteLine(i);
    }
}

// 1 den 10 a kadar döngüyü başlat ama 5 e gelince dur
Console.WriteLine("5 e gelince durudur.");
for (int i = 0; i<=10;i++)
{
    Console.WriteLine(i);

    if (i==5)
    {
        break;
    }
}
