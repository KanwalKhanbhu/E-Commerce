using Microsoft.AspNetCore.Mvc;
using ecommerce.Models;

public class ProductsController : Controller
{
    private readonly NeondbContext _context;

    public ProductsController(NeondbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var products = _context.Products.ToList(); // Example usage
        return View(products);
    }
}
