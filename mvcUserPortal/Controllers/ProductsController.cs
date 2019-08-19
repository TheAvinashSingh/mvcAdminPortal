using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcUserPortal.Models;
using System.Data.Entity;
using System.Net;

namespace mvcUserPortal.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public SopraDbContext db = new SopraDbContext();
        public ActionResult Index()
        {
            var products = db.Products.ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            Product product = db.Products.Find(id);
            Brand brand = db.Brands.Find(product.BrandId);
            return View(product);
        }
    }
}