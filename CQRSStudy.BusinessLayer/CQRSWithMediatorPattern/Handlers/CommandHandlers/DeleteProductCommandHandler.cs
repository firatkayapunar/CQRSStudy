using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Commands.Product.Request;
using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Commands.Product.Response;

namespace CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest deleteProductCommandRequest)
        {
            var deleteProduct = _dbContext.Products.FirstOrDefault(p => p.Id == deleteProductCommandRequest.Id);

            _dbContext.Products.Remove(deleteProduct);
            _dbContext.SaveChangesAsync();

            return new DeleteProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
