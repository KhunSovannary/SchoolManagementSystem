using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class Department
    {
   static DatabaseConnection dataBaseConnection = DatabaseConnection.uniqueDBConnection;
        private string department_id, department_name;
        public string DepartmentId {
            get { return department_id; }
            set { department_id = value; }
        }
        public string DepartmentName {
            get { return department_name; }
            set { department_name = value; }
        }
       
        
        public Department()
        {

        }
        public Department(string depId, string depName)
        {
            department_id = depId;
            department_name = depName;
         
        }
        public string DepartmentDetails()
        {
            return "";
        }
        public Department Clone()
        {
            return new Department(DepartmentId, DepartmentName);
        }
       static public List<Department> ReadData() {
            List<Department> deps = new List<Department>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            String sql = "SELECT * FROM Department";
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                Department dep = new Department();

                dep.DepartmentId = dataBaseConnection.sqlDataReader[0].ToString();
                dep.DepartmentName = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                deps.Add(dep);

            }
            return deps;
        }
        static public void InsertData(string depId, string depName) {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"INSERT INTO Department(DepartmentID,DepartmentName)" + "" +
               "VALUES(@depID,@depName); ";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@depID", depId);
            dataBaseConnection.com.Parameters.AddWithValue("@depName", depName);
   
            

            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Department is added.");
            }
        }
        static public void UpdateData(string depId, string depName) {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"Update Department set DepartmentName= @depName WHERE DepartmentID= @depID";
              
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@depName", depName);
            dataBaseConnection.com.Parameters.AddWithValue("@depID", depId);

            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Department is updated.");
            }
        }
        static public void DeleteData(string id) {

            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            string CommandText = @"Delete from Department Where DepartmentID= @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Department is deleted");
            }
        }
        static public List<Department> SearchData(string id)
        {
            List<Department> deps = new List<Department>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            String sql = "SELECT * FROM Department Where DepartmentID = @id";
            dataBaseConnection.com.Parameters.AddWithValue("@id", int.Parse(id));
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                Department dep = new Department();
                dep.DepartmentId = dataBaseConnection.sqlDataReader[0].ToString();
                dep.DepartmentName = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                deps.Add(dep);

            }
            return deps;
        }
    }
}
