using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemCatalogController : ControllerBase
{
    private static readonly Product[] _products = new[]
    {
        new Product { Name = "Basic Black T-Shirt", ArrivedAt = new DateTime(2020, 7, 20), Description = "Some text about how cool the T-shirt is", Manufacturer = "China", Price = 348.8M, Size = 23 },
        new Product { Name = "Rainbow T-Shirt", ArrivedAt = new DateTime(2019, 7, 21), Description = "Some text about how cool the rainbow T-shirt is", Manufacturer = "Ukraine", Price = 337.9M, Size = 24 },
        new Product { Name = "Blue Jeans", ArrivedAt = new DateTime(2021, 7, 22), Description = "Some text about how cool the jeans is", Manufacturer = "UK", Price = 1098.3M, Size = 50 },
        new Product { Name = "Red Sticker Snake Logo", ArrivedAt = new DateTime(2020, 7, 23), Description = "Some text about how cool the sticker is", Manufacturer = "China", Price = 25 },
        new Product { Name = "Cup Snake Logo", ArrivedAt = new DateTime(2017, 7, 24), Description = "Some text about how cool the cup is", Manufacturer = "Germany", Price = 100 }
    };

    private readonly ILogger<ItemCatalogController> _logger;

    public ItemCatalogController(ILogger<ItemCatalogController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetItemCatalog")]
    public Product[] Get()
    {
        return _products;
    }
}