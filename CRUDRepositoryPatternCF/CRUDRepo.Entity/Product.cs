using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CRUDRepo.Entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public string Photo { get; set; }
        public virtual Category Category { get; set; }
        public virtual Brand Brands { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }

    }
}
