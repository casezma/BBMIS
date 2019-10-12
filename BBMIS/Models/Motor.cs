using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BBMIS.Models
{
    public class Motor
    {
        [Key]
        public int MotorID { get; set; }
        public string Name { get; set; }
    }
}