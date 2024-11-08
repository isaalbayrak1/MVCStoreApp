using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/images/Fotoğraf.jpeg", ProductName = "Computer", Price = 17_000, ShowCase = false },
                new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/images/Fotoğraf.jpeg", ProductName = "Keyboard", Price = 1_000, ShowCase = false },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/Fotoğraf.jpeg", ProductName = "Mouse", Price = 500, ShowCase = false },
                new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/images/Fotoğraf.jpeg", ProductName = "Monitor", Price = 7_000, ShowCase = false },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/Fotoğraf.jpeg", ProductName = "Deck", Price = 1_500, ShowCase = false },
                new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/images/Fotoğraf.jpeg", ProductName = "History", Price = 25, ShowCase = false },
                new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/images/Fotoğraf.jpeg", ProductName = "Hamlet", Price = 1_500, ShowCase = false },
                new Product() { ProductId = 8, CategoryId = 1, ImageUrl = "/images/Fotoğraf.jpeg", ProductName = "Xp-Pen", Price = 1_500, ShowCase = true },
                new Product() { ProductId = 9, CategoryId = 2, ImageUrl = "/images/Fotoğraf.jpeg", ProductName = "Samsung", Price = 1_500, ShowCase = true },
                new Product() { ProductId = 10, CategoryId = 2, ImageUrl = "/images/Fotoğraf.jpeg", ProductName = "HP Mouse", Price = 1_500, ShowCase = true }
            );
        }
    }
}
