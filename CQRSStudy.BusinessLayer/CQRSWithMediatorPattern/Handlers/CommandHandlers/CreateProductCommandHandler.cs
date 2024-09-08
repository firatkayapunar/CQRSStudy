using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Commands.Product.Request;
using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Commands.Product.Response;
using MediatR;

namespace CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Handlers.CommandHandlers
{
    //IRequestHandler ise command yahut query requestlerinin işlenmesini sağlayacak olan Handler sınıflarının arayüzüdür.Generic olarak request ve response sınıflarının bildirilmesini ister ve ilgili sınıfa içerisindeki ‘Handle’ isimli fonksiyonu implemente ettirir.

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            _dbContext.Products.Add(new()
            {
                Id = id,
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity,
                CreateTime = DateTime.Now
            });
            _dbContext.SaveChangesAsync();
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = id
            };
        }
    }
}
