using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcShoppingCartWithSession.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Photo { get; set; }

    }
}