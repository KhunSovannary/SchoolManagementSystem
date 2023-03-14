using SchoolManagementSystem.controller.employee;
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

namespace SchoolManagementSystem.form.employee.teacher
{
    public partial class TeacherDetailForm : Form
    {
        public TeacherDetailForm()
        {
            InitializeComponent();
        }

        private void AddNewTeacher_Click(object sender, EventArgs e)
        {
            TeacherAddEditForm frmAdd = new TeacherAddEditForm("Add Teacher Form", TeacherAddEditForm.Operation.OP_ADD, bs);
            frmAdd.ShowDialog(this);
        }

        private void UpdateTeacher_Click(object sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                return;
            }
            TeacherAddEditForm frmEdit = new TeacherAddEditForm("Edit Teacher Form", TeacherAddEditForm.Operation.OP_EDIT, bs);
            frmEdit.ShowDialog(this);
        }
        static List<Teacher> teachers = new List<Teacher>();
        static BindingSource bs;
        TeacherController teacherController = new TeacherController();
        private void TeacherDetailForm_Load(object sender, EventArgs e)
        {
            teachers = teacherController.GetData();
            bs = new BindingSource(teachers, null);
            dgvTeacher.DataSource = bs;

            var colId = dgvTeacher.Columns["Id"];
            colId.DisplayIndex = 0; colId.HeaderText = "Teacher ID";

          var colName = dgvTeacher.Columns["Name"];
            colName.DisplayIndex = 1; colName.HeaderText = "Teacher Name";

            var colGender = dgvTeacher.Columns["Gender"];
            colGender.DisplayIndex = 2; colGender.HeaderText = "Gender";

            var colDob = dgvTeacher.Columns["Dob"];
            colDob.DisplayIndex = 3; colDob.HeaderText = "DOB";

            var colphone = dgvTeacher.Columns["PhoneNumber"];
            colphone.DisplayIndex = 4; colphone.HeaderText = "Teacher Phone Number";

            var colAddress = dgvTeacher.Columns["Address"];
            colAddress.DisplayIndex = 5; colAddress.HeaderText = "Address";

            var colSalary = dgvTeacher.Columns["Salary"];
            colSalary.DisplayIndex = 6; colSalary.HeaderText = "Salary";

            var colDepID = dgvTeacher.Columns["DepartmentId"];
            colDepID.DisplayIndex = 7; colDepID.HeaderText = "Department ID";

        

            var colPhoto = (DataGridViewImageColumn)dgvTeacher.Columns["Photo"];

            colPhoto.DefaultCellStyle.NullValue = null;
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.DisplayIndex = 8; colPhoto.HeaderText = "Photo";

            dgvTeacher.RowTemplate.Height = 50;
            dgvTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dgvTeacher.AllowUserToAddRows = false;
            dgvTeacher.ReadOnly = true;
            bs.ResetBindings(true);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Teacher t = new Teacher();
                t = (Teacher)bs.Current;
                bs.RemoveCurrent();
                teacherController.Delete(t.Id);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
          
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bs.Clear();
            bs = new BindingSource(teacherController.GetDataByID(searchTxtBox.Text), null);
            dgvTeacher.DataSource = bs;
        }
    }
}
