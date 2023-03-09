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

         static DatabaseConnection dataBaseConnection = DatabaseConnection.uniqueDBConnection;
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
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            String sql = "SELECT * FROM LabEquipments";
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                LabEquipments item = new LabEquipments();

                item.EquipmentId = dataBaseConnection.sqlDataReader[0].ToString();   
                item.Cost = dataBaseConnection.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[1]));
                item.EquipmentName = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                item.EquipmentCount = dataBaseConnection.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[3]));
                items.Add(item);

            }
            return items;
        }
        static public void InsertData(string equipId, string equipName, double cost, int equipCount)
        {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"INSERT INTO LabEquipments(EquipmentID, Cost,EquipmentName,EquipmentCount)" + "" +
               "VALUES(@equipID,@cost,@equipName,@equipCount); ";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@equipID", equipId);
            dataBaseConnection.com.Parameters.AddWithValue("@cost", cost);
            dataBaseConnection.com.Parameters.AddWithValue("@equipName", equipName);
            dataBaseConnection.com.Parameters.AddWithValue("@equipCount", equipCount);


            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab Equipments is added.");
            }

        }
        static public void UpdateData(string equipId, double cost,string equipName, int equipCount)
        {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"Update LabEquipments Set  Cost= @cost, EquipmentName= @equipName, EquipmentCount= @equipCount Where EquipmentID= @equipID";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@cost", cost);
            dataBaseConnection.com.Parameters.AddWithValue("@equipName", equipName);
            dataBaseConnection.com.Parameters.AddWithValue("@equipCount", equipCount);
            dataBaseConnection.com.Parameters.AddWithValue("@equipID", equipId);

            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab Equipments is updated.");
            }


        }
        static public void DeleteData(string id)
        {

            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            string CommandText = @"Delete from LabEquipments Where EquipmentID= @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Lab Equipments is deleted");
            }
        }
        static public List<LabEquipments> SearchData(string id)
        {
            List<LabEquipments> items = new List<LabEquipments>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            String sql = "SELECT * FROM LabEquipments Where EquipmentID = @id";
            dataBaseConnection.com.Parameters.AddWithValue("@id", id);
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
               
                LabEquipments item = new LabEquipments();

                item.EquipmentId = dataBaseConnection.sqlDataReader[0].ToString();
                item.Cost = dataBaseConnection.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[2]));
                item.EquipmentName = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                item.EquipmentCount = dataBaseConnection.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(dataBaseConnection.sqlDataReader[3]));
                items.Add(item);

            }
            return items;
        }
    }
}
