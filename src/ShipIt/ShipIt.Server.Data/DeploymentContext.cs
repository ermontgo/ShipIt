using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
    public class DeploymentContext : IDeploymentContext
    {

        public System.Data.Entity.IDbSet<Product> Products { get; set; }
        public System.Data.Entity.IDbSet<Process> Processes { get; set; }
        public System.Data.Entity.IDbSet<Release> Releases { get; set; }
        public System.Data.Entity.IDbSet<Environment> Environments { get; set; }
    }
}
