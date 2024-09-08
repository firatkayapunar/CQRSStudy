using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Commands.Product.Response;
using MediatR;

namespace CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Commands.Product.Request
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
