using CQRSStudy.BusinessLayer.CQRS.Queries.Request;
using CQRSStudy.BusinessLayer.CQRS.Queries.Response;

namespace CQRSStudy.BusinessLayer.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == getByIdProductQueryRequest.Id);
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreateTime = product.CreateTime
            };
        }
    }
}
