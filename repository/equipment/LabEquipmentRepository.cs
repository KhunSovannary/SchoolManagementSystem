using SchoolManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.repository.equipment
{
    class LabEquipmentRepository:Repository<LabEquipments>
    {
        public override void Create(LabEquipments labEquip) {
            
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"INSERT INTO LabEquipments(EquipmentID, Cost,EquipmentName,EquipmentCount)" + "" +
               "VALUES(@equipID,@cost,@equipName,@equipCount); ";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@equipID", labEquip.EquipmentId);
            dbCon.com.Parameters.AddWithValue("@cost", labEquip.Cost);
            dbCon.com.Parameters.AddWithValue("@equipName", labEquip.EquipmentName);
            dbCon.com.Parameters.AddWithValue("@equipCount", labEquip.EquipmentCount);


            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab Equipments is added.");
            }

        }
        public override List<LabEquipments> Read() {
            List<LabEquipments> items = new List<LabEquipments>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            String sql = "SELECT * FROM LabEquipments";
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                LabEquipments item = new LabEquipments();

                item.EquipmentId = dbCon.sqlDataReader[0].ToString();
                item.Cost = dbCon.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(dbCon.sqlDataReader[1]));
                item.EquipmentName = (dbCon.sqlDataReader[2] ?? null).ToString();
                item.EquipmentCount = dbCon.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(dbCon.sqlDataReader[3]));
                items.Add(item);

            }
            return items;
        }
        public override List<LabEquipments> ReadByID(string id) {
            List<LabEquipments> items = new List<LabEquipments>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            String sql = "SELECT * FROM LabEquipments Where EquipmentID = @id";
            dbCon.com.Parameters.AddWithValue("@id", id);
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {

                LabEquipments item = new LabEquipments();

                item.EquipmentId = dbCon.sqlDataReader[0].ToString();
                item.Cost = dbCon.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(dbCon.sqlDataReader[2]));
                item.EquipmentName = (dbCon.sqlDataReader[2] ?? null).ToString();
                item.EquipmentCount = dbCon.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(dbCon.sqlDataReader[3]));
                items.Add(item);

            }
            return items;
        }
        public override void Update(LabEquipments labEquip)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"Update LabEquipments Set  Cost= @cost, EquipmentName= @equipName, EquipmentCount= @equipCount Where EquipmentID= @equipID";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@cost", labEquip.Cost);
            dbCon.com.Parameters.AddWithValue("@equipName", labEquip.EquipmentName);
            dbCon.com.Parameters.AddWithValue("@equipCount", labEquip.EquipmentCount);
            dbCon.com.Parameters.AddWithValue("@equipID", labEquip.EquipmentId);

            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab Equipments is updated.");
            }


        }
        public override void Delete(string id) {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = @"Delete from LabEquipments Where EquipmentID= @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", id);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Lab Equipments is deleted");
            }
        }
        
      
    }
}
