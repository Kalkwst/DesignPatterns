using System.Data.SqlClient;

namespace Facade;

public class MSSqlHelper
{
    public static SqlConnection GetDBConnection(string connectionString)
    {
        // Generate a MSSql db connection using connection parameters
        Console.WriteLine("Successfully created a MSSql database connection.");
        return new SqlConnection();
    }

    public static void GenerateMSSqlPDFReport(SqlConnection connection, string tableName)
    {
        // Get data from the table and generate a pdf report
        Console.WriteLine($"Successfully generated a pdf report with the contents of {tableName}");
    }

    public static void GenerateMSSqlHTMLReport(SqlConnection connection, string tableName)
    {
        // Get data from the table and generate an html report
        Console.WriteLine($"Successfully generated a report with the contents of {tableName} and exported them to HTML");
    }
}