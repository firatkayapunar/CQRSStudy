using CQRSStudy.BusinessLayer;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region BeforeMediatorPattern
//builder.Services.AddTransient<CreateProductCommandHandler>();
//builder.Services.AddTransient<DeleteProductCommandHandler>();
//builder.Services.AddTransient<GetAllProductQueryHandler>();
//builder.Services.AddTransient<GetByIdProductQueryHandler>();
#endregion

// Bu ifade MediatR'a, ApplicationDbContext sýnýfýnýn bulunduðu assembly'deki tüm IRequestHandler implementasyonlarýný tarayýp DI container'a kaydetmesini söyler. Örneðin, CreateProductCommandHandler, IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse> interface'ini implement ettiði için, bu iþleyici DI container'a kaydedilir. Ayrýca IMediator arayüzü içinde bir sýnýf belirtir.
builder.Services.AddMediatR(typeof(ApplicationDbContext));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
