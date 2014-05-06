using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
	public class Release
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual Process Process { get; set; }

		public virtual ICollection<Product> Products { get; set; }
		
		public virtual ICollection<Deployment> Deployments { get; set; } 
	}
}
