﻿using Exercise2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise2.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerRepository repo;

        public CustomersController(ICustomerRepository repository)
        {
            this.repo = repository;
        }

        // GET: Customers
        public ActionResult Index()
        {
            return View(this.repo.GetCustomers());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            return View(this.repo.GetCustomerById(id));
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }
        /*
        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        */
    }
}
