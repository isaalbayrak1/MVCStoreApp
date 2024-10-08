﻿using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        public IEnumerable<Product> Index()
        {
            return new List<Product>()
            {
                new Product() { ProductId = 1, ProductName = "Computer", Price = 5 }
            };
        }
    }
}
