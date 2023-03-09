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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordTxtbox.PasswordChar ='*';
        }


    
       static DataTable dt;
        private void loginBtn_Click(object sender, EventArgs e)
        { 
            if (userNameTxtbox.Text.Trim() =="" || passwordTxtbox.Text.Trim()== "")
            {
                MessageBox.Show("Please complete the info");
            }
            else
            {
                UserModel user = new UserModel();
                
                user  = UserModel.CheckUser(userNameTxtbox.Text,passwordTxtbox.Text);
                if (userNameTxtbox.Text==user.userName && passwordTxtbox.Text == user.password)
                {
                    DashBoardForm dashBoardForm = new DashBoardForm();
                    this.Hide();
                    dashBoardForm.ShowDialog(this);
              }
              
                else MessageBox.Show("No User");
            }
           
           

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void resetPasswordBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            resetPasswordForm.ShowDialog(this);
        }

        private void signUpBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            //this.Hide();
            registerForm.ShowDialog(this);
        }
    }
}
