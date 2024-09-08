namespace CQRSStudy.BusinessLayer.CQRS.Commands.Product.Response
{
    public class CreateProductCommandResponse
    {
        public bool IsSuccess { get; set; }
        public Guid ProductId { get; set; }
    }
}
