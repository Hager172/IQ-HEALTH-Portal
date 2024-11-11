using ACMS_ONLINE_INFRASTRUCTURE.Data.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Services
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        private readonly ClientConnectionOptions _options;
       
        public ConnectionStringProvider(IOptions<ClientConnectionOptions> options)
        {
            _options = options.Value;
        }

        public string GetConnectionString(string clientId)
        {
            if (_options.ClientConnections.ContainsKey(clientId))
            {
                return _options.ClientConnections[clientId];
            }
            throw new ArgumentException($"Connection string not found for client: {clientId}");
        }

        public string GetDefaultConnectionString()
        {
            return _options.ClientConnections["2"];
        }
    }
}
