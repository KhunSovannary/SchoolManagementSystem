using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class Teacher: Employee
    {
         static DatabaseConnection DatabaseConnection = DatabaseConnection.uniqueDatabaseConnection;
        public Teacher()
        {

        }
        public Teacher(string tId, string tName, string Dob, string gender,
            string phnnum, string address, double salary, string depId, Byte[] photo) : base(tId, tName, Dob, gender, phnnum, address,salary, depId,photo)
        {

            
        }
        public Teacher Clone()
        {
            return new Teacher(Id, Name, Dob, Gender, PhoneNumber, Address, Salary, DepartmentId, Photo);
        }
        static public List<Teacher> ReadData()
        {
            List<Teacher> ts = new List<Teacher>();
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();
            String sql = "SELECT * FROM Teacher";
            DatabaseConnection.com = new SqlCommand(sql, DatabaseConnection.con);
            DatabaseConnection.sqlDataReader = DatabaseConnection.com.ExecuteReader();
            while (DatabaseConnection.sqlDataReader.Read())
            {
                Teacher t = new Teacher();

                t.Id = DatabaseConnection.sqlDataReader[0].ToString();
                t.Name = (DatabaseConnection.sqlDataReader[1] ?? null).ToString();
                t.Gender = (DatabaseConnection.sqlDataReader[2] ?? null).ToString();
                t.Dob = (DatabaseConnection.sqlDataReader[3] ?? null).ToString();
                t.PhoneNumber = (DatabaseConnection.sqlDataReader[4] ?? null).ToString();
                t.Address = (DatabaseConnection.sqlDataReader[5] ?? null).ToString();
               
                t.DepartmentId = (DatabaseConnection.sqlDataReader[6] ?? null).ToString();
                t.Salary = DatabaseConnection.sqlDataReader[7] is DBNull ? 0 : double.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[7]));
                t.Photo = (DatabaseConnection.sqlDataReader[8] as Byte[]) ?? null;
                ts.Add(t);

            }
            return ts;
        }
        static public void InsertData(string tId, string tName, string tDob, string gender,
            string phnnum, string address, double salary, string depId, byte[] pic)
        {
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();


            string CommandText = @"INSERT INTO Teacher(TeacherID,TeacherName,Gender,Dob, PhoneNumber,Address,DepartmentID,Salary,ProfilePicture)" + "" +
               "VALUES(@tID,@tName,@Gender,@DOB, @PhoneNumber, @Address,@depID, @salary,@pic); ";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@tID", tId);
            DatabaseConnection.com.Parameters.AddWithValue("@tName", tName);
            DatabaseConnection.com.Parameters.AddWithValue("@Gender", gender);
            DatabaseConnection.com.Parameters.AddWithValue("@DOB", tDob);
            DatabaseConnection.com.Parameters.AddWithValue("@PhoneNumber", phnnum);
            DatabaseConnection.com.Parameters.AddWithValue("@Address", address);
            DatabaseConnection.com.Parameters.AddWithValue("@depID", depId);
            DatabaseConnection.com.Parameters.AddWithValue("@salary", salary);
            DatabaseConnection.com.Parameters.AddWithValue("@pic", pic);
            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Teacher is added.");
            }



        }
        static public void UpdateData(string tId, string tName, string tDob, string gender,
            string phnnum, string address, double salary, string depId, byte[] pic)
        {



            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();


            string CommandText = @"update Teacher set TeacherName = @tName, Gender = @Gender, Dob = @DOB, PhoneNumber = @PhoneNumber,  Address = @Address,  DepartmentID = @depID, Salary = @salary, ProfilePicture = @pic " +
               "Where TeacherID= @tID";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);

            DatabaseConnection.com.Parameters.AddWithValue("@tName", tName);
            DatabaseConnection.com.Parameters.AddWithValue("@Gender", gender);
            DatabaseConnection.com.Parameters.AddWithValue("@DOB", tDob);
            DatabaseConnection.com.Parameters.AddWithValue("@PhoneNumber", phnnum);
            DatabaseConnection.com.Parameters.AddWithValue("@Address", address);
            DatabaseConnection.com.Parameters.AddWithValue("@depID", depId);
            DatabaseConnection.com.Parameters.AddWithValue("@salary", salary);

            DatabaseConnection.com.Parameters.AddWithValue("@pic", pic);
            DatabaseConnection.com.Parameters.AddWithValue("@tID", tId);
           


            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Teacher is updated.");
            }

        }
        static public void DeleteData(string id)
        {
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();

            string CommandText = @"Delete from Teacher Where TeacherID= @id";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Teacher is deleted");
            }

        }
        public static List<Teacher> SearchData(string id)
        {

            List<Teacher> ts = new List<Teacher>();
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();
            string CommandText = "SELECT* FROM Teacher where TeacherID = @id";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@id", int.Parse(id));

            DatabaseConnection.sqlDataReader = DatabaseConnection.com.ExecuteReader();


            while (DatabaseConnection.sqlDataReader.Read())
            {
                Teacher t = new Teacher();

                t.Id = DatabaseConnection.sqlDataReader[0].ToString();
                t.Name = (DatabaseConnection.sqlDataReader[1] ?? null).ToString();
                t.Gender = (DatabaseConnection.sqlDataReader[2] ?? null).ToString();
                t.Dob = (DatabaseConnection.sqlDataReader[3] ?? null).ToString();
                t.PhoneNumber = (DatabaseConnection.sqlDataReader[4] ?? null).ToString();
                t.Address = (DatabaseConnection.sqlDataReader[5] ?? null).ToString();   
                t.DepartmentId = (DatabaseConnection.sqlDataReader[6] ?? null).ToString();
                t.Salary = DatabaseConnection.sqlDataReader[7] is DBNull ? 0 : double.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[7]));
                t.Photo = (DatabaseConnection.sqlDataReader[8] as Byte[]) ?? null;
                ts.Add(t);




            }
            return ts;

        }

    }
    }


