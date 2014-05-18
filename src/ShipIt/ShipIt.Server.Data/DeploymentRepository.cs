using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipIt.Server.Data
{
    public class DeploymentRepository : IDeploymentRepository
    {
        private IDeploymentContext _context;

        public DeploymentRepository(IDeploymentContext context)
        {
            _context = context;
        }

        public IQueryable<Deployment> GetDeploymentsForRelease(string release)
        {
            return _context.Releases.Where(r => r.Name == release).First().Deployments.AsQueryable();
        }

        public IQueryable<Environment> GetEnvironments()
        {
            return _context.Environments.AsQueryable();
        }

        public IQueryable<Environment> GetEnvironment()
        {
            throw new NotImplementedException();
        }

        public void CreateEnvironment(Environment environment)
        {
            throw new NotImplementedException();
        }

        public void UpdateEnvironment(Environment environment)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Server> GetServers(string environment)
        {
            throw new NotImplementedException();
        }

        public void AddServerToEnvironnment(string environment, Server server)
        {
            throw new NotImplementedException();
        }
    }
}
