using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Web;

namespace BBMIS.Models
{

    public class CarBuildVolumes 
    {
        [Key]
        public string CarBuildVolumesID { get; set; }

        public string CarBuildID { get; set; }

        public int Year { get; set; }

        public float Volume { get; set; }

        [ForeignKey("CarBuildID")]
        public virtual CarBuild CarBuild { get; set; }

    }
}