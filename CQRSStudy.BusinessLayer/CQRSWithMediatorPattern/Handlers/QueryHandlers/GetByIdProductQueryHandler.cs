using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Queries.Request;
using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Queries.Response;
using MediatR;

namespace CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == request.Id);
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
