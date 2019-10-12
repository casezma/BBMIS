using System.ComponentModel.DataAnnotations;

namespace BBMIS.Models
{
    public class CarBuild
    {
        [Key]
        public string Mnemonic_Bodystyle { get; set; }
        public string Mnemonic_Vehicle { get; set; }
        public string Brand { get; set; }
        public string Vehicle { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string ProductionPlant { get; set; }
        public string SalesParent { get; set; }
        public string Platform { get; set; }
        public string Program { get; set; }
        public string Bodystyle { get; set; }
        public string Bodytype { get; set; }
        public int SOP_Year { get; set; }
        public int SOP_Month { get; set; }
        public int EOP_Year { get; set; }
        public int EOP_Month { get; set; }



    }

}