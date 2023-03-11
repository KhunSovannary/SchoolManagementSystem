using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.model
{
    public sealed class DatabaseConnection
    {

        public string conStr { get; set; }
        static public string server;
        public SqlConnection con { get; set; }
        public SqlCommand com { get; set; }
        public SqlDataAdapter dap { get; set; }
        public SqlDataReader sqlDataReader { get; set; }


        static readonly DatabaseConnection instance = new DatabaseConnection();
      DatabaseConnection()
        {
            conStr = "Data Source="+ server +"; Initial Catalog=SchoolManagement; Integrated Security=true;";
            SqlDependency.Stop(conStr);
            SqlDependency.Start(conStr);
        }

    public static DatabaseConnection uniqueDatabaseConnection
        {
            get { return instance; }
        }
        
    }
}
