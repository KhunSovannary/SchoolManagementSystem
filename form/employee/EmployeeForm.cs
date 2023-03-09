using SchoolManagementSystem.form.employee.supportstaff;
using SchoolManagementSystem.form.employee.teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.form.employee
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            TeacherDetailForm teacherDetailForm = new TeacherDetailForm();
            teacherDetailForm.ShowDialog(this);
        }

        private void supportStaffBtn_Click(object sender, EventArgs e)
        {
            SupportStaffDetailForm supportStaffDetailForm = new SupportStaffDetailForm();
            supportStaffDetailForm.ShowDialog(this);
        }
    }
}
