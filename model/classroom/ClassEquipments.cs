using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class ClassEquipments: Equipment
    {
   static DatabaseConnection DatabaseConnection = DatabaseConnection.uniqueDatabaseConnection;
        private string class_id; private int chairCount, fanCount, lightCount;
        public string ClassId
        {
            get { return class_id; }
            set { class_id = value; }
        }
        public int ChairCount
        {
            get { return chairCount; }
            set { chairCount = value; }
        }
        public int FanCount
        {
            get { return fanCount; }
            set { fanCount = value; }
        }
        public int LightCount
        {
            get { return lightCount; }
            set { lightCount = value; }
        }
        public ClassEquipments()
        {

        }
        public ClassEquipments(string eId, double cost, string cId, int cCount, int fCount, int lCount) : base(eId, cost)
        {
            chairCount = cCount;
            class_id = cId;
            fanCount = fCount;
            lightCount = lCount;

        }
       
        public ClassEquipments Clone()
        {
            return new ClassEquipments(EquipmentId, Cost, ClassId,ChairCount, FanCount,LightCount);
        }
        static public List<ClassEquipments> ReadData()
        {
            List<ClassEquipments> items = new List<ClassEquipments>();
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();
            String sql = "SELECT * FROM ClassEquipments";
            DatabaseConnection.com = new SqlCommand(sql, DatabaseConnection.con);
            DatabaseConnection.sqlDataReader = DatabaseConnection.com.ExecuteReader();
            while (DatabaseConnection.sqlDataReader.Read())
            {
                ClassEquipments item = new ClassEquipments();

                item.EquipmentId = DatabaseConnection.sqlDataReader[0].ToString();
                item.Cost = DatabaseConnection.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[1]));
                item.ClassId = (DatabaseConnection.sqlDataReader[2] ?? null).ToString();
                item.ChairCount = DatabaseConnection.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[3]));
                item.FanCount = DatabaseConnection.sqlDataReader[4] is DBNull ? 0 : int.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[4]));
                item.LightCount = DatabaseConnection.sqlDataReader[5] is DBNull ? 0 : int.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[5]));
                items.Add(item);

            }
            return items;
        }
        static public void InsertData(string equipId, double cost, string cId, int cCount, int fCount, int lCount)
        {
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();


            string CommandText = @"INSERT INTO ClassEquipments(EquipmentID, Cost,ClassID,BenchCount,FanCount,LightCount)" + "" +
               "VALUES(@equipID,@cost,@cID,@bCount,@fCount,@lCount); ";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@equipID", equipId);
            DatabaseConnection.com.Parameters.AddWithValue("@cost", cost);
            DatabaseConnection.com.Parameters.AddWithValue("@cID", cId);
            DatabaseConnection.com.Parameters.AddWithValue("@bCount", cCount);
            DatabaseConnection.com.Parameters.AddWithValue("@fCount", fCount);
            DatabaseConnection.com.Parameters.AddWithValue("@lCount", lCount);


            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab Equipments is added.");
            }

        }
        static public void UpdateData(string equipId, double cost, string cId, int cCount, int fCount, int lCount)
        {
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();


            string CommandText = @"Update ClassEquipments Set  Cost= @cost, ClassID= @cID, BenchCount= @bCount, FanCount= @fCount, LightCount= @lCount Where EquipmentID= @equipID";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@equipID", equipId);
            DatabaseConnection.com.Parameters.AddWithValue("@cost", cost);
            DatabaseConnection.com.Parameters.AddWithValue("@cID", cId);
            DatabaseConnection.com.Parameters.AddWithValue("@bCount", cCount);
            DatabaseConnection.com.Parameters.AddWithValue("@fCount", fCount);
            DatabaseConnection.com.Parameters.AddWithValue("@lCount", lCount);

            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Class Equipments is updated.");
            }


        }
        static public void DeleteData(string id)
        {

            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();

            string CommandText = @"Delete from ClassEquipments Where EquipmentID= @id";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Class Equipments is deleted");
            }
        }
        static public List<ClassEquipments> SearchData(string id)
        {
            List<ClassEquipments> items = new List<ClassEquipments>();
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();

            String sql = "SELECT * FROM ClassEquipments Where EquipmentID = @id";
            DatabaseConnection.com.Parameters.AddWithValue("@id", id);
            DatabaseConnection.com = new SqlCommand(sql, DatabaseConnection.con);
            DatabaseConnection.sqlDataReader = DatabaseConnection.com.ExecuteReader();
            while (DatabaseConnection.sqlDataReader.Read())
            {
                ClassEquipments item = new ClassEquipments();

                item.EquipmentId = DatabaseConnection.sqlDataReader[0].ToString();
                item.Cost = DatabaseConnection.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[1]));
                item.ClassId = (DatabaseConnection.sqlDataReader[2] ?? null).ToString();
                item.ChairCount = DatabaseConnection.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[3]));
                item.FanCount = DatabaseConnection.sqlDataReader[4] is DBNull ? 0 : int.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[4]));
                item.LightCount = DatabaseConnection.sqlDataReader[5] is DBNull ? 0 : int.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[5]));
                items.Add(item);

            }
            return items;
        }

    }
    }





