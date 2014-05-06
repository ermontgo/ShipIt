using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
	public class Process
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Environment> Environments { get; set; }
		public virtual ICollection<Release> Releases { get; set; } 
	}
}
