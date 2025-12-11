using Microsoft.EntityFrameworkCore;
using RestaurantApp.Application.Interfaces.Repositories;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Infrastructure.Persistence;

namespace RestaurantApp.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly RestaurantContext _context;

        public ProductRepository(RestaurantContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetDailySpecialsAsync()
        {
            // Category'i Include ediyoruz ki frontend'de kategori adı boş gelmesin
            return await _context.Products
                .Include(p => p.Category)
                .Where(p => p.IsDailySpecial == true && p.ProductStatus == true)
                .ToListAsync();
        }
    }
}