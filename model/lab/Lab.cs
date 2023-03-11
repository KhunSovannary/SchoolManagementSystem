using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class Lab
    {
         static DatabaseConnection dataBaseConnection = DatabaseConnection.uniqueDatabaseConnection;
        private string lab_id, lab_name, equipment_id;
        public string LabId
        {
            get { return lab_id; }
            set { lab_id = value; }
        }

        public string LabName
        {
            get { return lab_name; }
            set { lab_name = value; }
        }
        public string EquipmentId
        {
            get { return equipment_id; }
            set { equipment_id = value; }
        }

        public Lab()
        {

        }
        public Lab(string labId,  string labName, string equipId)
        {
            LabId = labId;
            LabName = labName;
            EquipmentId = equipId;
        }

        public string LabDetails()
        {
            return "";

        }
        public bool IsOccupied()
        {
            return true;
        }

        public string PayFine()
        {
            return "";
        }
        public Lab Clone()
        {
            return new Lab(LabId,  LabName, EquipmentId);
        }
        static public List<Lab> ReadData() {
            List<Lab> labs = new List<Lab>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            String sql = "SELECT * FROM Lab";
            dataBaseConnection.com = new SqlCommand(sql, dataBaseConnection.con);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();
            while (dataBaseConnection.sqlDataReader.Read())
            {
                Lab lab = new Lab();

                lab.LabId = dataBaseConnection.sqlDataReader[0].ToString();
                lab.LabName = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                lab.EquipmentId = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();


                labs.Add(lab);
              
            }
            return labs;
        }
        static public void InsertData(string labId, string labName, string equipId) {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"INSERT INTO Lab(LabID,LabName, EquipmentID)" + "" +
               "VALUES(@labID,@labName,@equipID); ";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@labID", labId);
            dataBaseConnection.com.Parameters.AddWithValue("@labName", labName);
            dataBaseConnection.com.Parameters.AddWithValue("@equipID", equipId);

            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("New Lab is added.");
            }


        }
        static public void UpdateData(string labId,  string labName, string equipId) {
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            string CommandText = @"update Lab set  LabName = @labName, EquipmentID = @equipID " +
            "Where LabID= @id";
            
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);      
            dataBaseConnection.com.Parameters.AddWithValue("@labName", labName);
            dataBaseConnection.com.Parameters.AddWithValue("@equipID", equipId);
            dataBaseConnection.com.Parameters.AddWithValue("@id",labId);




            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Lab is updated.");
            }
        }
        static public void DeleteData(string id) {


            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();

            string CommandText = @"Delete from Lab Where LabID= @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", id);
            int i = dataBaseConnection.com.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Lab is deleted");
            }

        }
        public static List<Lab> SearchData(string id)
        {

            List<Lab> labs = new List<Lab>();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            string CommandText = "SELECT* FROM Lab where LabID = @id";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@id", int.Parse(id));

            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();


            while (dataBaseConnection.sqlDataReader.Read())
            {
                Lab lab = new Lab();
                lab.LabId = dataBaseConnection.sqlDataReader[0].ToString();
                lab.LabName = (string)dataBaseConnection.sqlDataReader[1];
                lab.EquipmentId = dataBaseConnection.sqlDataReader[2].ToString();
                labs.Add(lab);

                

            }
            return labs;

        }
    }
}
