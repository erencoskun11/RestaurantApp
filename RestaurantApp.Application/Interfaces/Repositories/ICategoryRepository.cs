using RestaurantApp.Domain.Entities;

namespace RestaurantApp.Application.Interfaces.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        // Kategoriye özel ekstra bir metod gerekirse buraya yazarız.
        // Şimdilik Generic yapı yeterli.
    }
}