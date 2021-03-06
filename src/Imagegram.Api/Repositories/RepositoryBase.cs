using System.Data;
using Imagegram.Api.Services;

namespace Imagegram.Api.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string connectionString;
        private readonly IDbConnectionFactory connectionFactory;

        public RepositoryBase(string connectionString, IDbConnectionFactory connectionFactory)
        {
            this.connectionString = connectionString;
            this.connectionFactory = connectionFactory;
        }

        protected IDbConnection OpenConnection()
        {
            var connection = connectionFactory.Create(connectionString);
            connection.Open();
            return connection;
        }
    }
}