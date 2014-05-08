using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
	public class DeploymentLogEntry
	{
		public int Id { get; set; }
		public DateTimeOffset ServerTime { get; set; }
		public Deployment Deployment { get; set; }
		public Package Package { get; set; }
		public Step Step { get; set; }
		public string Message { get; set; }
	}
}
