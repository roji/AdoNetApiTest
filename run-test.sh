#!/bin/bash

dotnet test tests/MicrosoftSqlite.Tests --filter $1
dotnet test tests/Sqlite.Tests --filter $1
dotnet test tests/MicrosoftSqlClient.Tests --filter $1
dotnet test tests/Npgsql4.Tests --filter $1
dotnet test tests/MySqlConnector.Tests --filter $1
