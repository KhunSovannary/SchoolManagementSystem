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
    class AdministratorRepository

    {
        static DatabaseConnection dbCon = DatabaseConnection.uniqueDatabaseConnection;
      public Administrator CheckUser(string user, string pwd)
        {
            Administrator user1 = new Administrator();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            string CommandText = "SELECT* FROM UserModel where UserName LIKE  @userNameTextbox AND Password LIKE  @passwordTextbox";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@userNameTextbox", user);
            dbCon.com.Parameters.AddWithValue("@passwordTextbox", pwd);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();


            while (dbCon.sqlDataReader.Read())
            {

                user1.userID = dbCon.sqlDataReader[0].ToString();
                user1.userName = (dbCon.sqlDataReader[1] ?? null).ToString();
                user1.password = (dbCon.sqlDataReader[2] ?? null).ToString();
                user1.email = (dbCon.sqlDataReader[3] ?? null).ToString();
            }
            return user1;
        }
      public void CreateUser(Administrator a)
        {


            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();


            string CommandText = @"INSERT INTO UserModel(userID,userName,password,email) VALUES(@ID,@Username,@Password,@Email); ";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@ID", int.Parse(a.userID));
            dbCon.com.Parameters.AddWithValue("@Username", a.userName);
            dbCon.com.Parameters.AddWithValue("@Password", a.password);
            dbCon.com.Parameters.AddWithValue("@Email",a.email);
            int i = dbCon.com.ExecuteNonQuery();

            if (i == 1)
            {
                MessageBox.Show("Success");
            }
        }
      public void ResetUser(string user, string email, string pwd)
        {
            Administrator user1 = new Administrator();
            dbCon.con = new SqlConnection(dbCon.conStr);
            dbCon.con.Open();
            string CommandText = "SELECT* FROM UserModel where UserName LIKE  @userName AND Email LIKE  @email";
            dbCon.com = new SqlCommand(CommandText, dbCon.con);
            dbCon.com.Parameters.AddWithValue("@userName", user);
            dbCon.com.Parameters.AddWithValue("@email", email);
            dbCon.sqlDataReader = dbCon.com.ExecuteReader();


            while (dbCon.sqlDataReader.Read())
            {

                user1.userID = dbCon.sqlDataReader[0].ToString();
                user1.userName = (dbCon.sqlDataReader[1] ?? null).ToString();
                user1.password = (dbCon.sqlDataReader[2] ?? null).ToString();
                user1.email = (dbCon.sqlDataReader[3] ?? null).ToString();





            }
            dbCon.sqlDataReader.Close(); // <- too easy to forget
            dbCon.sqlDataReader.Dispose(); // <- too easy to forget

            if (user1.userName == user && user1.email == email)
            {


                CommandText = "UPDATE UserModel set Password = @pwd WHERE UserName LIKE @user and Email LIKE @email";
                dbCon.com = new SqlCommand(CommandText, dbCon.con);
                dbCon.com.Parameters.AddWithValue("@pwd", pwd);
                dbCon.com.Parameters.AddWithValue("@user", user);
                dbCon.com.Parameters.AddWithValue("@email", email);

                int i = dbCon.com.ExecuteNonQuery();
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
