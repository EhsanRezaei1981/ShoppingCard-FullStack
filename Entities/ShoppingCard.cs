namespace Entities;

public class ShoppingCard{
    public int Id { get; set; }
    public DateTime DateTimeUtc { get; set; }
    public decimal TotalAmount { get; set; }
    public required Entities.User User { get; set; }
    public required ICollection<Entities.ShoppingCardDetail> ShoppingCardDetails { get; set; }
}
