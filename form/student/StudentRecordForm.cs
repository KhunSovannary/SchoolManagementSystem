using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using SchoolManagementSystem.model;
using SchoolManagementSystem.form.student;
using System.Data.SqlClient;
using SchoolManagementSystem.controller;
using SchoolManagementSystem.model.student;

namespace SchoolManagementSystem
{
    public partial class StudentRecordForm : Form
    {
            
        public StudentRecordForm()
        {
           InitializeComponent();

            
        }
        static StudentController stuController = new StudentController();
       
         static List<Student> students = new List<Student>();
         static BindingSource bs;
        private void StudentRecordForm_Load(object sender, EventArgs e)
        {
            students= stuController.GetData();
            bs= new BindingSource(students, null);
            dgvStudentRecord.DataSource = bs;
            dgvStudentRecord.AutoGenerateColumns = false;
            LoadColumn();
            MessageBox.Show(dgvStudentRecord.Columns.ToString());
        }
         private void LoadColumn()
        {
            var colId = dgvStudentRecord.Columns["Id"];
            colId.DisplayIndex = 0; colId.HeaderText = "Student ID";

            var colName = dgvStudentRecord.Columns["Name"];
            colName.DisplayIndex = 1; colName.HeaderText = "Student Name";

            var colGender = dgvStudentRecord.Columns["Gender"];
            colGender.DisplayIndex = 2; colGender.HeaderText = "Gender";

            var colDob = dgvStudentRecord.Columns["Dob"];
            colDob.DisplayIndex = 3; colDob.HeaderText = "DOB";

            var colPhNum = dgvStudentRecord.Columns["PhoneNumber"];
            colPhNum.DisplayIndex = 4; colPhNum.HeaderText = "Phone Number";

            var colClass = dgvStudentRecord.Columns["ClassId"];
            colClass.DisplayIndex = 5; colClass.HeaderText = "Class ID";

            var colYear = dgvStudentRecord.Columns["Year"];
            colYear.DisplayIndex = 6; colYear.HeaderText = "Year";

          var colSD = dgvStudentRecord.Columns["StartDate"];
            colSD.DisplayIndex = 7; colSD.HeaderText = "Start Date";

            var colGD = dgvStudentRecord.Columns["GraduateDate"];
            colGD.DisplayIndex = 8; colGD.HeaderText = "Graduate Date";

            var colDP = dgvStudentRecord.Columns["DropPeriod"];
            colDP.DisplayIndex =9 ; colDP.HeaderText = "Drop Period";
        
            var colAddress = dgvStudentRecord.Columns["Address"];
            colAddress.DisplayIndex = 10; colAddress.HeaderText = "Address";

             var colSection = dgvStudentRecord.Columns["DepartmentId"];
            colSection.DisplayIndex = 11; colSection.HeaderText = "Department ID";

            var colPhoto = (DataGridViewImageColumn)dgvStudentRecord.Columns["Photo"];
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.DisplayIndex =12 ; colPhoto.HeaderText = "Photo";
            dgvStudentRecord.RowTemplate.Height = 50;
            colPhoto.DefaultCellStyle.NullValue = null;

            dgvStudentRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvStudentRecord.AllowUserToAddRows = false;
            dgvStudentRecord.ReadOnly = true;

            bs.ResetBindings(true);

        }


        private void addNewStudent_Click(object sender, EventArgs e)
         {

             StudentAddEditForm frmAdd = new StudentAddEditForm("Adding Students Form", StudentAddEditForm.Operation.OP_ADD,bs);
             frmAdd.ShowDialog(this);
         }
         private void updateStudent_Click(object sender, EventArgs e)
         {
             if (bs.Current == null)
             {
                 return;
             }
             StudentAddEditForm frmEdit = new StudentAddEditForm("Editing Student Form", StudentAddEditForm.Operation.OP_EDIT,bs);
             frmEdit.Show();


         }
        
        private void deleteStudent_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Student s = new Student();
                s = (Student)bs.Current;
                bs.RemoveCurrent();
               stuController.Delete(s.Id);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bs.Clear();
            bs = new BindingSource(stuController.GetDataByID(searchTxtBox.Text), null);
            dgvStudentRecord.DataSource = bs;
          
        }
    }
}
