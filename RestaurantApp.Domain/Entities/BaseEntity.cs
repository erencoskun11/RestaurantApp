namespace RestaurantApp.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // Kayıt tarihi otomatik atansın
    }
}