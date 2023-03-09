using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class Classroom
    {
   static DatabaseConnection dataBaseConnection = DatabaseConnection.uniqueDBConnection;
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
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            String sql = "SELECT * FROM Classroom";
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                Classroom cls = new Classroom();
                cls.ClassId = dataBaseConnection.sqlDataReader[0].ToString();
                cls.ClassName = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();            
                cls.StudentCount = dataBaseConnection.sqlDataReader[2] is DBNull ? 0 : int.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[2]));
                cls.TeacherId = (dataBaseConnection.sqlDataReader[3] ?? null).ToString();
                cls.EquipmentId = (dataBaseConnection.sqlDataReader[4] ?? null).ToString();
                classes.Add(cls);

            }
            return classes;
        }
        static public void InsertData(string classId, string className, string tId, string equipId, int StudentCount) {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            string CommandText = @"INSERT INTO Classroom(ClassID,ClassName,TeacherID, StudentCount, EquipmentID)" + "" +
               "VALUES(@clsID,@clsName,@eID,@stuCount,@equipID); ";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@clsID", classId);
            dataBaseConnection.com.Parameters.AddWithValue("@clsName", className);
            dataBaseConnection.com.Parameters.AddWithValue("@eID", tId);
            dataBaseConnection.com.Parameters.AddWithValue("@stuCount", StudentCount);
            dataBaseConnection.com.Parameters.AddWithValue("@equipID", equipId);

            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Class is added.");
            }

        }
        static public void UpdateData(string classId, string className, string tId, string equipId, int StudentCount)
        {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"Update Classroom set ClassName=  @clsName,TeacherID= @tID, StudentCount= @stuCount WHERE ClassID = @clsID";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);     
            dataBaseConnection.com.Parameters.AddWithValue("@clsName", className);
            dataBaseConnection.com.Parameters.AddWithValue("@tID", tId);
            dataBaseConnection.com.Parameters.AddWithValue("@stuCount", StudentCount);
            dataBaseConnection.com.Parameters.AddWithValue("@equipID", equipId);
            dataBaseConnection.com.Parameters.AddWithValue("@clsID", classId);

            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Class is updated.");
            }

        }
        static public void DeleteData(string id) {


            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            string CommandText = @"Delete from Classroom Where ClassID= @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Class is deleted");
            }

        }
        static public List<Classroom> SearchData(string id)
        {
            List<Classroom> classes = new List<Classroom>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
           
            string CommandText = "SELECT* FROM Classroom where ClassID = @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", int.Parse(id));

            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                Classroom cls = new Classroom();

                cls.ClassId = dataBaseConnection.sqlDataReader[0].ToString();
                cls.ClassName = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                cls.TeacherId = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                cls.StudentCount = dataBaseConnection.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[3]));
                cls.EquipmentId = (dataBaseConnection.sqlDataReader[4] ?? null).ToString();

                classes.Add(cls);

            }
            return classes;
        }
    }
}
