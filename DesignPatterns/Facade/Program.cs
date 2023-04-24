// See https://aka.ms/new-console-template for more information

using System.Data.SqlClient;
using Facade;

Console.WriteLine("Hello, World!");

Console.WriteLine("=== REPORTS WITHOUT HELPER FACADE ===");

SqlConnection connection;

// Generate reports without facade
connection = MySqlHelper.GetDBConnection("connectionString");
MySqlHelper.GenerateMySqlHTMLReport(connection, "sample-MySQL");
MySqlHelper.GenerateMySqlPDFReport(connection, "sample-MySQL");

connection = MSSqlHelper.GetDBConnection("connectionString");
MSSqlHelper.GenerateMSSqlHTMLReport(connection, "sample-MSSql");
MSSqlHelper.GenerateMSSqlPDFReport(connection, "sample-MSSql");

connection = MongoDBHelper.GetDBConnection("connectionString");
MongoDBHelper.GenerateMongoHTMLReport(connection, "sample-Mongo");
MongoDBHelper.GenerateMongoPDFReport(connection, "sample-Mongo");

Console.WriteLine("\n=== REPORTS WITH HELPER FACADE ===\n");

// Generate reports with facade
HelperFacade.GenerateReport(HelperFacade.DBConnector.MYSQL, HelperFacade.ReportType.HTML, "sample-MySQL");
HelperFacade.GenerateReport(HelperFacade.DBConnector.MONGO, HelperFacade.ReportType.PDF, "sample-Mongo");