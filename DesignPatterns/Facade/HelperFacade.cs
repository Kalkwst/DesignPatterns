using System.Data;
using System.Data.SqlClient;

namespace Facade;

public class HelperFacade
{
    public static void GenerateReport(DBConnector connector, ReportType reportType, string tableName)
    {
        var connectorRegistry = new Dictionary<DBConnector, Func<string, IDbConnection>>()
        {
            { DBConnector.MYSQL, MySqlHelper.GetDBConnection },
            { DBConnector.MSSQL, MSSqlHelper.GetDBConnection },
            { DBConnector.MONGO, MongoDBHelper.GetDBConnection }
        };

        var generatorRegistry = new Dictionary<ReportType, Action<IDbConnection, DBConnector, string>>()
        {
            { ReportType.HTML, GenerateHTMLReport },
            { ReportType.PDF, GeneratePDFReport }
        };
        
        if (!connectorRegistry.ContainsKey(connector) || !generatorRegistry.ContainsKey(reportType))
        {
            throw new ArgumentException("Invalid connector or report type.");
        }

        var getConnectionMethod = connectorRegistry[connector];
        var generateReportMethod = generatorRegistry[reportType];
        
        using (var connection = getConnectionMethod("connectionString"))
        {
            generateReportMethod(connection, connector, tableName);
        }
    }
    
    private static void GenerateHTMLReport(IDbConnection connection, DBConnector connector, string tableName)
    {
        switch (connector)
        {
            case DBConnector.MYSQL:
                MySqlHelper.GenerateMySqlHTMLReport(new SqlConnection(), tableName);
                break;
            case DBConnector.MSSQL:
                MSSqlHelper.GenerateMSSqlHTMLReport(new SqlConnection(), tableName);
                break;
            case DBConnector.MONGO:
                MongoDBHelper.GenerateMongoHTMLReport(new SqlConnection(), tableName);
                break;
            default:
                throw new ArgumentException("Invalid database connection.");
        }
    }

    private static void GeneratePDFReport(IDbConnection connection, DBConnector connector, string tableName)
    {
        switch (connector)
        {
            case DBConnector.MYSQL:
                MySqlHelper.GenerateMySqlPDFReport(new SqlConnection(), tableName);
                break;
            case DBConnector.MSSQL:
                MSSqlHelper.GenerateMSSqlPDFReport(new SqlConnection(), tableName);
                break;
            case DBConnector.MONGO:
                MongoDBHelper.GenerateMongoPDFReport(new SqlConnection(), tableName);
                break;
            default:
                throw new ArgumentException("Invalid database connection.");
        }
    }

    public enum DBConnector
    {
        MYSQL, MSSQL, MONGO
    }

    public enum ReportType
    {
        HTML, PDF
    }
}