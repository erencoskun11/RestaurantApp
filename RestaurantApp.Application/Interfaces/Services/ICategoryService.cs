using RestaurantApp.Application.DTOs.Categories;

namespace RestaurantApp.Application.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllAsync();
        Task<GetCategoryByIdDto> GetByIdAsync(int id);
        Task AddAsync(CreateCategoryDto createCategoryDto);
        Task UpdateAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteAsync(int id);
    }
}