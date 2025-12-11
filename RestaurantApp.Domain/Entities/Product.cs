namespace RestaurantApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; } // İçindekiler vs.
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } // Resim yolunu tutacağız
        public bool ProductStatus { get; set; } = true; // Yemek bittiyse false yaparız

        // ÖZEL ALANLAR
        public bool IsDailySpecial { get; set; } // Günün Çorbası/Yemeği mi?
        public bool IsChefSuggestion { get; set; } // Şefin Önerisi mi?

        // İLİŞKİLER
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}