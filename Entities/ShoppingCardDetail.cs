namespace Entities;

public class ShoppingCardDetail{
    public int Id { get; set; }
    public int ShoppingCardId { get; set; }
    public int SaleItemId { get; set; }
    public int Count { get; set; }
    public decimal Fee { get; set; }
    public decimal TotalAmount { get; set; }
    public required Entities.SaleItem SaleItem { get; set; }
}