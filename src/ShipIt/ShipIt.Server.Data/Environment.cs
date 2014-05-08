using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
	public class Environment
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTimeOffset CreatedDate { get; set; }

		public virtual ICollection<Server> Servers { get; set; } 
	}
}
