using RestaurantApp.Domain.Entities;
using System.Linq.Expressions;

namespace RestaurantApp.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}