namespace OOP_Giris;
public class Product
{
   public string Name;
   public string CategoryName;
   public double Price;
   public int Stock;

    //public void EkranaYaz()
    //{
    //    Console.WriteLine($"ürün adı : {Name}, ürün kategorisi : {CategoryName}");
    //    Console.WriteLine($"ürünün değeri : {price}");
    //    Console.WriteLine($"ürünün stoğu : {stock}");
    //}

    public override string ToString()
    {
        return $"ADI:{Name}, Değeri:{Price}, Kategori: {CategoryName},stok: {Stock}";
    }
}
