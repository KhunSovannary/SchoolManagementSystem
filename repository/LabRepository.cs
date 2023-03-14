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
    public class LabRepository:Repository<Lab>
    {
       public override List<Lab> Read()
        {
            List<Lab> labs = new List<Lab>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            String sql = "SELECT * FROM Lab";
            dbCon.com = new SqlCommand(sql, dbCon.con);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();
            while (dbCon.sqlDataReader.Read())
            {
                Lab lab = new Lab();

                lab.LabId = dbCon.sqlDataReader[0].ToString();
                lab.LabName = (dbCon.sqlDataReader[1] ?? null).ToString();
                lab.EquipmentId = (dbCon.sqlDataReader[2] ?? null).ToString();


                labs.Add(lab);

            }
            return labs;
        }
       public override void Create(Lab l)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"INSERT INTO Lab(LabID,LabName, EquipmentID)" + "" +
               "VALUES(@labID,@labName,@equipID); ";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@labID", l.LabId);
            dbCon.com.Parameters.AddWithValue("@labName",l. LabName) ;
            dbCon.com.Parameters.AddWithValue("@equipID", l.EquipmentId);

            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab is added.");
            }


        }
       public override void Update(Lab l)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = @"update Lab set  LabName = @labName, EquipmentID = @equipID " +
            "Where LabID= @id";

            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@labName", l.LabName);
            dbCon.com.Parameters.AddWithValue("@equipID", l.EquipmentId);
            dbCon.com.Parameters.AddWithValue("@id", l.LabId);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Lab is updated.");
            }
        }
        public override void Delete(string id)
        {
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();

            string CommandText = @"Delete from Lab Where LabID= @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", id);
            int i = dbCon.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Lab is deleted");
            }

        }
        public override List<Lab> ReadByID(string id)
        {

            List<Lab> labs = new List<Lab>();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            string CommandText = "SELECT* FROM Lab where LabID = @id";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@id", int.Parse(id));

            dbCon.sqlDataReader = dbCon.com.ExecuteReader();


            while (dbCon.sqlDataReader.Read())
            {
                Lab lab = new Lab();
                lab.LabId = dbCon.sqlDataReader[0].ToString();
                lab.LabName = (string)dbCon.sqlDataReader[1];
                lab.EquipmentId = dbCon.sqlDataReader[2].ToString();
                labs.Add(lab);



            }
            return labs;

        }
    }
}
