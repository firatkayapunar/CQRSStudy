using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Queries.Request;
using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Queries.Response;
using MediatR;

namespace CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
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
