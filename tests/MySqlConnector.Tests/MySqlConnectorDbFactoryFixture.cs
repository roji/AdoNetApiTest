using System.Data.Common;
using AdoNet.Specification.Tests;
using MySql.Data.MySqlClient;

namespace MySqlConnector.Tests
{
	public class MySqlConnectorDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => MySqlClientFactory.Instance;
		public string ConnectionString => "Server=localhost;User Id=roji;Password=Abcd5678;SSL Mode=none;Database=mysqlconnector";
	}
}
