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
    class ClassroomRepository: Repository<Classroom>
    {
        public override List<Classroom> Read()
        {
            List<Classroom> classes = new List<Classroom>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            String sql = "SELECT * FROM Classroom";
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                Classroom cls = new Classroom();
                cls.ClassId = dbCon.sqlDataReader[0].ToString();
                cls.ClassName = (dbCon.sqlDataReader[1] ?? null).ToString();
                cls.StudentCount = dbCon.sqlDataReader[2] is DBNull ? 0 : int.Parse(Convert.ToString(dbCon.sqlDataReader[2]));
                cls.TeacherId = (dbCon.sqlDataReader[3] ?? null).ToString();
                cls.EquipmentId = (dbCon.sqlDataReader[4] ?? null).ToString();
                classes.Add(cls);

            }
            return classes;
        }
        public override void Create(Classroom c)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            string CommandText = @"INSERT INTO Classroom(ClassID,ClassName,TeacherID, StudentCount, EquipmentID)" + "" +
               "VALUES(@clsID,@clsName,@eID,@stuCount,@equipID); ";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@clsID", c.ClassId);
            dbCon.com.Parameters.AddWithValue("@clsName",c.ClassName);
            dbCon.com.Parameters.AddWithValue("@eID", c.TeacherId);
            dbCon.com.Parameters.AddWithValue("@stuCount", c.StudentCount);
            dbCon.com.Parameters.AddWithValue("@equipID", c.EquipmentId);

            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Class is added.");
            }

        }
        public override void Update(Classroom c)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"Update Classroom set ClassName=  @clsName,TeacherID= @tID, StudentCount= @stuCount WHERE ClassID = @clsID";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@clsName", c.ClassName);
            dbCon.com.Parameters.AddWithValue("@tID", c.TeacherId);
            dbCon.com.Parameters.AddWithValue("@stuCount", c.StudentCount);
            dbCon.com.Parameters.AddWithValue("@equipID", c.EquipmentId);
            dbCon.com.Parameters.AddWithValue("@clsID",c.ClassId);

            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Class is updated.");
            }

        }
        public override void Delete(string id)
        {


            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = @"Delete from Classroom Where ClassID= @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", id);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Class is deleted");
            }

        }
        public override List<Classroom> ReadByID(string id)
        {
            List<Classroom> classes = new List<Classroom>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = "SELECT* FROM Classroom where ClassID = @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", int.Parse(id));

            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                Classroom cls = new Classroom();

                cls.ClassId = dbCon.sqlDataReader[0].ToString();
                cls.ClassName = (dbCon.sqlDataReader[1] ?? null).ToString();
                cls.TeacherId = (dbCon.sqlDataReader[2] ?? null).ToString();
                cls.StudentCount = dbCon.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(dbCon.sqlDataReader[3]));
                cls.EquipmentId = (dbCon.sqlDataReader[4] ?? null).ToString();

                classes.Add(cls);

            }
            return classes;
        }
    }
}
