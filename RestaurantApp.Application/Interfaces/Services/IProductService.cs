using RestaurantApp.Application.DTOs.Products;

namespace RestaurantApp.Application.Interfaces.Services
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllAsync();
        Task<List<ResultProductDto>> GetDailySpecialsAsync();
        Task<GetProductByIdDto> GetByIdAsync(int id);
        Task AddAsync(CreateProductDto createProductDto);
        Task UpdateAsync(UpdateProductDto updateProductDto);
        Task DeleteAsync(int id);
    }
}