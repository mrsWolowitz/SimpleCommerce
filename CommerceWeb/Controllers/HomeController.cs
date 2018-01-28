﻿using CommerceDomain;
using CommerceWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommerceWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository repository;
        public HomeController(ProductRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }
            this.repository = repository;
        }
        public ActionResult Index()
        {
            var productService = new ProductService(this.repository);

            var vm = new FeaturedProductsViewModel();

            var products = productService.GetFeaturedProducts(this.User);
            foreach (var product in products)
            {
                var productVM = new ProductViewModel(product);
                vm.Products.Add(productVM);
            }
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}