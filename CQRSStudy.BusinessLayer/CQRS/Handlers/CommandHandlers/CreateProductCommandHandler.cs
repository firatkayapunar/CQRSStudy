using CQRSStudy.BusinessLayer.CQRS.Commands.Product.Request;
using CQRSStudy.BusinessLayer.CQRS.Commands.Product.Response;

namespace CQRSStudy.BusinessLayer.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest createProductCommandRequest)
        {
            var id = Guid.NewGuid();

            _dbContext.Products.Add(new()
            {
                Id = id,
                Name = createProductCommandRequest.Name,
                Price = createProductCommandRequest.Price,
                Quantity = createProductCommandRequest.Quantity,
                CreateTime = DateTime.Now
            });

            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = id
            };
        }
    }
}
