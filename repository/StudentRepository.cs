using SchoolManagementSystem.repository;
using SchoolManagementSystem.model.student;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.repository
{
    public class StudentRepository : Repository<Student>
    {
         public override List<Student> Read()
        {
            List<Student> students = new List<Student>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            String sql = "SELECT * FROM Student";
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                Student stu = new Student();

                stu.Id = dbCon.sqlDataReader[0].ToString();
                stu.Name = (dbCon.sqlDataReader[1] ?? null).ToString();
                stu.Gender = (dbCon.sqlDataReader[2] ?? null).ToString();
                stu.Dob = (dbCon.sqlDataReader[3] ?? null).ToString();
                stu.PhoneNumber = (dbCon.sqlDataReader[4] ?? null).ToString();
                stu.Address = (dbCon.sqlDataReader[5] ?? null).ToString();
                stu.ClassId = (dbCon.sqlDataReader[6] ?? null).ToString();
                stu.DepartmentId = (dbCon.sqlDataReader[7] ?? null).ToString();
                stu.Photo = (dbCon.sqlDataReader[8] as Byte[]) ?? null;
                stu.Year = (dbCon.sqlDataReader[9] ?? null).ToString();
                stu.StartDate = (dbCon.sqlDataReader[10] ?? null).ToString();
                stu.GraduateDate = (dbCon.sqlDataReader[11] ?? null).ToString();
                stu.DropPeriod = (dbCon.sqlDataReader[12] ?? null).ToString();
            
                students.Add(stu);

            }
            return students;

        }
         public override void Create(Student s)
        {   dbCon.con = new SqlConnection(dbCon.conStr);
             dbCon.con.Open();
            string CommandText = @"INSERT INTO Student(StudentID,StudentName,Gender,Dob, PhoneNumber,Address,ClassId,DepartmentId, Year, StartDate, GraduateDate, DropPeriod, ProfilePicture)" +
               "VALUES(@ID,@Name,@Gender,@DOB,@PhoneNumber,@Address,@Class,@depID, @y, @sD, @eD, @dP, @pic); ";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@ID", s.Id);
            dbCon.com.Parameters.AddWithValue("@Name", s.Name);
            dbCon.com.Parameters.AddWithValue("@Gender", s.Gender);
            dbCon.com.Parameters.AddWithValue("@DOB",s.Dob);
            dbCon.com.Parameters.AddWithValue("@PhoneNumber", s.PhoneNumber);
            dbCon.com.Parameters.AddWithValue("@Address",s.Address);
            dbCon.com.Parameters.AddWithValue("@Class", s.ClassId);
            dbCon.com.Parameters.AddWithValue("@depID",s.DepartmentId);
            dbCon.com.Parameters.AddWithValue("@y", s.Year);
            dbCon.com.Parameters.AddWithValue("@sD", s.StartDate);
            dbCon.com.Parameters.AddWithValue("@eD", s.GraduateDate);
            dbCon.com.Parameters.AddWithValue("@dP", s.DropPeriod);
            dbCon.com.Parameters.AddWithValue("@pic",s.Photo );
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Student is added.");
            }
        }
        public override void Update(Student s)   {

            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = @"update Student set StudentName = @Name, Gender = @Gender, Dob = @DOB, PhoneNumber = @PhoneNumber,  Address = @Address, ClassId = @Class, DepartmentID = @depID, Year = @y, StartDate = @sD, GraduateDate = @eD, DropPeriod = @dP,ProfilePicture = @pic " +
            "Where StudentID= @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);

            dbCon.com.Parameters.AddWithValue("@Name", s.Name);
            dbCon.com.Parameters.AddWithValue("@Gender", s.Gender);
            dbCon.com.Parameters.AddWithValue("@DOB", s.Dob);
            dbCon.com.Parameters.AddWithValue("@PhoneNumber", s.PhoneNumber);
            dbCon.com.Parameters.AddWithValue("@Address", s.Address);
            dbCon.com.Parameters.AddWithValue("@Class", s.ClassId);
            dbCon.com.Parameters.AddWithValue("@depID",s.DepartmentId);
            dbCon.com.Parameters.AddWithValue("@y", s.Year);
            dbCon.com.Parameters.AddWithValue("@sD", s.StartDate);
            dbCon.com.Parameters.AddWithValue("@eD", s.GraduateDate);
            dbCon.com.Parameters.AddWithValue("@dP", s.DropPeriod);
            dbCon.com.Parameters.AddWithValue("@id",s.Id );
            dbCon.com.Parameters.AddWithValue("@pic", s.Photo);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Student is updated.");
            }
        }
        public override void Delete(string id)
        {

            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = @"Delete from Student Where StudentID= @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", id);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Student is deleted");
            }

        }
        public  override List<Student> ReadByID(string id)
        {
            List<Student> students = new List<Student>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            string CommandText = "SELECT* FROM Student where StudentID = @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", int.Parse(id));
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                Student s = new Student();

                Student stu = new Student();

                stu.Id = dbCon.sqlDataReader[0].ToString();
                stu.Name = (dbCon.sqlDataReader[1] ?? null).ToString();
                stu.Gender = (dbCon.sqlDataReader[2] ?? null).ToString();
                stu.Dob = (dbCon.sqlDataReader[3] ?? null).ToString();
                stu.PhoneNumber = (dbCon.sqlDataReader[4] ?? null).ToString();
                stu.Address = (dbCon.sqlDataReader[5] ?? null).ToString();
                stu.ClassId = (dbCon.sqlDataReader[6] ?? null).ToString();
                stu.DepartmentId = (dbCon.sqlDataReader[7] ?? null).ToString();
                stu.Photo = (dbCon.sqlDataReader[8] as Byte[]) ?? null;
                students.Add(stu);

            }
            return students;

        }
    }
}
