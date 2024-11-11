using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_INFRASTRUCTURE.Utility.Helpers
{
    public class AdoHelper : IDisposable
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        public AdoHelper(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SqlConnection(_connectionString);
        }

        public void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public T ExecuteQuery<T>(string query, Func<IDataReader, T> readFunc)
        {
            OpenConnection();
            try
            {
                using (var command = new SqlCommand(query, _connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return readFunc(reader);
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return default;
        }

        public List<T> ExecuteQueryList<T>(string query, Func<IDataReader, T> readFunc)
        {
            var results = new List<T>();
            OpenConnection();
            try
            {
                using (var command = new SqlCommand(query, _connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(readFunc(reader));
                        }
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return results;
        }

        public int ExecuteCommand(string commandText)
        {
            OpenConnection();
            try
            {
                using (var command = new SqlCommand(commandText, _connection))
                {
                    return command.ExecuteNonQuery(); 
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Dispose()
        {
            CloseConnection();
            _connection?.Dispose();
        }
    }
}
