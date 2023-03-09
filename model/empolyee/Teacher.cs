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
         static DatabaseConnection dataBaseConnection = DatabaseConnection.uniqueDBConnection;
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
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            String sql = "SELECT * FROM Teacher";
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                Teacher t = new Teacher();

                t.Id = dataBaseConnection.sqlDataReader[0].ToString();
                t.Name = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                t.Gender = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                t.Dob = (dataBaseConnection.sqlDataReader[3] ?? null).ToString();
                t.PhoneNumber = (dataBaseConnection.sqlDataReader[4] ?? null).ToString();
                t.Address = (dataBaseConnection.sqlDataReader[5] ?? null).ToString();
               
                t.DepartmentId = (dataBaseConnection.sqlDataReader[6] ?? null).ToString();
                t.Salary = dataBaseConnection.sqlDataReader[7] is DBNull ? 0 : double.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[7]));
                t.Photo = (dataBaseConnection.sqlDataReader[8] as Byte[]) ?? null;
                ts.Add(t);

            }
            return ts;
        }
        static public void InsertData(string tId, string tName, string tDob, string gender,
            string phnnum, string address, double salary, string depId, byte[] pic)
        {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"INSERT INTO Teacher(TeacherID,TeacherName,Gender,Dob, PhoneNumber,Address,DepartmentID,Salary,ProfilePicture)" + "" +
               "VALUES(@tID,@tName,@Gender,@DOB, @PhoneNumber, @Address,@depID, @salary,@pic); ";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@tID", tId);
            dataBaseConnection.com.Parameters.AddWithValue("@tName", tName);
            dataBaseConnection.com.Parameters.AddWithValue("@Gender", gender);
            dataBaseConnection.com.Parameters.AddWithValue("@DOB", tDob);
            dataBaseConnection.com.Parameters.AddWithValue("@PhoneNumber", phnnum);
            dataBaseConnection.com.Parameters.AddWithValue("@Address", address);
            dataBaseConnection.com.Parameters.AddWithValue("@depID", depId);
            dataBaseConnection.com.Parameters.AddWithValue("@salary", salary);
            dataBaseConnection.com.Parameters.AddWithValue("@pic", pic);
            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Teacher is added.");
            }



        }
        static public void UpdateData(string tId, string tName, string tDob, string gender,
            string phnnum, string address, double salary, string depId, byte[] pic)
        {



            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"update Teacher set TeacherName = @tName, Gender = @Gender, Dob = @DOB, PhoneNumber = @PhoneNumber,  Address = @Address,  DepartmentID = @depID, Salary = @salary, ProfilePicture = @pic " +
               "Where TeacherID= @tID";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);

            dataBaseConnection.com.Parameters.AddWithValue("@tName", tName);
            dataBaseConnection.com.Parameters.AddWithValue("@Gender", gender);
            dataBaseConnection.com.Parameters.AddWithValue("@DOB", tDob);
            dataBaseConnection.com.Parameters.AddWithValue("@PhoneNumber", phnnum);
            dataBaseConnection.com.Parameters.AddWithValue("@Address", address);
            dataBaseConnection.com.Parameters.AddWithValue("@depID", depId);
            dataBaseConnection.com.Parameters.AddWithValue("@salary", salary);

            dataBaseConnection.com.Parameters.AddWithValue("@pic", pic);
            dataBaseConnection.com.Parameters.AddWithValue("@tID", tId);
           


            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Teacher is updated.");
            }

        }
        static public void DeleteData(string id)
        {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            string CommandText = @"Delete from Teacher Where TeacherID= @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Teacher is deleted");
            }

        }
        public static List<Teacher> SearchData(string id)
        {

            List<Teacher> ts = new List<Teacher>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            string CommandText = "SELECT* FROM Teacher where TeacherID = @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", int.Parse(id));

            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();


            while (dataBaseConnection.sqlDataReader.Read())
            {
                Teacher t = new Teacher();

                t.Id = dataBaseConnection.sqlDataReader[0].ToString();
                t.Name = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                t.Gender = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                t.Dob = (dataBaseConnection.sqlDataReader[3] ?? null).ToString();
                t.PhoneNumber = (dataBaseConnection.sqlDataReader[4] ?? null).ToString();
                t.Address = (dataBaseConnection.sqlDataReader[5] ?? null).ToString();   
                t.DepartmentId = (dataBaseConnection.sqlDataReader[6] ?? null).ToString();
                t.Salary = dataBaseConnection.sqlDataReader[7] is DBNull ? 0 : double.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[7]));
                t.Photo = (dataBaseConnection.sqlDataReader[8] as Byte[]) ?? null;
                ts.Add(t);




            }
            return ts;

        }

    }
    }


