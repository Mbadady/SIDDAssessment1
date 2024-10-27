namespace SDD.Services.ProductAPI.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
    }
}
