using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace ShipIt.Server.Data
{
	public class Deployment
	{
		public int Id { get; set; }
		public Product Product { get; set; }

		public DateTimeOffset StartedDate { get; set; }
		public DateTimeOffset CompletedDate { get; set; }

		public virtual ICollection<DeploymentLogEntry> DeploymentLogEntries { get; set; }
	}
}
