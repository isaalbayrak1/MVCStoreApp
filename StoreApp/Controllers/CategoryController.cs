using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace StoreApp.Controllers
{
    public class CategoryController : Controller
    {
        private IRepositoryManeger _manager;

        public CategoryController(IRepositoryManeger manager)
        {
            _manager = manager;
        }
        public IActionResult Index()
        {
            var model= _manager.Category.FindAll(false);
            return View(model);
        }
    }
}
