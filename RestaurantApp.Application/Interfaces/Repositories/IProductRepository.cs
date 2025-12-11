using RestaurantApp.Domain.Entities;

namespace RestaurantApp.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetDailySpecialsAsync();
    }
}