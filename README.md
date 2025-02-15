<h1 align="center">CQRSStudy - CQRS - Mediator Kullanımı</h1>

<p align="center"> 
  Bu proje, <strong>CQRS</strong> (Command Query Responsibility Segregation) ve <strong>Mediator Pattern</strong>'ın 
  güçlü yönlerini içeren ders notlarımı kapsamaktadır.
</p>

---

<h2>🚀 Proje Özeti</h2>

<p>Bu proje, <strong>CQRS</strong> mimarisi ile <strong>Mediator Pattern</strong>'ın entegrasyonunu göstermektedir.</p>
<ul>
  <li>CQRS, Command ve Query işlemlerini ayırarak performansı ve yönetilebilirliği artırır.</li>
  <li>Mediator Pattern, bağımlılıkları azaltarak modüler ve sürdürülebilir bir yapı oluşturur.</li>
</ul>

---

<h2>📌 Özellikler</h2>

<ul> 
  <li><strong>CQRS Mimarisi</strong> ile Command ve Query işlemlerinin ayrıştırılması.</li>
  <li><strong>Mediator Pattern</strong> ile bağımsız ve Loose Coupling iş akışı yönetimi.</li> 
  <li><strong>Performans odaklı</strong> veri erişim stratejisi ile verimli sorgu yönetimi.</li> 
</ul>

---

<h2>📂 Proje Yapısı</h2>

<pre>
📁 CQRSStudy
│
├── 📁 CQRSStudy.BusinessLayer
│   ├── 📁 CQRS
│   │   ├── 📁 Commands
│   │   │   ├── 📁 Product
│   │   │   │   ├── 📁 Request
│   │   │   │   │   ├── CreateProductCommandRequest.cs
│   │   │   │   │   ├── DeleteProductCommandRequest.cs
│   │   │   │   ├── 📁 Response
│   │   │   │       ├── CreateProductCommandResponse.cs
│   │   │   │       ├── DeleteProductCommandResponse.cs
│   │   ├── 📁 Handlers
│   │   │   ├── 📁 CommandHandlers
│   │   │   │   ├── CreateProductCommandHandler.cs
│   │   │   │   ├── DeleteProductCommandHandler.cs
│   │   │   ├── 📁 QueryHandlers
│   │   │       ├── GetAllProductQueryHandler.cs
│   │   │       ├── GetByIdProductQueryHandler.cs
│   │   ├── 📁 Queries
│   │   │   ├── 📁 Request
│   │   │   │   ├── GetAllProductQueryRequest.cs
│   │   │   │   ├── GetByIdProductQueryRequest.cs
│   │   │   ├── 📁 Response
│   │   │       ├── GetAllProductQueryResponse.cs
│   │   │       ├── GetByIdProductQueryResponse.cs
│   │
│   ├── 📁 CQRSWithMediatorPattern
│   │   ├── 📁 Commands
│   │   │   ├── 📁 Product
│   │   │   │   ├── 📁 Request
│   │   │   │   │   ├── CreateProductCommandRequest.cs
│   │   │   │   │   ├── DeleteProductCommandRequest.cs
│   │   │   │   ├── 📁 Response
│   │   │   │       ├── CreateProductCommandResponse.cs
│   │   │   │       ├── DeleteProductCommandResponse.cs
│   │   ├── 📁 Handlers
│   │   │   ├── 📁 CommandHandlers
│   │   │   │   ├── CreateProductCommandHandler.cs
│   │   │   │   ├── DeleteProductCommandHandler.cs
│   │   │   ├── 📁 QueryHandlers
│   │   │       ├── GetAllProductQueryHandler.cs
│   │   │       ├── GetByIdProductQueryHandler.cs
│   │   ├── 📁 Queries
│   │   │   ├── 📁 Request
│   │   │   │   ├── GetAllProductQueryRequest.cs
│   │   │   │   ├── GetByIdProductQueryRequest.cs
│   │   │   ├── 📁 Response
│   │   │       ├── GetAllProductQueryResponse.cs
│   │   │       ├── GetByIdProductQueryResponse.cs
│   │
│   ├── 📁 Entities
│   │   ├── Product.cs
│   │
│   ├── 📁 Migrations
│   │   ├── 20240907141340_InitialCreate.cs
│   │   ├── ApplicationDbContextModelSnapshot.cs
│   │   ├── ApplicationDbContext.cs
│
├── 📁 CQRSStudy.Web
│   ├── 📁 Controllers
│   │   ├── ProductController.cs
│   ├── 📁 Properties
│   ├── Dependencies
│   ├── appsettings.json
│   ├── Program.cs
</pre>

---

<h2>🛠️ Kullanılan Teknolojiler ve Pattern'ler</h2>

<ul> 
  <li><strong>.NET 8</strong></li> 
  <li><strong>Entity Framework Core</strong></li> 
  <li><strong>MediatR (Mediator Pattern)</strong></li> 
  <li><strong>CQRS (Command Query Responsibility Segregation)</strong></li> 
  <li><strong>MSSQL</strong> (Veritabanı)</li> 
</ul>

---

<p> 
  <strong>Ek Notlar</strong>  <br>
  CQRS ve Mediator Pattern ile ilgili daha detaylı bilgiler için yazdığım yazıya göz atabilirsiniz: <br>
  📖 <a href="https://medium.com/@firatkayapunar/cqrs-ve-mediator-pattern-i%CC%87le-geli%C5%9Fmi%C5%9F-uygulama-mimarisi-b897fe397ff6" target="_blank">
CQRS ve Mediator Pattern ile Gelişmiş Uygulama Mimarisi
</a>
  <br>
  Bu yazıda, CQRS ve Mediator Pattern'in temel mantığını, avantajlarını ve uygulama örneklerini detaylı bir şekilde anlattım. 🚀
</p>
