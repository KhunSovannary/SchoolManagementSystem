using SchoolManagementSystem.form.employee.teacher;
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

namespace SchoolManagementSystem.form.equipment.labequipment
{
    public partial class LabEquipmentDetailForm : Form
    {
        public LabEquipmentDetailForm()
        {
            InitializeComponent();
        }
        static List<LabEquipments> labEquipments = new List<LabEquipments>();
        static BindingSource bs;
        private void addNewEquipBtn_Click(object sender, EventArgs e)
        {
            LabEquipmentAddEditForm frmAdd = new LabEquipmentAddEditForm("Add Lab Equipment Form", LabEquipmentAddEditForm.Operation.OP_ADD, bs);
            frmAdd.ShowDialog(this);
        }

        private void updateEquipBtn_Click(object sender, EventArgs e)
        {

            if (bs.Current == null)
            {
                return;
            }
            LabEquipmentAddEditForm frmEdit = new LabEquipmentAddEditForm("Edit Lab Equipment Form", LabEquipmentAddEditForm.Operation.OP_EDIT, bs);
            frmEdit.ShowDialog(this);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LabEquipments l = new LabEquipments();
                l = (LabEquipments)bs.Current;
                bs.RemoveCurrent();
                LabEquipments.DeleteData(l.EquipmentId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           
        }
    

        private void LabEquipmentDetailForm_Load(object sender, EventArgs e)
        {
            labEquipments = LabEquipments.ReadData();
            bs = new BindingSource(labEquipments, null);
            dgvLabEquipment.DataSource = bs;

            var colId = dgvLabEquipment.Columns["EquipmentId"];
            colId.DisplayIndex = 0; colId.HeaderText = "Equipment ID";

            var colCost = dgvLabEquipment.Columns["Cost"];
            colCost.DisplayIndex = 1; colCost.HeaderText = "Cost";

            var colName = dgvLabEquipment.Columns["EquipmentName"];
            colName.DisplayIndex = 2; colName.HeaderText = "Equipment Name";

            var colCount = dgvLabEquipment.Columns["EquipmentCount"];
            colCount.DisplayIndex = 3; colCount.HeaderText = "Equipment Count";


            
            dgvLabEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvLabEquipment.AllowUserToAddRows = false;
            dgvLabEquipment.ReadOnly = true;
            bs.ResetBindings(true);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bs.Clear();
            bs = new BindingSource(LabEquipments.SearchData(searchTxtBox.Text), null);
            dgvLabEquipment.DataSource = bs;
        }
    }
}
