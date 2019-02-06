using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.IO;

namespace Blog.Providers
{
    public class ConnectionFactory
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables();

                IConfiguration configuration = builder.Build();
                string stringConexao = configuration.GetConnectionString("Blog");
                SqlConnection conexao = new SqlConnection(stringConexao);

                conexao.Open();

                return conexao;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
