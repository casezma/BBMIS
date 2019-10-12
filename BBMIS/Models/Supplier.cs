using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBMIS.Models
{
	public class Supplier
	{
		[Key]
		public int SupplierID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Address { get; set; }
		public string Lat { get; set; }
		public string Long { get; set; }
		public int CityID { get; set; }

		[ForeignKey("CityID")]
		public virtual City City { get; set; }

	}
}