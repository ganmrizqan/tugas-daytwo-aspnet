using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using latihan2.Models;

namespace latihan2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    private static List<Book> Books = new List<Book>
    {
        new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublicationYear = "1925" },
        new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublicationYear = "1960" },
        new Book { Id = 3, Title = "1984", Author = "George Orwell", PublicationYear = "1949" },
        new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", PublicationYear = "1813" },
        new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", PublicationYear = "1951" }
    };

    public IActionResult Index()
    {
        ViewData["Message"] = "Welcome to the Book Library!";
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["Message"] = "Your privacy is important to us.";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
