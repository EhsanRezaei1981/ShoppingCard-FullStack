using System.ComponentModel.DataAnnotations;

namespace Dtos.Models;

public class SaleItem
{
    public int Id { get; set; }
    [Required]
    public required string Name { get; set; }
    [Required]
    public decimal Price { get; set; }
    public string? Description { get; set; }
}