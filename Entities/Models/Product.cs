using System.ComponentModel.DataAnnotations;

namespace Entities.Models;
public class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage ="Product Name is required")]
    public string? ProductName { get; set; }
    [Required(ErrorMessage = "Price Name is required")]
    public decimal Price { get; set; }

}