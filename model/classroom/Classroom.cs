using SchoolManagementSystem.model.student;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    public class Classroom:ISubject
    {
        private List<Student> _students = new List<Student>();
        static DatabaseConnection DatabaseConnection = DatabaseConnection.uniqueDatabaseConnection;
                private string class_id, class_name, teacher_id, equipment_id; 
                private int student_count;
                public string ClassId {
                get { return class_id; }
                set { class_id = value; }
        }
        public string ClassName {
            get { return class_name; }
            set { class_name = value; }
        }
        public string TeacherId {
            get { return teacher_id; }
            set { teacher_id = value; }
        }
        public int StudentCount
        {
            get { return student_count; }
            set { student_count = value; }
        }
            public string EquipmentId {
            get { return equipment_id; }
            set { equipment_id = value; }
        }

        public Classroom() { }
        public Classroom(string classId, string className, string empId, string equipId, int StudentCount)
        {
            class_id = classId;
            class_name = className;
            teacher_id = empId;
            equipment_id = equipId;
            student_count = StudentCount;
        }
        public void Attach(IObserver observer)
        {
            _students.Add((Student)observer);
        }

        public void Detach(IObserver observer)
        {
            _students.Remove((Student)observer);
        }

        public void Notify()
        {
            foreach (var student in _students)
            {
                student.Update();
            }
        }

        public void Enroll(Student student)
        {
            Console.WriteLine($"{student.Name}, you have been enrolled in {class_name}");
            Attach(student);
            Notify();
        }

        public void Disenroll(Student student)
        {
            Console.WriteLine($"{student.Name}, you have been disenrolled from {class_name}");
            Detach(student);
            Notify();
        }
        public string ClassDetails()
        {
            return ClassId + "\t" + ClassName + "\t" + TeacherId + "\t" + StudentCount.ToString() + "\t" + EquipmentId;
        }
        public Classroom Clone()
        {
            return new Classroom(ClassId, ClassName,TeacherId, EquipmentId,StudentCount);
        }

        static public List<Classroom> ReadData() {
            List<Classroom> classes = new List<Classroom>();
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();
            String sql = "SELECT * FROM Classroom";
            DatabaseConnection.com = new SqlCommand(sql, DatabaseConnection.con);
            DatabaseConnection.sqlDataReader = DatabaseConnection.com.ExecuteReader();
            while (DatabaseConnection.sqlDataReader.Read())
            {
                Classroom cls = new Classroom();
                cls.ClassId = DatabaseConnection.sqlDataReader[0].ToString();
                cls.ClassName = (DatabaseConnection.sqlDataReader[1] ?? null).ToString();            
                cls.StudentCount = DatabaseConnection.sqlDataReader[2] is DBNull ? 0 : int.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[2]));
                cls.TeacherId = (DatabaseConnection.sqlDataReader[3] ?? null).ToString();
                cls.EquipmentId = (DatabaseConnection.sqlDataReader[4] ?? null).ToString();
                classes.Add(cls);

            }
            return classes;
        }
        static public void InsertData(string classId, string className, string tId, string equipId, int StudentCount) {
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();
            string CommandText = @"INSERT INTO Classroom(ClassID,ClassName,TeacherID, StudentCount, EquipmentID)" + "" +
               "VALUES(@clsID,@clsName,@eID,@stuCount,@equipID); ";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@clsID", classId);
            DatabaseConnection.com.Parameters.AddWithValue("@clsName", className);
            DatabaseConnection.com.Parameters.AddWithValue("@eID", tId);
            DatabaseConnection.com.Parameters.AddWithValue("@stuCount", StudentCount);
            DatabaseConnection.com.Parameters.AddWithValue("@equipID", equipId);

            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Class is added.");
            }

        }
        static public void UpdateData(string classId, string className, string tId, string equipId, int StudentCount)
        {
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();


            string CommandText = @"Update Classroom set ClassName=  @clsName,TeacherID= @tID, StudentCount= @stuCount WHERE ClassID = @clsID";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);     
            DatabaseConnection.com.Parameters.AddWithValue("@clsName", className);
            DatabaseConnection.com.Parameters.AddWithValue("@tID", tId);
            DatabaseConnection.com.Parameters.AddWithValue("@stuCount", StudentCount);
            DatabaseConnection.com.Parameters.AddWithValue("@equipID", equipId);
            DatabaseConnection.com.Parameters.AddWithValue("@clsID", classId);

            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Class is updated.");
            }

        }
        static public void DeleteData(string id) {


            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();

            string CommandText = @"Delete from Classroom Where ClassID= @id";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Class is deleted");
            }

        }
        static public List<Classroom> SearchData(string id)
        {
            List<Classroom> classes = new List<Classroom>();
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();
           
            string CommandText = "SELECT* FROM Classroom where ClassID = @id";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@id", int.Parse(id));

            DatabaseConnection.sqlDataReader = DatabaseConnection.com.ExecuteReader();
            while (DatabaseConnection.sqlDataReader.Read())
            {
                Classroom cls = new Classroom();

                cls.ClassId = DatabaseConnection.sqlDataReader[0].ToString();
                cls.ClassName = (DatabaseConnection.sqlDataReader[1] ?? null).ToString();
                cls.TeacherId = (DatabaseConnection.sqlDataReader[2] ?? null).ToString();
                cls.StudentCount = DatabaseConnection.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[3]));
                cls.EquipmentId = (DatabaseConnection.sqlDataReader[4] ?? null).ToString();

                classes.Add(cls);

            }
            return classes;
        }
    }
}
