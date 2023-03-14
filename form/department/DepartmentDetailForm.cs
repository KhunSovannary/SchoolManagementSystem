using SchoolManagementSystem.controller;
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

namespace SchoolManagementSystem.form.department
{
    public partial class DepartmentDetailForm : Form
    {
        public DepartmentDetailForm()
        {
            InitializeComponent();
        }
     
        static List<Department> departments= new List<Department>();
        static BindingSource bs;
        DepartmentController departmentController = new DepartmentController();
        private void DepartmentDetailForm_Load(object sender, EventArgs e)
        {
            departments = departmentController.GetData();
            bs = new BindingSource(departments, null);
            dgvDep.DataSource = bs;

            var colId = dgvDep.Columns["DepartmentId"];
            colId.DisplayIndex = 0; colId.HeaderText = "Department ID";

            var coldepName = dgvDep.Columns["DepartmentName"];
            coldepName.DisplayIndex = 1; coldepName.HeaderText = "Department Name";

           

            dgvDep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDep.ReadOnly = true;
            bs.ResetBindings(true);
        }

        private void addNewDepBtn_Click(object sender, EventArgs e)
        {
            DepartmentAddEditForm frmAdd = new DepartmentAddEditForm("Adding Department Form", DepartmentAddEditForm.Operation.OP_ADD, bs);
            frmAdd.ShowDialog(this);
        }

        private void updateDepBtn_Click(object sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                return;
            }

            DepartmentAddEditForm frmEdit = new DepartmentAddEditForm("Editing Department Form", DepartmentAddEditForm.Operation.OP_EDIT, bs);
            frmEdit.Show();
        }

        private void deleteDepBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Department dep = new Department();
                dep= (Department)bs.Current;
                bs.RemoveCurrent();
                departmentController.Delete(dep.DepartmentId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
          
        }

       

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bs.Clear();
            bs = new BindingSource(departmentController.GetDataByID(searchTxtBox.Text), null);
            dgvDep.DataSource = bs;
        }
      
    }
}
