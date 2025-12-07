namespace RestaurantApp.Application.DTOs.Products
{
    public class GetProductByIdDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; } // Güncelleme ekranında ID lazım olabilir
        public string CategoryName { get; set; }
        public bool IsDailySpecial { get; set; }
        public bool IsChefSuggestion { get; set; }
    }
}