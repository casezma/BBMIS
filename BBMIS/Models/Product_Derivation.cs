using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BBMIS.Models
{
    public class Product_Derivation
    {
        [Key]
        public int Product_DerivationID { get; set; }
        public int ProductID { get; set; }
        public int DerivationID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("DerivationID")]
        public virtual Derivation Derivation { get; set; }
        
       
    }
}