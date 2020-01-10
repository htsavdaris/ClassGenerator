using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Server = tcp:crmdbserverhatsav.database.windows.net,1433; Initial Catalog = CRMDB; Persist Security Info = False; User ID =htsavdaris; Password ='multicoPass7425K'; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
            string b = "Server = tcp:crmdbserverhatsav.database.windows.net,1433; Database = CRMDB; Persist Security Info = False; User ID = htsavdaris; Password='multicoPass7425K'; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
            SqlConnection connection;
            connection = new SqlConnection(b);
            Console.WriteLine(connection.GenerateAllTables(GeneratorBehavior.DapperContrib));
            Console.ReadKey();
        }
    }
}
