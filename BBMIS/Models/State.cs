using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BBMIS.Models
{
    public class State
    {
        [Key]
        public int StateID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }

        [ForeignKey("CountryID")]
       public virtual Country Country { get; set; }
    }
}