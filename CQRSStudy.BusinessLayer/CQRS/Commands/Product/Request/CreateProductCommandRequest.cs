namespace CQRSStudy.BusinessLayer.CQRS.Commands.Product.Request
{
    public class CreateProductCommandRequest
    {
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
