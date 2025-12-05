using AutoMapper;
using RestaurantApp.Domain.Entities;

// Ürün DTO'larının olduğu namespace
using RestaurantApp.Application.DTOs.Products;

// Kategori DTO'larının olduğu namespace
using RestaurantApp.Application.DTOs.Categories;

namespace RestaurantApp.Application.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            // ----------------------------------------------------------------
            // PRODUCT MAPPINGS (Ürün Dönüşümleri)
            // ----------------------------------------------------------------

            // Listeleme: Product -> ResultProductDto (CategoryName eşleştirmesiyle)
            CreateMap<Product, ResultProductDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ReverseMap();

            // ID'ye Göre Getirme: Product -> GetProductByIdDto
            CreateMap<Product, GetProductByIdDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ReverseMap();

            // Ekleme: CreateProductDto -> Product
            CreateMap<CreateProductDto, Product>().ReverseMap();

            // Güncelleme: UpdateProductDto -> Product
            CreateMap<UpdateProductDto, Product>().ReverseMap();


            // ----------------------------------------------------------------
            // CATEGORY MAPPINGS (Kategori Dönüşümleri)
            // ----------------------------------------------------------------

            // Listeleme
            CreateMap<Category, ResultCategoryDto>().ReverseMap();

            // ID'ye Göre Getirme
            CreateMap<Category, GetCategoryByIdDto>().ReverseMap();

            // Ekleme
            CreateMap<CreateCategoryDto, Category>().ReverseMap();

            // Güncelleme
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();
        }
    }
}