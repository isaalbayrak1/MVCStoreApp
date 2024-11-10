using Entities.Models;

namespace Repositories.Extansions
{
    public static class ProductRepositoryExtensions
    {
        public static IQueryable<Product> FilteredByCategoryId(this IQueryable<Product> products,
            int? categoryId)
        {
            if (categoryId is null)
                return products;
            else
                return products.Where(prd => prd.CategoryId.Equals(categoryId));
        }
        public static IQueryable<Product> FilteredBySearchTerm(this IQueryable<Product> products,
            String? searchterm)
        {
            if (string.IsNullOrWhiteSpace(searchterm))
                return products;
            else
                return products.Where(prd => prd.ProductName.ToLower()
                .Contains(searchterm.ToLower()));
        }

        public static IQueryable<Product> FilteredByPrice(this IQueryable<Product> products,
            int MinPrice, int MaxPrice, bool isValidPrice)
        {
            if (isValidPrice)
                return products.Where(prd => prd.Price >= MinPrice && prd.Price <= MaxPrice);
            else
                return products;
        }
        public static IQueryable<Product> ToPaginate(this IQueryable<Product> products,
           int pageNumber, int pageSize)
        {
            return products
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
        }

    }
}
