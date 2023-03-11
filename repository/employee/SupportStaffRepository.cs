using SchoolManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.repository.employee
{
    public class SupportStaffRepository: Repository<SupportStaff>
    {
        public override void Create(SupportStaff sp) {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"INSERT INTO SupportStaff(SupportStaffID,SupportStaffName,Gender,Dob, PhoneNumber,Address,Salary,DepartmentID,JobTitle,ProfilePicture)" + "" +
               "VALUES(@ssID,@ssName,@Gender,@DOB, @PhoneNumber, @Address,@salary, @depID,@job,@pic); ";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@ssID", sp.Id);
            dbCon.com.Parameters.AddWithValue("@ssName", sp.Name);
            dbCon.com.Parameters.AddWithValue("@Gender", sp.Gender);
            dbCon.com.Parameters.AddWithValue("@DOB",sp.Dob);
            dbCon.com.Parameters.AddWithValue("@PhoneNumber", sp.PhoneNumber);
            dbCon.com.Parameters.AddWithValue("@Address", sp.Address);
            dbCon.com.Parameters.AddWithValue("@depID", sp.DepartmentId);
            dbCon.com.Parameters.AddWithValue("@salary",sp.Salary);
            dbCon.com.Parameters.AddWithValue("@job", sp.JobTitle);
            dbCon.com.Parameters.AddWithValue("@pic",sp.Photo);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New SupportStaff is added.");
            }

        }
        public override List<SupportStaff> Read() {
            List<SupportStaff> staffs = new List<SupportStaff>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            String sql = "SELECT * FROM SupportStaff";
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                SupportStaff ss = new SupportStaff();

                ss.Id = dbCon.sqlDataReader[0].ToString();
                ss.Name = (dbCon.sqlDataReader[1] ?? null).ToString();
                ss.Gender = (dbCon.sqlDataReader[2] ?? null).ToString();
                ss.Dob = (dbCon.sqlDataReader[3] ?? null).ToString();
                ss.PhoneNumber = (dbCon.sqlDataReader[4] ?? null).ToString();
                ss.Address = (dbCon.sqlDataReader[5] ?? null).ToString();
                ss.Salary = dbCon.sqlDataReader[6] is DBNull ? 0 : double.Parse(Convert.ToString(dbCon.sqlDataReader[6]));
                ss.DepartmentId = (dbCon.sqlDataReader[7] ?? null).ToString();
                ss.JobTitle = (dbCon.sqlDataReader[8] ?? null).ToString();
                ss.Photo = (dbCon.sqlDataReader[9] as Byte[]) ?? null;
                staffs.Add(ss);

            }
            return staffs;
        }
        public override List<SupportStaff> ReadByID(string id) {
            List<SupportStaff> staffs = new List<SupportStaff>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            string CommandText = "SELECT* FROM SupportStaff where SupportStaffID = @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", int.Parse(id));

            dbCon.sqlDataReader = dbCon.com.ExecuteReader();


            while (dbCon.sqlDataReader.Read())
            {


                SupportStaff ss = new SupportStaff();

                ss.Id = dbCon.sqlDataReader[0].ToString();
                ss.Name = (dbCon.sqlDataReader[1] ?? null).ToString();
                ss.Gender = (dbCon.sqlDataReader[2] ?? null).ToString();
                ss.Dob = (dbCon.sqlDataReader[3] ?? null).ToString();
                ss.PhoneNumber = (dbCon.sqlDataReader[4] ?? null).ToString();
                ss.Address = (dbCon.sqlDataReader[5] ?? null).ToString();
                ss.Salary = dbCon.sqlDataReader[6] is DBNull ? 0 : double.Parse(Convert.ToString(dbCon.sqlDataReader[6]));
                ss.DepartmentId = (dbCon.sqlDataReader[7] ?? null).ToString();
                ss.JobTitle = (dbCon.sqlDataReader[8] ?? null).ToString();
                ss.Photo = (dbCon.sqlDataReader[9] as Byte[]) ?? null;
                staffs.Add(ss);

            }
            return staffs;

        }
        public override void Update(SupportStaff sp) {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"update SupportStaff set SupportStaffName = @ssName, Gender = @Gender, Dob = @DOB, PhoneNumber = @PhoneNumber,  Address = @Address,   Salary = @salary, DepartmentID = @depID, JobTitle = @job, ProfilePicture = @pic " +
               "Where SupportStaffID= @ssID";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);

            dbCon.com.Parameters.AddWithValue("@ssName", sp.Name);
            dbCon.com.Parameters.AddWithValue("@Gender",sp.Gender);
            dbCon.com.Parameters.AddWithValue("@DOB", sp.Dob);
            dbCon.com.Parameters.AddWithValue("@PhoneNumber", sp.PhoneNumber);
            dbCon.com.Parameters.AddWithValue("@Address", sp.Address);
            dbCon.com.Parameters.AddWithValue("@salary", sp.Salary);
            dbCon.com.Parameters.AddWithValue("@depID",sp.DepartmentId);
            dbCon.com.Parameters.AddWithValue("@job", sp.JobTitle);
            dbCon.com.Parameters.AddWithValue("@pic",sp.Photo);
            dbCon.com.Parameters.AddWithValue("@ssID", sp.Id);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New SupportStaff is updated.");
            }
        }
        public override void Delete(string id) {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = @"Delete from SupportStaff Where SupportStaffID= @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", id);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("SupportStaff is deleted");
            }
        }
    }
}
