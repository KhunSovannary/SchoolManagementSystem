using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class LabEquipments: Equipment
    {
        private string equipment_name; private int equipment_count;

         static DatabaseConnection DatabaseConnection = DatabaseConnection.uniqueDatabaseConnection;
        public string EquipmentName
        {
            get { return equipment_name; }
            set { equipment_name = value; }
        }
        public int EquipmentCount
        {
            get { return equipment_count; }
            set { equipment_count = value; }
        }
        public LabEquipments()
        {

        }
        public LabEquipments(string eId, double cost, string equipName, int equipCount):base(eId,cost)
        {
            EquipmentName = equipName;
            EquipmentCount = equipCount;
        }
        public LabEquipments Clone()
        {
            return new LabEquipments(EquipmentId, Cost, EquipmentName,EquipmentCount);
        }
        static public List<LabEquipments> ReadData()
        {
            List<LabEquipments> items = new List<LabEquipments>();
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();
            String sql = "SELECT * FROM LabEquipments";
            DatabaseConnection.com = new SqlCommand(sql, DatabaseConnection.con);
            DatabaseConnection.sqlDataReader = DatabaseConnection.com.ExecuteReader();
            while (DatabaseConnection.sqlDataReader.Read())
            {
                LabEquipments item = new LabEquipments();

                item.EquipmentId = DatabaseConnection.sqlDataReader[0].ToString();   
                item.Cost = DatabaseConnection.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[1]));
                item.EquipmentName = (DatabaseConnection.sqlDataReader[2] ?? null).ToString();
                item.EquipmentCount = DatabaseConnection.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[3]));
                items.Add(item);

            }
            return items;
        }
        static public void InsertData(string equipId, string equipName, double cost, int equipCount)
        {
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();


            string CommandText = @"INSERT INTO LabEquipments(EquipmentID, Cost,EquipmentName,EquipmentCount)" + "" +
               "VALUES(@equipID,@cost,@equipName,@equipCount); ";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@equipID", equipId);
            DatabaseConnection.com.Parameters.AddWithValue("@cost", cost);
            DatabaseConnection.com.Parameters.AddWithValue("@equipName", equipName);
            DatabaseConnection.com.Parameters.AddWithValue("@equipCount", equipCount);


            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab Equipments is added.");
            }

        }
        static public void UpdateData(string equipId, double cost,string equipName, int equipCount)
        {
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();


            string CommandText = @"Update LabEquipments Set  Cost= @cost, EquipmentName= @equipName, EquipmentCount= @equipCount Where EquipmentID= @equipID";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@cost", cost);
            DatabaseConnection.com.Parameters.AddWithValue("@equipName", equipName);
            DatabaseConnection.com.Parameters.AddWithValue("@equipCount", equipCount);
            DatabaseConnection.com.Parameters.AddWithValue("@equipID", equipId);

            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab Equipments is updated.");
            }


        }
        static public void DeleteData(string id)
        {

            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();

            string CommandText = @"Delete from LabEquipments Where EquipmentID= @id";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = DatabaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Lab Equipments is deleted");
            }
        }
        static public List<LabEquipments> SearchData(string id)
        {
            List<LabEquipments> items = new List<LabEquipments>();
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();

            String sql = "SELECT * FROM LabEquipments Where EquipmentID = @id";
            DatabaseConnection.com.Parameters.AddWithValue("@id", id);
            DatabaseConnection.com = new SqlCommand(sql, DatabaseConnection.con);
            DatabaseConnection.sqlDataReader = DatabaseConnection.com.ExecuteReader();
            while (DatabaseConnection.sqlDataReader.Read())
            {
               
                LabEquipments item = new LabEquipments();

                item.EquipmentId = DatabaseConnection.sqlDataReader[0].ToString();
                item.Cost = DatabaseConnection.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[2]));
                item.EquipmentName = (DatabaseConnection.sqlDataReader[2] ?? null).ToString();
                item.EquipmentCount = DatabaseConnection.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(DatabaseConnection.sqlDataReader[3]));
                items.Add(item);

            }
            return items;
        }
    }
}
