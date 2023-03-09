using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.model
{
    class UserModel
    {
         static DatabaseConnection dataBaseConnection = DatabaseConnection.uniqueDBConnection;
        private string user_id, user_name, pwd, eml;
        public string userID {
            get { return user_id; }
            set { user_id = value; }
        }
        public string userName {
            get { return user_name; }
            set { user_name = value; }
}
        public string password
        {
            get { return pwd; }
            set { pwd = value; }
        }
        public string email
        {
            get { return eml; }
            set { eml = value; }
        }

        public UserModel() { }
        public UserModel(string uID, string uName, string e, string pwd)
        {
            user_id = uID;
            user_name = uName;
            this.pwd = pwd;
            eml = e;
        }

        static public UserModel CheckUser(string user, string pwd)
        {
            UserModel user1 = new UserModel();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            string CommandText = "SELECT* FROM UserModel where UserName LIKE  @userNameTextbox AND Password LIKE  @passwordTextbox";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@userNameTextbox", user);
            dataBaseConnection.com.Parameters.AddWithValue("@passwordTextbox", pwd);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();

            
            while (dataBaseConnection.sqlDataReader.Read())
            {

                user1.userID = dataBaseConnection.sqlDataReader[0].ToString();
                user1.userName = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                user1.password = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                user1.email = (dataBaseConnection.sqlDataReader[3] ?? null).ToString();





            }
            return user1;
        }
        static public void CreateUser(string userID, string userName, string pwd, string email)
        {
            

            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();


            string CommandText = @"INSERT INTO UserModel(userID,userName,password,email) VALUES(@ID,@Username,@Password,@Email); ";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@ID", int.Parse(userID));
            dataBaseConnection.com.Parameters.AddWithValue("@Username", userName);
            dataBaseConnection.com.Parameters.AddWithValue("@Password", pwd);
            dataBaseConnection.com.Parameters.AddWithValue("@Email", email);
            
        

            int i = dataBaseConnection.com.ExecuteNonQuery();
           
            if (i == 1)
            {
                MessageBox.Show("Success");
            }
        }
        static public void ResetUser(string user,string email, string pwd)
        {
            UserModel user1 = new UserModel();
            dataBaseConnection.con = new SqlConnection(dataBaseConnection.conStr);
            dataBaseConnection.con.Open();
            string CommandText = "SELECT* FROM UserModel where UserName LIKE  @userName AND Email LIKE  @email";
            dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
            dataBaseConnection.com.Parameters.AddWithValue("@userName", user);
            dataBaseConnection.com.Parameters.AddWithValue("@email", email);
            dataBaseConnection.sqlDataReader = dataBaseConnection.com.ExecuteReader();


            while (dataBaseConnection.sqlDataReader.Read())
            {

                user1.userID = dataBaseConnection.sqlDataReader[0].ToString();
                user1.userName = (dataBaseConnection.sqlDataReader[1] ?? null).ToString();
                user1.password = (dataBaseConnection.sqlDataReader[2] ?? null).ToString();
                user1.email = (dataBaseConnection.sqlDataReader[3] ?? null).ToString();





            }
            dataBaseConnection.sqlDataReader.Close(); // <- too easy to forget
            dataBaseConnection.sqlDataReader.Dispose(); // <- too easy to forget
  
            if (user1.userName == user && user1.email == email)
            {

                
                CommandText = "UPDATE UserModel set Password = @pwd WHERE UserName LIKE @user and Email LIKE @email";
                dataBaseConnection.com = new SqlCommand(CommandText, dataBaseConnection.con);
                dataBaseConnection.com.Parameters.AddWithValue("@pwd", pwd);
                dataBaseConnection.com.Parameters.AddWithValue("@user", user);
                dataBaseConnection.com.Parameters.AddWithValue("@email", email);
           
                int i = dataBaseConnection.com.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("User Password is updated.");
                }
            }
            else
                MessageBox.Show("User is not found");
           
        }
    }
}
