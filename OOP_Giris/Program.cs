// ürün = adı, stok adedi , kategori adı , ürünün değer (Özellik tutan classlar)
// sipariş ekleme, sipariş sil (İş yapan classlar)
// Ürün ekleme, ürün silme , Ürün listeleme kodlarını yaz
using OOP_Giris;

Console.WriteLine("Hello, World!");

//Product product = new Product();
//product.Name = "Msi Bravo";
//product.price = 35500;
//product.CategoryName = "Bilgisayar";
//product.stock = 150;
//Product product1 = new();
//product1.Name = "asd";
//product1.stock = 250;
//product1.CategoryName = "Deneme";

//Product product2 = new()
//{
//    CategoryName = "Elektronik Cihazlar",
//    Name = "Telefon",
//    price = 35000,
//    stock = 250
//};

//Console.WriteLine(product);

Product product = new Product()
{
    Name = "Fifine Mikrofon",
    CategoryName = "Bilgisayar aletleri",
    Price = 3500,
    Stock = 250
};

ProductManager productManager = new ProductManager();
productManager.Add(product);
productManager.GetAll();
Console.WriteLine("Fiyatı 30000 ile 50000 tl arasındaki ürünler.");
productManager.GetAllByPriceRange(30000,50000);
Console.WriteLine("------------------------------------------");
Console.WriteLine("İsim içerisinde Mo geçenleri listele:");
productManager.GetAllProductsNameContains("Mo");
Console.WriteLine("------------------------------------------");
productManager.ProductPriceSum();
Console.WriteLine("------------------------------------------");
productManager.ProductPriceAverage();
Console.WriteLine("------------------------------------------");
Console.WriteLine("Ürünlerin fiyatları artacak şekilde listele: ");
productManager.GetAllProductsOrderByAscendingPrice();

Console.WriteLine("------------------------------------------");
Console.WriteLine("Ürünlerin fiyatları azalacak şekilde listele: ");
productManager.GetAllProductsOrderByDescendingPrice();

Console.WriteLine("------------------------------------------");
Console.WriteLine("Ürünlerin adını listele: ");
productManager.GetAllProductNames();




//productManager.Remove(product);