using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public record ProductDto
    {
        public int ProductId { get; init; }
        [Required(ErrorMessage = "Product Name is required")]
        public string? ProductName { get; init; }
        [Required(ErrorMessage = "Price Name is required")]
        public decimal Price { get; init; }
        public int? CategoryId { get; init; }
       
    }
}
