using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;
using AdoNet.Specification.Tests;

namespace Npgsql3.Tests
{
	public class Npgsql3SelectValueFixture : Npgsql3DbFactoryFixture, ISelectValueFixture, IDisposable
	{
		public Npgsql3SelectValueFixture() => PostgreSqlDatabase.CreateSelectValueTable(this);
		public void Dispose() => PostgreSqlDatabase.DropSelectValueTable(this);
		public string CreateSelectSql(DbType dbType, ValueKind kind) => PostgreSqlDatabase.CreateSelectSql(dbType, kind);
		public string CreateSelectSql(byte[] value) => PostgreSqlDatabase.CreateSelectSql(value);
		public string SelectNoRows => PostgreSqlDatabase.SelectNoRows;
		public IReadOnlyCollection<DbType> SupportedDbTypes => PostgreSqlDatabase.SupportedDbTypes;
		public Type NullValueExceptionType => PostgreSqlDatabase.NullValueExceptionType;
	}
}
