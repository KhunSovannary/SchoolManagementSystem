using SchoolManagementSystem.form.department;
using SchoolManagementSystem.form.employee;
using SchoolManagementSystem.form.equipment;
using SchoolManagementSystem.form.lab;
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
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void stuBtn_Click(object sender, EventArgs e)
        {
            StudentRecordForm studentRecordForm = new StudentRecordForm();
            studentRecordForm.ShowDialog(this);
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog(this);
        }

        

        private void classBtn_Click(object sender, EventArgs e)
        {
            ClassDetailForm classDetailForm = new ClassDetailForm();
            classDetailForm.ShowDialog(this);
        }

        

        private void exitBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog(this);

        }

       
       

        private void equipBtn_Click(object sender, EventArgs e)
        {
            EquipmentForm equipmentForm = new EquipmentForm();
            equipmentForm.ShowDialog(this);
        }

        private void departmentBtn_Click(object sender, EventArgs e)
        {
            DepartmentDetailForm departmentDetailForm = new DepartmentDetailForm();
            departmentDetailForm.ShowDialog(this);
        }

       
        private void labBtn_Click(object sender, EventArgs e)
        {
            LabDetailForm labDetailForm = new LabDetailForm();
            labDetailForm.ShowDialog(this);
        }

       

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
