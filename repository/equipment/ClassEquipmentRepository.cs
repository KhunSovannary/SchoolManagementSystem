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
    class ClassEquipmentRepository:Repository<ClassEquipments>
    {
        public override List<ClassEquipments> Read()
        {
            List<ClassEquipments> items = new List<ClassEquipments>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            String sql = "SELECT * FROM ClassEquipments";
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                ClassEquipments item = new ClassEquipments();

                item.EquipmentId = dbCon.sqlDataReader[0].ToString();
                item.Cost = dbCon.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(dbCon.sqlDataReader[1]));
                item.ClassId = (dbCon.sqlDataReader[2] ?? null).ToString();
                item.ChairCount = dbCon.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(dbCon.sqlDataReader[3]));
                item.FanCount = dbCon.sqlDataReader[4] is DBNull ? 0 : int.Parse(Convert.ToString(dbCon.sqlDataReader[4]));
                item.LightCount = dbCon.sqlDataReader[5] is DBNull ? 0 : int.Parse(Convert.ToString(dbCon.sqlDataReader[5]));
                items.Add(item);

            }
            return items;
        }
        public override void Create(ClassEquipments clEquip)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"INSERT INTO ClassEquipments(EquipmentID, Cost,ClassID,BenchCount,FanCount,LightCount)" + "" +
               "VALUES(@equipID,@cost,@cID,@bCount,@fCount,@lCount); ";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@equipID", clEquip.EquipmentId);
            dbCon.com.Parameters.AddWithValue("@cost", clEquip.Cost);
            dbCon.com.Parameters.AddWithValue("@cID", clEquip.ClassId);
            dbCon.com.Parameters.AddWithValue("@bCount", clEquip.ChairCount);
            dbCon.com.Parameters.AddWithValue("@fCount", clEquip.FanCount);
            dbCon.com.Parameters.AddWithValue("@lCount", clEquip.LightCount);


            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab Equipments is added.");
            }

        }
        public override void Update(ClassEquipments clEquip)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"Update ClassEquipments Set  Cost= @cost, ClassID= @cID, BenchCount= @bCount, FanCount= @fCount, LightCount= @lCount Where EquipmentID= @equipID";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@equipID", clEquip.EquipmentId);
            dbCon.com.Parameters.AddWithValue("@cost", clEquip.Cost);
            dbCon.com.Parameters.AddWithValue("@cID", clEquip.ClassId);
            dbCon.com.Parameters.AddWithValue("@bCount", clEquip.ChairCount);
            dbCon.com.Parameters.AddWithValue("@fCount", clEquip.FanCount);
            dbCon.com.Parameters.AddWithValue("@lCount", clEquip.LightCount);

            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Class Equipments is updated.");
            }


        }
        public override void Delete(string id)
        {

            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = @"Delete from ClassEquipments Where EquipmentID= @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", id);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Class Equipments is deleted");
            }
        }
        public override List<ClassEquipments> ReadByID(string id)
        {
            List<ClassEquipments> items = new List<ClassEquipments>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            String sql = "SELECT * FROM ClassEquipments Where EquipmentID = @id";
            dbCon.com.Parameters.AddWithValue("@id", id);
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                ClassEquipments item = new ClassEquipments();

                item.EquipmentId = dbCon.sqlDataReader[0].ToString();
                item.Cost = dbCon.sqlDataReader[1] is DBNull ? 0 : double.Parse(Convert.ToString(dbCon.sqlDataReader[1]));
                item.ClassId = (dbCon.sqlDataReader[2] ?? null).ToString();
                item.ChairCount = dbCon.sqlDataReader[3] is DBNull ? 0 : int.Parse(Convert.ToString(dbCon.sqlDataReader[3]));
                item.FanCount = dbCon.sqlDataReader[4] is DBNull ? 0 : int.Parse(Convert.ToString(dbCon.sqlDataReader[4]));
                item.LightCount = dbCon.sqlDataReader[5] is DBNull ? 0 : int.Parse(Convert.ToString(dbCon.sqlDataReader[5]));
                items.Add(item);

            }
            return items;
        }

    }
}
