using SchoolManagementSystem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.form
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            passwordTxtbox.PasswordChar = '*';
            cfpasswordTxtBox.PasswordChar = '*';
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (passwordTxtbox.Text == cfpasswordTxtBox.Text)
                UserModel.CreateUser(userIDTxtbox.Text, userNameTxtbox.Text, passwordTxtbox.Text, emailTxtbox.Text);
            else
            {
                MessageBox.Show("Password is not match");
            }
           
        }
       

       


      
    }
}
