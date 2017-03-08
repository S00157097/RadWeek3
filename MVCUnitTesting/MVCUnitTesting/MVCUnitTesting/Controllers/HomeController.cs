﻿using MVCUnitTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUnitTesting.Controllers
{
    public class HomeController : Controller
    {
        private Repository repository;

        public HomeController(Repository repository)
        {
            this.repository = repository;
        }

        public HomeController()
        {
            this.repository = new WorkingProductRepository();
        }

        public ViewResult Index()
        {
            var products = repository.GetAll();
            return View(products);
        }

        public ViewResult GetProductsByGenre(string id)
        {
            IEnumerable<Product> products;

            if (String.IsNullOrEmpty(id))
            {
                products = repository.GetAll();
            }
            else
            {
                products = repository
                    .GetAll()
                    .Where(product => product.Genre.StartsWith(id));
            }

            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}