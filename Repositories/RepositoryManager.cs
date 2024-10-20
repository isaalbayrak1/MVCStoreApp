using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RepositoryManager(IProductRepository productRepository, RepositoryContext context, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _context = context;
            _categoryRepository = categoryRepository;
        }
        public IProductRepository Product
        {
            get => _productRepository;
            set => throw new NotImplementedException("Setting Product is not implemented.");
        }
        public ICategoryRepository Category
        {
            get => _categoryRepository;
            set => throw new NotImplementedException("Setting Category is not implemented.");
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
