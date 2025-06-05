using Dapper;
using Microsoft.Data.Sqlite;

namespace DapperRelations;

public class Program
{
    public static void Main(string[] args)
    {
        using var connection = new SqliteConnection("Data Source=library.db");
        connection.Open();

        CreateDatabase(connection);

    }

    private static void CreateDatabase(SqliteConnection connection)
    {
        var createTableQuery = @"
        CREATE TABLE IF NOT EXISTS Authors (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Name TEXT NOT NULL,
            DateOfBirth TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS Books (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Title TEXT NOT NULL,
            AuthorId INTEGER NOT NULL,
            FOREIGN KEY (AuthorId) REFERENCES Authors(Id)
        );

        CREATE TABLE IF NOT EXISTS Visitors (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Name TEXT NOT NULL,
            PhoneNumber TEXT NOT NULL,
            DateOfBirth TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS Passports (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            PassportNumber TEXT NOT NULL,
            VisitorId INTEGER NOT NULL UNIQUE,
            FOREIGN KEY (VisitorId) REFERENCES Visitors(Id)
        );
    ";

        connection.Execute(createTableQuery);
    }

}