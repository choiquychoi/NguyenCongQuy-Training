using System.Collections.Generic;
using System;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int BrandId { get; set; }
}

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}


// make a
public class Data
{
    public static List<Product> Products = new List<Product>
    {
        new Product { Id = 1, Name = "Bàn trà", Price = 400, BrandId = 1 },
        new Product { Id = 2, Name = "Trang Trèo", Price = 300, BrandId = 1 },
        new Product { Id = 3, Name = "Đèn Trùm", Price = 666, BrandId = 2 },
        new Product { Id = 4, Name = "Bàn Học", Price = 200, BrandId = 2 },
        new Product { Id = 5, Name = "Túi da", Price = 400, BrandId = 3 },
        new Product { Id = 6, Name = "Tủ áo", Price = 600, BrandId = 3 },
    };

    public static List<Brand> Brands = new List<Brand>
    {
        new Brand { Id = 1, Name = "Company AAA" },
        new Brand { Id = 2, Name = "Company BBB" },
        new Brand { Id = 3, Name = "Company CCC" },
    };
}



public class Program
{
    public static void Main()
    {
        //make a example LinQ using tăng dần
        var products = Data.Products.OrderBy(p => p.Price);
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, BrandId: {product.BrandId}");
        }
    }
}
