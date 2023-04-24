using System.Data.SqlClient;

namespace Facade;

public class MySqlHelper
{
    public static SqlConnection GetDBConnection(string connectionString)
    {
        // Generate a mysql db connection using connection parameters
        Console.WriteLine("Successfully created a MySQL database connection.");
        return new SqlConnection();
    }

    public static void GenerateMySqlPDFReport(SqlConnection connection, string tableName)
    {
        // Get data from the table and generate a pdf report
        Console.WriteLine($"Successfully generated a pdf report with the contents of {tableName}");
    }

    public static void GenerateMySqlHTMLReport(SqlConnection connection, string tableName)
    {
        // Get data from the table and generate an html report
        Console.WriteLine($"Successfully generated a report with the contents of {tableName} and exported them to HTML");
    }
    
    
}