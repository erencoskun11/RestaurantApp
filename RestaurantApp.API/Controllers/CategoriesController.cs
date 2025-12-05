using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Application.DTOs.Categories;
using RestaurantApp.Application.Interfaces;
using RestaurantApp.Application.Interfaces.Services;

namespace RestaurantApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _categoryService.GetAllAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _categoryService.GetByIdAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.AddAsync(createCategoryDto);
            return Ok("Kategori başarıyla eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryDto updateCategoryDto)
        {
            await _categoryService.UpdateAsync(updateCategoryDto);
            return Ok("Kategori başarıyla güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.DeleteAsync(id);
            return Ok("Kategori silindi");
        }
    }
}