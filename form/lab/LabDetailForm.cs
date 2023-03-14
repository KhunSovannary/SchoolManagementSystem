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

namespace SchoolManagementSystem.form.lab
{
    public partial class LabDetailForm : Form
    {
        public LabDetailForm()
        {
            InitializeComponent();
        }
        
        static List<Lab> labs = new List<Lab>();
        static BindingSource bs;
        LabController labController = new LabController();
        private void LabDetailForm_Load(object sender, EventArgs e)
        {
            labs = labController.GetData();
            bs = new BindingSource(labs, null);
            dgvLab.DataSource = bs;

            var colId = dgvLab.Columns["LabId"];
            colId.DisplayIndex = 0; colId.HeaderText = "Lab ID";

           

            var collName = dgvLab.Columns["LabName"];
            collName.DisplayIndex = 1; collName.HeaderText = "Lab Name";

            var colEId = dgvLab.Columns["EquipmentId"];
            colEId.DisplayIndex = 2; colEId.HeaderText = "Equipment ID";

            dgvLab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLab.AllowUserToAddRows = false;
            dgvLab.ReadOnly = true;
            bs.ResetBindings(true);
        }

        private void addNewLabBtn_Click(object sender, EventArgs e)
        {
            LabAddEditForm frmAdd = new LabAddEditForm("Adding Lab Form", LabAddEditForm.Operation.OP_ADD, bs);
            frmAdd.ShowDialog(this);
        }

        private void updateLabBtn_Click(object sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                return;
            }

            LabAddEditForm frmEdit = new LabAddEditForm("Editing Lab Form", LabAddEditForm.Operation.OP_EDIT, bs);
            frmEdit.Show();
        }

        private void deleteLabBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Lab l = new Lab();
                l = (Lab)bs.Current;
                bs.RemoveCurrent();
                labController.Delete(l.LabId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            bs.Clear();
            bs = new BindingSource(labController.GetDataByID(searchTxtBox.Text), null);
            dgvLab.DataSource = bs;
        }
       
    }
}
