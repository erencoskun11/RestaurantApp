namespace RestaurantApp.Application.DTOs.Categories
{
    public class CreateCategoryDto
    {
        public string Name { get; set; }
        public bool Status { get; set; } = true;
    }
}