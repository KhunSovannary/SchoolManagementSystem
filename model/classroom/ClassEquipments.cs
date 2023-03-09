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
   static DatabaseConnection dataBaseConnection = DatabaseConnection.uniqueDBConnection;
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
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            String sql = "SELECT * FROM ClassEquipments";
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                ClassEquipments item = new ClassEquipments();

                item.EquipmentId = dataBaseConnection.sqlDataReader[0].ToString();
                item.Cost = dataBaseConnection.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[1]));
                item.ClassId = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                item.ChairCount = dataBaseConnection.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[3]));
                item.FanCount = dataBaseConnection.sqlDataReader[4] is DBNull ? 0 : int.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[4]));
                item.LightCount = dataBaseConnection.sqlDataReader[5] is DBNull ? 0 : int.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[5]));
                items.Add(item);

            }
            return items;
        }
        static public void InsertData(string equipId, double cost, string cId, int cCount, int fCount, int lCount)
        {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"INSERT INTO ClassEquipments(EquipmentID, Cost,ClassID,BenchCount,FanCount,LightCount)" + "" +
               "VALUES(@equipID,@cost,@cID,@bCount,@fCount,@lCount); ";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@equipID", equipId);
            dataBaseConnection.com.Parameters.AddWithValue("@cost", cost);
            dataBaseConnection.com.Parameters.AddWithValue("@cID", cId);
            dataBaseConnection.com.Parameters.AddWithValue("@bCount", cCount);
            dataBaseConnection.com.Parameters.AddWithValue("@fCount", fCount);
            dataBaseConnection.com.Parameters.AddWithValue("@lCount", lCount);


            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab Equipments is added.");
            }

        }
        static public void UpdateData(string equipId, double cost, string cId, int cCount, int fCount, int lCount)
        {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"Update ClassEquipments Set  Cost= @cost, ClassID= @cID, BenchCount= @bCount, FanCount= @fCount, LightCount= @lCount Where EquipmentID= @equipID";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@equipID", equipId);
            dataBaseConnection.com.Parameters.AddWithValue("@cost", cost);
            dataBaseConnection.com.Parameters.AddWithValue("@cID", cId);
            dataBaseConnection.com.Parameters.AddWithValue("@bCount", cCount);
            dataBaseConnection.com.Parameters.AddWithValue("@fCount", fCount);
            dataBaseConnection.com.Parameters.AddWithValue("@lCount", lCount);

            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Class Equipments is updated.");
            }


        }
        static public void DeleteData(string id)
        {

            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            string CommandText = @"Delete from ClassEquipments Where EquipmentID= @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Class Equipments is deleted");
            }
        }
        static public List<ClassEquipments> SearchData(string id)
        {
            List<ClassEquipments> items = new List<ClassEquipments>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            String sql = "SELECT * FROM ClassEquipments Where EquipmentID = @id";
            dataBaseConnection.com.Parameters.AddWithValue("@id", id);
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                ClassEquipments item = new ClassEquipments();

                item.EquipmentId = dataBaseConnection.sqlDataReader[0].ToString();
                item.Cost = dataBaseConnection.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[1]));
                item.ClassId = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                item.ChairCount = dataBaseConnection.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[3]));
                item.FanCount = dataBaseConnection.sqlDataReader[4] is DBNull ? 0 : int.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[4]));
                item.LightCount = dataBaseConnection.sqlDataReader[5] is DBNull ? 0 : int.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[5]));
                items.Add(item);

            }
            return items;
        }

    }
    }





