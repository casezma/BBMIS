using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BBMIS.Models
{
    public class Derivation
    {
        [Key]
        public int DerivationID { get; set; }
        public string Description { get; set; }
        public int MotorID { get; set; }
        public int FuelID { get; set; }
        public string Mnemonic_Bodystyle { get; set; }
  

        [ForeignKey("MotorID")]
        public virtual Motor Motor { get; set; }
        [ForeignKey("FuelID")]
        public virtual Fuel Fuel { get; set; }
        [ForeignKey("Mnemonic_Bodystyle")]
        public virtual CarBuild CarBuild { get; set; }
        
    }
}