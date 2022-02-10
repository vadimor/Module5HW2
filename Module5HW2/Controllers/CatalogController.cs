using Microsoft.AspNetCore.Mvc;

namespace Module5HW2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly Product[] _products = new[] {
            new Product { Name = "Book", Price = 20, Currency = Currency.Usd },
            new Product { Name = "Car", Price = 50000, Currency = Currency.Usd },
            new Product { Name = "Xbox", Price = 500, Currency = Currency.Usd },
            new Product { Name = "Locker", Price = 50, Currency = Currency.Usd }
        };

        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ILogger<CatalogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}