using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductTASK.Data.Context;
using ProductTASK.Models;
using ProductTASK.Services.Interfaces;

namespace ProductTASK.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductService productService;

        public ProductsController(ApplicationDbContext context,
                                  IProductService productService)
        {
            _context = context;
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await productService.GetAllAsync();
            return View(products);
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Products == null)
                return NotFound();

            var product = await productService.GetByIdAsync(id);
            if (product == null)
                return NotFound();

            return View(product);
        }

        public IActionResult Create() => View();


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Quantity,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                await productService.CreateProductAsync(product);
                
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Products == null)
                return NotFound();


            var product = await productService.GetByIdAsync(id);
            if (product == null)
                return NotFound();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Quantity,Price,TotalPrice,CreatedAt,UserId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await productService.UpdateProductAsync(id, product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                        return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            var product = await productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Product product)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Products'  is null.");
            }
            await productService.DeleteProductAsync(product);
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(Guid id)
        {
          return _context.Products.Any(e => e.Id == id);
        }
    }
}
