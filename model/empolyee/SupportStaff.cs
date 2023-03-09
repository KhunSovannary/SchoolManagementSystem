using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class SupportStaff : Employee
    {
        private string job_title;
         static DatabaseConnection dataBaseConnection = DatabaseConnection.uniqueDBConnection;
        public string JobTitle
        {
            get { return job_title; }
            set { job_title = value; }
        }
        public SupportStaff() { }
        public SupportStaff(string ssId, string ssName, string Dob, string gender,
                string phnnum, string address, double salary, string depId, string job, Byte[] photo) : base(ssId, ssName, Dob, gender, phnnum, address, salary, depId, photo)
        {
            job_title = job;
        }
        public SupportStaff Clone()
        {
            return new SupportStaff(Id, Name, Dob, Gender, PhoneNumber, Address, Salary, DepartmentId, JobTitle,Photo);
        }
        static public List<SupportStaff> ReadData()
        {

            List<SupportStaff> staffs = new List<SupportStaff>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            String sql = "SELECT * FROM SupportStaff";
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                SupportStaff ss = new SupportStaff();

                ss.Id = dataBaseConnection.sqlDataReader[0].ToString();
                ss.Name = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                ss.Gender = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                ss.Dob = (dataBaseConnection.sqlDataReader[3] ?? null).ToString();
                ss.PhoneNumber = (dataBaseConnection.sqlDataReader[4] ?? null).ToString();
                ss.Address = (dataBaseConnection.sqlDataReader[5] ?? null).ToString();
                ss.Salary = dataBaseConnection.sqlDataReader[6] is DBNull ? 0 : double.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[6]));
                ss.DepartmentId = (dataBaseConnection.sqlDataReader[7] ?? null).ToString();
                ss.JobTitle = (dataBaseConnection.sqlDataReader[8] ?? null).ToString();
                ss.Photo = (dataBaseConnection.sqlDataReader[9] as Byte[]) ?? null;
                staffs.Add(ss);

            }
            return staffs;
        }
        static public void InsertData(string ssId, string ssName, string Dob, string gender,
                string phnnum, string address, double salary, string depId, string job, Byte[] photo)
        {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"INSERT INTO SupportStaff(SupportStaffID,SupportStaffName,Gender,Dob, PhoneNumber,Address,Salary,DepartmentID,JobTitle,ProfilePicture)" + "" +
               "VALUES(@ssID,@ssName,@Gender,@DOB, @PhoneNumber, @Address,@salary, @depID,@job,@pic); ";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@ssID", ssId);
            dataBaseConnection.com.Parameters.AddWithValue("@ssName", ssName);
            dataBaseConnection.com.Parameters.AddWithValue("@Gender", gender);
            dataBaseConnection.com.Parameters.AddWithValue("@DOB", Dob);
            dataBaseConnection.com.Parameters.AddWithValue("@PhoneNumber", phnnum);
            dataBaseConnection.com.Parameters.AddWithValue("@Address", address);
            dataBaseConnection.com.Parameters.AddWithValue("@depID", depId);
            dataBaseConnection.com.Parameters.AddWithValue("@salary", salary);
            dataBaseConnection.com.Parameters.AddWithValue("@job", job);
            dataBaseConnection.com.Parameters.AddWithValue("@pic", photo);
            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New SupportStaff is added.");
            }



        }
        static public void UpdateData(string ssId, string ssName, string Dob, string gender,
                string phnnum, string address, double salary, string depId, string job, Byte[] photo)
        {

            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"update SupportStaff set SupportStaffName = @ssName, Gender = @Gender, Dob = @DOB, PhoneNumber = @PhoneNumber,  Address = @Address,   Salary = @salary, DepartmentID = @depID, JobTitle = @job, ProfilePicture = @pic " +
               "Where SupportStaffID= @ssID";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);

            dataBaseConnection.com.Parameters.AddWithValue("@ssName", ssName);
            dataBaseConnection.com.Parameters.AddWithValue("@Gender", gender);
            dataBaseConnection.com.Parameters.AddWithValue("@DOB", Dob);
            dataBaseConnection.com.Parameters.AddWithValue("@PhoneNumber", phnnum);
            dataBaseConnection.com.Parameters.AddWithValue("@Address", address);
            dataBaseConnection.com.Parameters.AddWithValue("@salary", salary);
            dataBaseConnection.com.Parameters.AddWithValue("@depID", depId);
            dataBaseConnection.com.Parameters.AddWithValue("@job", job);
            dataBaseConnection.com.Parameters.AddWithValue("@pic", photo);
            dataBaseConnection.com.Parameters.AddWithValue("@ssID", ssId);



            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New SupportStaff is updated.");
            }

        }
        static public void DeleteData(string id)
        {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            string CommandText = @"Delete from SupportStaff Where SupportStaffID= @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("SupportStaff is deleted");
            }

        }
        public static List<SupportStaff> SearchData(string id)
        {

            List<SupportStaff> staffs = new List<SupportStaff>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            string CommandText = "SELECT* FROM SupportStaff where SupportStaffID = @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", int.Parse(id));

            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();


            while (dataBaseConnection.sqlDataReader.Read())
            {
                

                SupportStaff ss = new SupportStaff();

                ss.Id = dataBaseConnection.sqlDataReader[0].ToString();
                ss.Name = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                ss.Gender = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                ss.Dob = (dataBaseConnection.sqlDataReader[3] ?? null).ToString();
                ss.PhoneNumber = (dataBaseConnection.sqlDataReader[4] ?? null).ToString();
                ss.Address = (dataBaseConnection.sqlDataReader[5] ?? null).ToString();
                ss.Salary = dataBaseConnection.sqlDataReader[6] is DBNull ? 0 : double.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[6]));
                ss.DepartmentId = (dataBaseConnection.sqlDataReader[7] ?? null).ToString();
                ss.JobTitle = (dataBaseConnection.sqlDataReader[8] ?? null).ToString();
                ss.Photo = (dataBaseConnection.sqlDataReader[9] as Byte[]) ?? null;
                staffs.Add(ss);

            }
            return staffs;

        }


    }
}
