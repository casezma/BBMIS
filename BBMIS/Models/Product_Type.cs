using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BBMIS.Models
{
    public class Product_Type
    {
        [Key]
        public int Product_TypeID { get; set; }
        public string Name { get; set; }
        
    }
}