using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcShoppingCartWithSession.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            this.products = new List<Product>()
            {
                new Product
                {
                    Id = "p01",
                    Name = "Name 1",
                    Price = 5,
                    Photo = "https://images-na.ssl-images-amazon.com/images/I/81HKsh9XaRL._SL1468_.jpg"
                },

                new Product
                {
                    Id = "p02",
                    Name = "Name 2",
                    Price = 15,
                    Photo = "https://images-na.ssl-images-amazon.com/images/I/81Ak%2BHucfnL._SL1500_.jpg"
                },

                new Product
                {
                    Id = "p03",
                    Name = "Name 3",
                    Price = 7,
                    Photo = "https://images-na.ssl-images-amazon.com/images/I/81cl502ta1L._SL1500_.jpg"
                }

            };
        }

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(string id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }
    }
}