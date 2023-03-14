using SchoolManagementSystem.controller;
using SchoolManagementSystem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.form
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
            passwordTxtBox.PasswordChar = '*';
            confpasswordTxtbox.PasswordChar = '*';

        }
        AdministratorController administratorController = new AdministratorController();
        private void resetBtn_Click(object sender, EventArgs e)
        {
            if(passwordTxtBox.Text == confpasswordTxtbox.Text)
            administratorController.Reset(userNameTxtbox.Text, emailTxtbox.Text, passwordTxtBox.Text);
            else
            {
                MessageBox.Show("Password is not match");
            }

        }
    }
}
