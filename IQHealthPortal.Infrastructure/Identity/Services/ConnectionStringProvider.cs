
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQHealthPortal.Infrastructure.Identity.Services

{ 
public class ConnectionStringProvider : IConnectionStringProvider
{
    private readonly IDictionary<string, string> _options;

    public ConnectionStringProvider(IOptions<ClientConnectionOptions> options)
    {
        _options = options.Value;
    }
    public string GetConnectionString(string clientId)
    {

        if (string.IsNullOrEmpty(clientId))
        {
            throw new ArgumentNullException(nameof(clientId), "Client ID cannot be null or empty.");
        }
        if (_options.ContainsKey(clientId))
        {

            // Log the connection string retrieval
            Console.WriteLine($"Retrieving connection string for client: {clientId}");
            // Optionally, you can log the connection string value, but be cautious with sensitive information
            Console.WriteLine($"Connection string: {_options[clientId]}"); // Uncomment to log the connection string value


            return _options[clientId];
        }
        throw new ArgumentException($"Connection string not found for client: {clientId}");
    }

    public string GetDefaultConnectionString()
    {
        return _options["2"];
    }

}
}
