using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BBMIS.Models
{
    public class Share
    {
        [Key]
        public int ShareID { get; set; }
        public float TR { get; set; }
        public float DR { get; set; }
        public int Year { get; set; }
        public int DerivationID { get; set; }

        [ForeignKey("DerivationID")]
        public virtual Derivation Derivation {get;set;}
    }
}