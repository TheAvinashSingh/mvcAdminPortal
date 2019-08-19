using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcUserPortal.Models;
using System.Data.Entity;
namespace mvcUserPortal.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public SopraDbContext db = new SopraDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buy(int id)
        {
            Product product = db.Products.Find(id);
            if(Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = product, Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {

                    cart.Add(new Item { Product = product, Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index");
        }
        private int isExist(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        
        public ActionResult Increment(int id)
        {
            Product product = db.Products.Find(id);
            if (Session["cart"] == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }

            }
            return RedirectToAction("Index");
        }

        public ActionResult Decrement(int id)
        {
            Product product = db.Products.Find(id);
            if (Session["cart"] == null)
            {
                return RedirectToAction("Index");
            }

            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    if (cart[index].Quantity == 1)
                    {
                        cart.RemoveAt(index);
                    }
                    else
                    {
                        cart[index].Quantity--;
                    }

                }
                else
                {
                    cart.RemoveAt(index);
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }
    }
}