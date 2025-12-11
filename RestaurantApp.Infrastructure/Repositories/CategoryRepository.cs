using RestaurantApp.Application.Interfaces.Repositories;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Infrastructure.Persistence;

namespace RestaurantApp.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(RestaurantContext context) : base(context)
        {
        }
    }
}