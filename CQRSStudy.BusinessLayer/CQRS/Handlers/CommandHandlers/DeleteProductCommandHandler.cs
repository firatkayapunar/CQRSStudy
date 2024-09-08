using CQRSStudy.BusinessLayer.CQRS.Commands.Product.Request;
using CQRSStudy.BusinessLayer.CQRS.Commands.Product.Response;

namespace CQRSStudy.BusinessLayer.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest deleteProductCommandRequest)
        {
            var deleteProduct = _dbContext.Products.FirstOrDefault(p => p.Id == deleteProductCommandRequest.Id);

            _dbContext.Products.Remove(deleteProduct);
            
            return new DeleteProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
