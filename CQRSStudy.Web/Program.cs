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

//Bu ifade MediatR'a, ApplicationDbContext s�n�f�n�n bulundu�u assembly'deki t�m IRequestHandler implementasyonlar�n� taray�p DI container'a kaydetmesini s�yler. �rne�in, CreateProductCommandHandler, IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse> interface'ini implement etti�i i�in, bu i�leyici DI container'a kaydedilir. Ayr�ca IMediator aray�z� i�inde bir s�n�f belirtir.
builder.Services.AddMediatR(typeof(ApplicationDbContext));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
