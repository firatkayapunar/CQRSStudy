using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Commands.Product.Response;
using MediatR;

namespace CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Commands.Product.Request
{
    // IRequest, command yahut query requestlerini karşılayacak olan sınıflar tarafından implemente edilecek olan bir arayüzdür. Generic olarak bu request karşılığında hangi nesnenin döndürüleceğini bildirmemizi ister.	
    // Not : IRequest<TResponse>, MediatR mekanizmasının hangi handler'ı bulacağını sağlar. Yani, MediatR'a bir istek gönderildiğinde, bu isteği hangi handler'ın işlemesi gerektiğini istek türüne ve dönecek yanıt türüne göre belirler. İşte bu belirleme sürecinde IRequest<TResponse> çok kritik bir rol oynar. Mediator şunu arayacaktır. => : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>. Eğer bunu implement etmeseydik hata alacaktık.
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
