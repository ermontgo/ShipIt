using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
    public interface IDeploymentContext
    {
        IDbSet<Product> Products { get; set; }

        IDbSet<Process> Processes { get; set; }

        IDbSet<Release> Releases { get; set; }

        IDbSet<Environment> Environments { get; set; }
    }
}
