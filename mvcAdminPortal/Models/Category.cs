using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace mvcAdminPortal.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CategoryAddedDate { get; set; }

        //Navigation Property

        public List<Product> Products { get; set; }
    }
}