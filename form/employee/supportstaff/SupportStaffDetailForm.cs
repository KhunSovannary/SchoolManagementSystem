using SchoolManagementSystem.controller;
using SchoolManagementSystem.controller.employee;
using SchoolManagementSystem.model;
using SchoolManagementSystem.repository.employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.form.employee.supportstaff
{
    public partial class SupportStaffDetailForm : Form
    {
        public SupportStaffDetailForm()
        {
            InitializeComponent();
        }
        static List<SupportStaff> staffs = new List<SupportStaff>();
        static BindingSource bs;
        SupportStaffController supportStaffController = new SupportStaffController();
        private void SupportStaffDetailForm_Load(object sender, EventArgs e)
        {
            staffs = supportStaffController.GetData();
            bs = new BindingSource(staffs, null);
            dgvStaff.DataSource = bs;

            var colId = dgvStaff.Columns["Id"];
            colId.DisplayIndex = 0; colId.HeaderText = "Support Staff ID";

            var colName = dgvStaff.Columns["Name"];
            colName.DisplayIndex = 1; colName.HeaderText = "Support Staff Name";

            var colGender = dgvStaff.Columns["Gender"];
            colGender.DisplayIndex = 2; colGender.HeaderText = "Gender";

            var colDob = dgvStaff.Columns["Dob"];
            colDob.DisplayIndex = 3; colDob.HeaderText = "DOB";

            var colphone = dgvStaff.Columns["PhoneNumber"];
            colphone.DisplayIndex = 4; colphone.HeaderText = "Phone Number";

            var colAddress = dgvStaff.Columns["Address"];
            colAddress.DisplayIndex = 5; colAddress.HeaderText = "Address";

            var colSalary = dgvStaff.Columns["Salary"];
            colSalary.DisplayIndex = 6; colSalary.HeaderText = "Salary";

            var colDepID = dgvStaff.Columns["DepartmentId"];
            colDepID.DisplayIndex = 7; colDepID.HeaderText = "Department ID";

            var colJob = dgvStaff.Columns["JobTitle"];
            colJob.DisplayIndex = 8; colJob.HeaderText = "Job Title";

            var colPhoto = (DataGridViewImageColumn)dgvStaff.Columns["Photo"];
            colPhoto.DefaultCellStyle.NullValue = null;
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.DisplayIndex = 9; colPhoto.HeaderText = "Photo";

            dgvStaff.RowTemplate.Height = 50;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.ReadOnly = true;
            bs.ResetBindings(true);
        
    }

        private void addNewStaff_Click(object sender, EventArgs e)
        {
            SupportStaffAddEditForm frmAdd = new SupportStaffAddEditForm("Add Support Staff Form", SupportStaffAddEditForm.Operation.OP_ADD, bs);
            frmAdd.ShowDialog(this);
        }

        private void updateStaff_Click(object sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                return;
            }
            SupportStaffAddEditForm frmEdit = new SupportStaffAddEditForm("Edit Support Staff Form", SupportStaffAddEditForm.Operation.OP_EDIT, bs);
            frmEdit.ShowDialog(this);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SupportStaff t = new SupportStaff();
                t = (SupportStaff)bs.Current;
                bs.RemoveCurrent();
                supportStaffController.Delete(t.Id);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
          
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bs.Clear();
            bs = new BindingSource(supportStaffController.GetDataByID(searchTxtBox.Text), null);
            dgvStaff.DataSource = bs;
        }
    }
}
