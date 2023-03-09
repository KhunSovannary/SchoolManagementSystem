using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{   
    class Student:Person
    {
        static DatabaseConnection dataBaseConnection = DatabaseConnection.uniqueDBConnection;
        private string class_id, department_id; 
        public string ClassId
        {
            get { return class_id; }
            set { class_id = value; }
        }
        public string DepartmentId
        {
            get { return department_id; }
            set { department_id = value; }
        }


        public Student() { }
        public Student(string stuId, string stuName, string gender, string dob,string address,string phnNum,
                    string classId, string depId, Byte[] photo):base(stuId,stuName,gender,dob,phnNum,address,photo)
        {
            class_id = classId;
            department_id = depId;
        
          
        }
        public string StudentDetails()
        {
            return "";
        }
        public void PayFees()
        {

        }
        

        public Student Clone()
        {
            return new Student(Id, Name,Gender,Dob,Address,PhoneNumber,ClassId,DepartmentId,Photo);
        }
        public static Student CreateStudent(string stuId, string stuName, string gender, string dob, string address, string phnNum,
                    string classId, string depId, Byte[] photo)
        {
            return new Student(stuId, stuName, gender, dob, address, phnNum, classId, depId, photo);
        }
        public void SetData()
        {
        }
        static public List<Student> ReadData()
        {
            List<Student> students = new List<Student>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            String sql = "SELECT * FROM Student";
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                Student stu = new Student();

                stu.Id = dataBaseConnection.sqlDataReader[0].ToString();
                stu.Name = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                stu.Gender = (dataBaseConnection.sqlDataReader[2]??null).ToString();
                stu.Dob = (dataBaseConnection.sqlDataReader[3] ?? null).ToString();
                stu.PhoneNumber = (dataBaseConnection.sqlDataReader[4] ?? null).ToString();
                stu.Address = (dataBaseConnection.sqlDataReader[5] ?? null).ToString();
                stu.ClassId = (dataBaseConnection.sqlDataReader[6]??null).ToString();               
                stu.DepartmentId = (dataBaseConnection.sqlDataReader[7]??null).ToString();
                stu.Photo = (dataBaseConnection.sqlDataReader[8] as Byte[]) ?? null ;


                students.Add(stu);
                
            }
            return students;

        }
        static public void InsertData(string stuId, string stuName, string gender, string dob, string address, string phnNum,
                    string classId, string depId, byte[] pic)
        {

            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"INSERT INTO Student(StudentID,StudentName,Gender,Dob, PhoneNumber,Address,ClassId,DepartmentId,ProfilePicture)" +
               "VALUES(@ID,@Name,@Gender,@DOB,@PhoneNumber,@Address,@Class,@depID,@pic); ";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@ID", stuId);
            dataBaseConnection.com.Parameters.AddWithValue("@Name", stuName);
            dataBaseConnection.com.Parameters.AddWithValue("@Gender", gender);
            dataBaseConnection.com.Parameters.AddWithValue("@DOB", dob);
            dataBaseConnection.com.Parameters.AddWithValue("@PhoneNumber", phnNum);
            dataBaseConnection.com.Parameters.AddWithValue("@Address", address);
            dataBaseConnection.com.Parameters.AddWithValue("@Class", classId);
            dataBaseConnection.com.Parameters.AddWithValue("@depID", depId);
            dataBaseConnection.com.Parameters.AddWithValue("@pic", pic);






            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Student is added.");
            }



        }
        static public void UpdateData(string stuId, string stuName, string gender, string dob, string address, string phnNum,
                    string classId, string depId, byte[] pic)
        {

            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
              
            string CommandText = @"update Student set StudentName = @Name, Gender = @Gender, Dob = @DOB, PhoneNumber = @PhoneNumber,  Address = @Address, ClassId = @Class, DepartmentID = @depID, ProfilePicture = @pic " +
            "Where StudentID= @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
    
            dataBaseConnection.com.Parameters.AddWithValue("@Name", stuName);
            dataBaseConnection.com.Parameters.AddWithValue("@Gender", gender);
            dataBaseConnection.com.Parameters.AddWithValue("@DOB", dob);
            dataBaseConnection.com.Parameters.AddWithValue("@PhoneNumber", phnNum);
            dataBaseConnection.com.Parameters.AddWithValue("@Address", address);
            dataBaseConnection.com.Parameters.AddWithValue("@Class", classId);
            dataBaseConnection.com.Parameters.AddWithValue("@depID", depId);
            dataBaseConnection.com.Parameters.AddWithValue("@id", stuId);
            dataBaseConnection.com.Parameters.AddWithValue("@pic", pic);





            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Student is updated.");
            }
        }
        public static void DeleteData(string id)
        {

            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            string CommandText = @"Delete from Student Where StudentID= @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Student is deleted");
            }

        }

        public static List<Student> SearchData(string id)
        {

            List<Student> students = new List<Student>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            string CommandText = "SELECT* FROM Student where StudentID = @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id",int.Parse(id));

            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();


            while (dataBaseConnection.sqlDataReader.Read())
            {
                Student s = new Student();

                Student stu = new Student();

                stu.Id = dataBaseConnection.sqlDataReader[0].ToString();
                stu.Name = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                stu.Gender = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                stu.Dob = (dataBaseConnection.sqlDataReader[3] ?? null).ToString();
                stu.PhoneNumber = (dataBaseConnection.sqlDataReader[4] ?? null).ToString();
                stu.Address = (dataBaseConnection.sqlDataReader[5] ?? null).ToString();
                stu.ClassId = (dataBaseConnection.sqlDataReader[6] ?? null).ToString();
                stu.DepartmentId = (dataBaseConnection.sqlDataReader[7] ?? null).ToString();
                stu.Photo = (dataBaseConnection.sqlDataReader[8] as Byte[]) ?? null;


                students.Add(stu);

            }
            return students;

        }
    }
  
}
