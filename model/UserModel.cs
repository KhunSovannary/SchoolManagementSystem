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
         static DatabaseConnection DatabaseConnection = DatabaseConnection.uniqueDatabaseConnection;
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
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();
            string CommandText = "SELECT* FROM UserModel where UserName LIKE  @userNameTextbox AND Password LIKE  @passwordTextbox";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@userNameTextbox", user);
            DatabaseConnection.com.Parameters.AddWithValue("@passwordTextbox", pwd);
            DatabaseConnection.sqlDataReader = DatabaseConnection.com.ExecuteReader();

            
            while (DatabaseConnection.sqlDataReader.Read())
            {

                user1.userID = DatabaseConnection.sqlDataReader[0].ToString();
                user1.userName = (DatabaseConnection.sqlDataReader[1] ?? null).ToString();
                user1.password = (DatabaseConnection.sqlDataReader[2] ?? null).ToString();
                user1.email = (DatabaseConnection.sqlDataReader[3] ?? null).ToString();





            }
            return user1;
        }
        static public void CreateUser(string userID, string userName, string pwd, string email)
        {
            

            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();


            string CommandText = @"INSERT INTO UserModel(userID,userName,password,email) VALUES(@ID,@Username,@Password,@Email); ";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@ID", int.Parse(userID));
            DatabaseConnection.com.Parameters.AddWithValue("@Username", userName);
            DatabaseConnection.com.Parameters.AddWithValue("@Password", pwd);
            DatabaseConnection.com.Parameters.AddWithValue("@Email", email);
            
        

            int i = DatabaseConnection.com.ExecuteNonQuery();
           
            if (i == 1)
            {
                MessageBox.Show("Success");
            }
        }
        static public void ResetUser(string user,string email, string pwd)
        {
            UserModel user1 = new UserModel();
            DatabaseConnection.con = new SqlConnection(DatabaseConnection.conStr);
            DatabaseConnection.con.Open();
            string CommandText = "SELECT* FROM UserModel where UserName LIKE  @userName AND Email LIKE  @email";
            DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
            DatabaseConnection.com.Parameters.AddWithValue("@userName", user);
            DatabaseConnection.com.Parameters.AddWithValue("@email", email);
            DatabaseConnection.sqlDataReader = DatabaseConnection.com.ExecuteReader();


            while (DatabaseConnection.sqlDataReader.Read())
            {

                user1.userID = DatabaseConnection.sqlDataReader[0].ToString();
                user1.userName = (DatabaseConnection.sqlDataReader[1] ?? null).ToString();
                user1.password = (DatabaseConnection.sqlDataReader[2] ?? null).ToString();
                user1.email = (DatabaseConnection.sqlDataReader[3] ?? null).ToString();





            }
            DatabaseConnection.sqlDataReader.Close(); // <- too easy to forget
            DatabaseConnection.sqlDataReader.Dispose(); // <- too easy to forget
  
            if (user1.userName == user && user1.email == email)
            {

                
                CommandText = "UPDATE UserModel set Password = @pwd WHERE UserName LIKE @user and Email LIKE @email";
                DatabaseConnection.com = new SqlCommand(CommandText, DatabaseConnection.con);
                DatabaseConnection.com.Parameters.AddWithValue("@pwd", pwd);
                DatabaseConnection.com.Parameters.AddWithValue("@user", user);
                DatabaseConnection.com.Parameters.AddWithValue("@email", email);
           
                int i = DatabaseConnection.com.ExecuteNonQuery();
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
