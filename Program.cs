using System.Collections.Generic;
using System;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int BrandId { get; set; }
}

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }
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
    // make a example LinQ using Select clause
    public static void Main()
    {
        var query = from p in Data.Products
                    select new
                    {
                        p.Id,
                        p.Name,
                        p.Price,
                        BrandName = (from b in Data.Brands
                                    where b.Id == p.BrandId
                                    select b.Name).FirstOrDefault()
                    };

        foreach (var item in query)
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}, BrandName: {item.BrandName}");
        }
    }
}
