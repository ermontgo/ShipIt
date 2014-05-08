using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
	public class Package
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Source { get; set; }
		public string Description { get; set; }
		public string ProviderClassName { get; set; }
		public DateTimeOffset CreatedDate { get; set; }

		public virtual ICollection<Server> Servers { get; set; }
		public virtual Product Product { get; set; }
	}
}
