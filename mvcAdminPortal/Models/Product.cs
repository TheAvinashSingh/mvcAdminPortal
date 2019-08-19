using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace mvcAdminPortal.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ProductAddedDate { get; set; }

        [Required]
        public float ProductPrice { get; set; }

        [Required]
        [MinLength(5), MaxLength(100)]
        public string ProductDescription { get; set; }

        [Required]
        public string ProductImage { get; set; }

        // Foreign Key Column
        public int BrandId { get; set; }

        // Foreign Key Column
        public int CategoryId { get; set; }

        // Navigation Property
        public Category Category { get; set; }

        public Brand Brand { get; set; }
    }
}