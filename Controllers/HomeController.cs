using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practice_C_.Models;

namespace practice_C_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // from products.cs model class make a list of products and return it to the view but it hace to return to the home/index view

        var products = new List<Products>
        {
            new Products { Id = 1, Name = "Product 1", Price = 10.0m },
            new Products { Id = 2, Name = "Product 2", Price = 20.0m },
            new Products { Id = 3, Name = "Product 3", Price = 30.0m },
            new Products { Id = 4, Name = "Product 4", Price = 40.0m },
            new Products { Id = 5, Name = "Product 5", Price = 50.0m }
        };
        // return the list of products to the home/ index view
        return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = new Products { Id = id, Name = "Product " + id, Price = 10.0m * id };
        return View(product);
    }
}
