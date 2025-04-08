﻿using BestStoreMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestStoreMVC.Controllers
{
    //Access Modifier 
    //class is a container used to store properites and method
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(p=>p.Id).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
