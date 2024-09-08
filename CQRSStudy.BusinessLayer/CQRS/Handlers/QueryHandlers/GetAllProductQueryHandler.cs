using CQRSStudy.BusinessLayer.CQRS.Queries.Request;
using CQRSStudy.BusinessLayer.CQRS.Queries.Response;

namespace CQRSStudy.BusinessLayer.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest getAllProductQueryRequest)
        {
            return _dbContext.Products.Select(product => new GetAllProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreateTime = product.CreateTime
            }).ToList();
        }
    }
}
