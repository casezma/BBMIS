using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BBMIS.Models
{
    public class Derivation_Supplier
    {
        [Key]
        public int Derivation_SupplierID { get; set; }
        public int SupplierID { get; set; }
        public int DerivationID { get; set; }

        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }
        [ForeignKey("DerivationID")]
        public virtual Derivation Derivation { get; set; }

    }
}