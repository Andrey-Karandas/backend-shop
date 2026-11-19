using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return _context.Products.Select(p => new Product
        {
            Id = p.Id,
            Name = p.Name,
            Price = p.Price,
            UnitInStock = p.UnitInStock,
            ImageUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}{p.ImageUrl}",
            Discount = p.Discount
        }).ToList();
    }

}

