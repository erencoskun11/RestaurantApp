using Microsoft.EntityFrameworkCore;
using RestaurantApp.Application.Interfaces.Repositories;
using RestaurantApp.Application.Interfaces.Services;
using RestaurantApp.Application.Mappings;
using RestaurantApp.Application.Services;
using RestaurantApp.Infrastructure.Persistence;
using RestaurantApp.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// ---------------------------------------------------------
// 1. Veritabaný Baðlantýsý (PostgreSQL)
// ---------------------------------------------------------
builder.Services.AddDbContext<RestaurantContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// ---------------------------------------------------------
// 2. Repository Tanýmlamalarý (DI Container)
// ---------------------------------------------------------
// Generic Repository
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
// Product Repository
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// ---------------------------------------------------------
// 3. Service Tanýmlamalarý
// ---------------------------------------------------------
builder.Services.AddScoped<IProductService, ProductService>();

// ---------------------------------------------------------
// 4. AutoMapper Tanýmlamasý
// ---------------------------------------------------------
builder.Services.AddAutoMapper(typeof(GeneralMapping));

// Repository
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// Service
builder.Services.AddScoped<ICategoryService, CategoryService>();
// ---------------------------------------------------------
// 5. Controller ve Swagger Ayarlarý
// ---------------------------------------------------------
builder.Services.AddControllers();

// .NET 9 ile gelen OpenAPI yerine klasik Swagger UI görmek için bunlarý ekliyoruz:
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ---------------------------------------------------------
// HTTP Request Pipeline
// ---------------------------------------------------------
if (app.Environment.IsDevelopment())
{
    // Swagger arayüzünü aktif ediyoruz
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();