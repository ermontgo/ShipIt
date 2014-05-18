using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
    public interface IDeploymentRepository
    {
        IQueryable<Deployment> GetDeploymentsForRelease(string release);

        IQueryable<Environment> GetEnvironments();
        IQueryable<Environment> GetEnvironment();
        void CreateEnvironment(Environment environment);
        void UpdateEnvironment(Environment environment);

        IQueryable<Server> GetServers(string environment);
        void AddServerToEnvironnment(string environment, Server server);
    }
}
