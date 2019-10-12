using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BBMIS.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public int Description { get; set; }
        public float Price { get; set; }
        public int Product_TypeID { get; set; }

        [ForeignKey("Product_TypeID")]
        public virtual Product_Type Product_Type {get;set;}
    }
}