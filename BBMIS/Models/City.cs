using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BBMIS.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string Name { get; set; }
        public int StateID { get; set; }
        [ForeignKey("StateID")]
        public virtual State State { get; set; }
    }
}