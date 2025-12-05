using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Application.DTOs.Products;
using RestaurantApp.Application.Interfaces.Services;

namespace RestaurantApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService; // Artık Repository yok, Service var!

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("specials")]
        public async Task<IActionResult> GetSpecials()
        {
            var result = await _productService.GetDailySpecialsAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto model)
        {
            await _productService.AddAsync(model);
            return Ok("Ürün başarıyla eklendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productService.GetByIdAsync(id);
            return Ok(result);
        }
    }
}