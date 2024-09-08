using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Queries.Response;
using MediatR;

namespace CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Queries.Request
{
    //IRequest, command yahut query requestlerini karşılayacak olan sınıflar tarafından implemente edilecek olan bir arayüzdür. Generic olarak bu request karşılığında hangi nesnenin döndürüleceğini bildirmemizi ister.	
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
