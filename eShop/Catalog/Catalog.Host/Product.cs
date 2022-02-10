namespace Catalog.Host
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; } = default!;

        public DateTime ArrivedAt { get; set; } = default!;

        public string Manufacturer { get; set; } = string.Empty;

        public double? Size { get; set; }
    }
}
