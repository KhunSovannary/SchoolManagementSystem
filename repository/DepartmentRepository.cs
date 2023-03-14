using SchoolManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.repository
{
    class DepartmentRepository:Repository<Department>
    {
        public override List<Department> Read()
        {
            List<Department> deps = new List<Department>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            String sql = "SELECT * FROM Department";
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                Department dep = new Department();

                dep.DepartmentId = dbCon.sqlDataReader[0].ToString();
                dep.DepartmentName = (dbCon.sqlDataReader[1] ?? null).ToString();
                deps.Add(dep);

            }
            return deps;
        }

        public override void Create(Department d)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"INSERT INTO Department(DepartmentID,DepartmentName)" + "" +
               "VALUES(@depID,@depName); ";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@depID", d.DepartmentId);
            dbCon.com.Parameters.AddWithValue("@depName",d.DepartmentName);



            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Department is added.");
            }
        }
        public override void Update(Department d)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"Update Department set DepartmentName= @depName WHERE DepartmentID= @depID";

            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@depName", d.Name);
            dbCon.com.Parameters.AddWithValue("@depID",d.DepartmentId);

            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Department is updated.");
            }
        }
        public override void Delete(string id)
        {

            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = @"Delete from Department Where DepartmentID= @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", id);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Department is deleted");
            }
        }
        public override List<Department> ReadByID(string id)
        {
            List<Department> deps = new List<Department>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            String sql = "SELECT * FROM Department Where DepartmentID = @id";
            dbCon.com.Parameters.AddWithValue("@id", int.Parse(id));
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                Department dep = new Department();
                dep.DepartmentId = dbCon.sqlDataReader[0].ToString();
                dep.DepartmentName = (dbCon.sqlDataReader[1] ?? null).ToString();
                deps.Add(dep);

            }
            return deps;
        }
    }
}
