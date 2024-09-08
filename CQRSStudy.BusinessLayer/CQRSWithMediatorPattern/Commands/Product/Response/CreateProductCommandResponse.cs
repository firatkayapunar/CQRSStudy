namespace CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Commands.Product.Response
{
    public class CreateProductCommandResponse
    {
        public bool IsSuccess { get; set; }
        public Guid ProductId { get; set; }
    }
}
