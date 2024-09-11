namespace OOP_Giris;
public class ProductManager
{
    List<Product> products = new List<Product>()
    {
       new Product{Name="Fifine mikrofon", CategoryName="Bilgisayar aleti",Price=35000,Stock=155},
       new Product{Name="Samsung s24", CategoryName="Telefon",Price=65000,Stock=125},
       new Product{Name="Msi Bravo", CategoryName="Bilgisayar",Price=45000,Stock=10},
       new Product{Name="Monster Abra", CategoryName="Bilgisayar",Price=35000,Stock=15},
    };

    public void Add(Product product)
    {
        products.Add(product);
        Console.WriteLine("Ürün eklendi: ");
        Console.WriteLine(product);
    }

    //public void Remove(Product product)
    //{
    //    foreach (Product item in products)
    //    {
    //        if (item.Name == product.Name)
    //        {
    //            products.Remove(product);
    //        }
    //    }

    //    Console.WriteLine("Ürün silindi: ");
    //    Console.WriteLine(product);
    //}

    public void GetAll()
    {
        Console.WriteLine("Bütün ürünler listelendi.");
        //foreach (Product product in products)
        //{
        //    Console.WriteLine(product);
        //}

        products.ForEach(x=> Console.WriteLine(x));
    }

    public void GetAllByPriceRange(double min, double max)
    {
        //foreach (Product product in products) 
        //{ 
        //    if(product.Price <= max && product.Price>= min)
        //    {
        //        Console.WriteLine(product);
        //    }
        //}

    List<Product> filteredProducts =  products.Where(x => x.Price <= max && x.Price >= min).ToList();
        filteredProducts.ForEach(x=> Console.WriteLine(x));
    
    }

    public void GetAllProductsNameContains(string name)
    {
        //foreach(Product product in products)
        //{
        //    if (product.Name.Contains(name))
        //    {
        //        Console.WriteLine(product);
        //    }
        //}

        List<Product> filteredProducts = products.Where(x=> x.Name.Contains(name)).ToList();
        filteredProducts.ForEach (x=> Console.WriteLine(x));
    }

    public void ProductPriceSum()
    {
        //double total = 0;
        //foreach (Product product in products)
        //{
        //    total = total + product.Price;
        //}
        Console.WriteLine($"Ürünlerin fiyatlarının Toplamı : {products.Sum(x=> x.Price)}");
    }

    public void ProductPriceAverage()
    {

        //double total = 0;
        //foreach (Product product in products)
        //{
        //    total = total + product.Price;
        //}

        //double average = total / products.Count;

        Console.WriteLine($"ürünlerin fiyat ortalaması : {products.Average(x=> x.Price)}");
    }

    public void GetAllProductsOrderByAscendingPrice()
    {
        List<Product> orderProducts = products.OrderBy(x=> x.Price).ToList();
        orderProducts.ForEach(x=> Console.WriteLine(x));
    }
    public void GetAllProductsOrderByDescendingPrice()
    {
        List<Product> orderProducts = products.OrderByDescending(x => x.Price).ToList();
        orderProducts.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllProductNames()
    {
        List<string> names = products.Select(x => x.Name).ToList();
        names.ForEach(x => Console.WriteLine(x));
    }
}
