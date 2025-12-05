namespace RestaurantApp.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } // Örn: Ana Yemekler, Tatlılar
        public bool Status { get; set; } = true; // Kategori aktif mi?

        // Bir kategoride birden fazla ürün olabilir (One-to-Many)
        public ICollection<Product> Products { get; set; }
    }
}