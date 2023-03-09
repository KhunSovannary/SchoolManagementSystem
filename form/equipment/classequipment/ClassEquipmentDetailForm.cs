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

namespace SchoolManagementSystem.form.equipment.classequipment
{
    public partial class ClassEquipmentDetailForm : Form
    {
        public ClassEquipmentDetailForm()
        {
            InitializeComponent();
        }
        static List<ClassEquipments> classEquipment = new List<ClassEquipments>();
        static BindingSource bs;
        private void addNewEquipBtn_Click(object sender, EventArgs e)
        {

           
            ClassEquipmentAddEditForm frmAdd = new ClassEquipmentAddEditForm("Add Class Equipment Form", ClassEquipmentAddEditForm.Operation.OP_ADD, bs);
            frmAdd.ShowDialog(this);
        }

        private void updateEquipBtn_Click(object sender, EventArgs e)
        {

            if (bs.Current == null)
            {
                return;
            }
            ClassEquipmentAddEditForm frmEdit = new ClassEquipmentAddEditForm("Edit Class Equipment Form", ClassEquipmentAddEditForm.Operation.OP_EDIT, bs);
            frmEdit.ShowDialog(this);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClassEquipments t = new ClassEquipments();
                t = (ClassEquipments)bs.Current;
                bs.RemoveCurrent();
                ClassEquipments.DeleteData(t.EquipmentId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void ClassEquipmentDetailForm_Load(object sender, EventArgs e)
        {

            classEquipment = ClassEquipments.ReadData();
            bs = new BindingSource(classEquipment, null);
            dgvClassEquipment.DataSource = bs;

            var colId = dgvClassEquipment.Columns["EquipmentId"];
            colId.DisplayIndex = 0; colId.HeaderText = "Equipment ID";

            var colCost = dgvClassEquipment.Columns["Cost"];
            colCost.DisplayIndex = 1; colCost.HeaderText = "Cost";

            var colClass = dgvClassEquipment.Columns["ClassId"];
            colClass.DisplayIndex = 2; colClass.HeaderText = "Class ID";

            var colcCount = dgvClassEquipment.Columns["ChairCount"];
            colcCount.DisplayIndex = 3; colcCount.HeaderText = "Bench Count";
            var colfCount = dgvClassEquipment.Columns["FanCount"];
            colfCount.DisplayIndex = 4; colfCount.HeaderText = "Fan Count";
            var collCount = dgvClassEquipment.Columns["LightCount"];
            collCount.DisplayIndex = 5; collCount.HeaderText = "Light Count";



            dgvClassEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvClassEquipment.AllowUserToAddRows = false;
            dgvClassEquipment.ReadOnly = true;
            bs.ResetBindings(true);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bs.Clear();
            bs = new BindingSource(ClassEquipments.SearchData(searchTxtBox.Text), null);
            dgvClassEquipment.DataSource = bs;
        }
    }
}
