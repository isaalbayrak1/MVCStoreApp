using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManeger : IServiceManeger
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ServiceManeger(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;
    } 
}
