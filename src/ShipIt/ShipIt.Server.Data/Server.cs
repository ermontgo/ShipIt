using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
	public class Server
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }
		public string Description { get; set; }
		public DateTimeOffset CreatedDate { get; set; }

		public virtual Environment Environment { get; set; }
		public virtual Collection<Package> Packages { get; set; } 
	}
}
