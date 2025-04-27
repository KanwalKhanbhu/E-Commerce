using Microsoft.AspNetCore.Mvc;
using ecommerce.Models;

public class ProductsController : Controller
{
    private readonly NeondbContext _context;

    public ProductsController(NeondbContext context)
    {
        _context = context;
    }

    // GET: Products
    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    // GET: Products/Details/5
    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var product = _context.Products.FirstOrDefault(p => p.ProductId == id); // Use ProductId
        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    // GET: Products/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Products/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(product);
    }

    // GET: Products/Edit/5
    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var product = _context.Products.Find(id);
        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    // POST: Products/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Product product)
    {
        if (id != product.ProductId) // Use ProductId
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _context.Update(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(product);
    }

    // GET: Products/Delete/5
    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var product = _context.Products.FirstOrDefault(p => p.ProductId == id); // Use ProductId
        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    // POST: Products/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var product = _context.Products.Find(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
        return RedirectToAction(nameof(Index));
    }
}
