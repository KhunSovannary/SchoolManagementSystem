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
    class TeacherRepository : Repository<Teacher>
    {
        public override List<Teacher> Read()
        {
            List<Teacher> ts = new List<Teacher>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            String sql = "SELECT * FROM Teacher";
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                Teacher t = new Teacher();

                t.Id = dbCon.sqlDataReader[0].ToString();
                t.Name = (dbCon.sqlDataReader[1] ?? null).ToString();
                t.Gender = (dbCon.sqlDataReader[2] ?? null).ToString();
                t.Dob = (dbCon.sqlDataReader[3] ?? null).ToString();
                t.PhoneNumber = (dbCon.sqlDataReader[4] ?? null).ToString();
                t.Address = (dbCon.sqlDataReader[5] ?? null).ToString();

                t.DepartmentId = (dbCon.sqlDataReader[6] ?? null).ToString();
                t.Salary = dbCon.sqlDataReader[7] is DBNull ? 0 : double.Parse(Convert.ToString(dbCon.sqlDataReader[7]));
                t.Photo = (dbCon.sqlDataReader[8] as Byte[]) ?? null;
                ts.Add(t);

            }
            return ts;
        }
        public override void Create(Teacher t)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"INSERT INTO Teacher(TeacherID,TeacherName,Gender,Dob, PhoneNumber,Address,DepartmentID,Salary,ProfilePicture)" + "" +
               "VALUES(@tID,@tName,@Gender,@DOB, @PhoneNumber, @Address,@depID, @salary,@pic); ";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@tID", t.Id);
            dbCon.com.Parameters.AddWithValue("@tName", t.Name);
            dbCon.com.Parameters.AddWithValue("@Gender", t.Gender);
            dbCon.com.Parameters.AddWithValue("@DOB",t.Dob);
            dbCon.com.Parameters.AddWithValue("@PhoneNumber",t.PhoneNumber);
            dbCon.com.Parameters.AddWithValue("@Address", t.Address);
            dbCon.com.Parameters.AddWithValue("@depID", t.DepartmentId);
            dbCon.com.Parameters.AddWithValue("@salary",t.Salary);
            dbCon.com.Parameters.AddWithValue("@pic", t.Photo);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Teacher is added.");
            }



        }
        public override void Update(Teacher t)
        {



            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"update Teacher set TeacherName = @tName, Gender = @Gender, Dob = @DOB, PhoneNumber = @PhoneNumber,  Address = @Address,  DepartmentID = @depID, Salary = @salary, ProfilePicture = @pic " +
               "Where TeacherID= @tID";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);

            dbCon.com.Parameters.AddWithValue("@tName", t.Name);
            dbCon.com.Parameters.AddWithValue("@Gender",t.Gender);
            dbCon.com.Parameters.AddWithValue("@DOB",t.Dob);
            dbCon.com.Parameters.AddWithValue("@PhoneNumber", t.PhoneNumber);
            dbCon.com.Parameters.AddWithValue("@Address",t.Address);
            dbCon.com.Parameters.AddWithValue("@depID", t.DepartmentId);
            dbCon.com.Parameters.AddWithValue("@salary", t.Salary);
            dbCon.com.Parameters.AddWithValue("@pic", t.Photo);
            dbCon.com.Parameters.AddWithValue("@tID",t.Id);



            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Teacher is updated.");
            }

        }
        public override void Delete(string id)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = @"Delete from Teacher Where TeacherID= @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", id);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Teacher is deleted");
            }

        }
        public override List<Teacher> ReadByID(string id)
        {
            List<Teacher> ts = new List<Teacher>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            string CommandText = "SELECT* FROM Teacher where TeacherID = @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", int.Parse(id));

            dbCon.sqlDataReader = dbCon.com.ExecuteReader();


            while (dbCon.sqlDataReader.Read())
            {
                Teacher t = new Teacher();

                t.Id = dbCon.sqlDataReader[0].ToString();
                t.Name = (dbCon.sqlDataReader[1] ?? null).ToString();
                t.Gender = (dbCon.sqlDataReader[2] ?? null).ToString();
                t.Dob = (dbCon.sqlDataReader[3] ?? null).ToString();
                t.PhoneNumber = (dbCon.sqlDataReader[4] ?? null).ToString();
                t.Address = (dbCon.sqlDataReader[5] ?? null).ToString();
                t.DepartmentId = (dbCon.sqlDataReader[6] ?? null).ToString();
                t.Salary = dbCon.sqlDataReader[7] is DBNull ? 0 : double.Parse(Convert.ToString(dbCon.sqlDataReader[7]));
                t.Photo = (dbCon.sqlDataReader[8] as Byte[]) ?? null;
                ts.Add(t);




            }
            return ts;

        }
    }
}
