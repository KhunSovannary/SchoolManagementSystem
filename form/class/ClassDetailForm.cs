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

namespace SchoolManagementSystem
{
    public partial class ClassDetailForm : Form
    {
        SQLiteConnection sqlite_conn;
        public ClassDetailForm()
        {
            InitializeComponent();
        }

        static List<Classroom> classrooms = new List<Classroom>();
        static BindingSource bs;
        ClassroomController classroomController = new ClassroomController();

       

        private void ClassDetailForm_Load(object sender, EventArgs e)
        {
            classrooms = classroomController.GetData();
            bs = new BindingSource(classrooms, null);
            dgvClassroom.DataSource = bs;

            var colId = dgvClassroom.Columns["ClassId"];
            colId.DisplayIndex = 0; colId.HeaderText = "Class ID";

            var colName = dgvClassroom.Columns["ClassName"];
            colName.DisplayIndex = 1; colName.HeaderText = "Class Name";

            var colTeacherId = dgvClassroom.Columns["TeacherId"];
            colTeacherId.DisplayIndex = 2; colTeacherId.HeaderText = "Teacher ID";

            var colStudentCount = dgvClassroom.Columns["StudentCount"];
            colStudentCount.DisplayIndex = 3; colStudentCount.HeaderText = "Student Count";



            var colEquipmentId = dgvClassroom.Columns["EquipmentId"];
            colEquipmentId.DisplayIndex = 4; colEquipmentId.HeaderText = "Equipment Id";


            dgvClassroom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClassroom.AllowUserToAddRows = false;
            dgvClassroom.ReadOnly = true;
            bs.ResetBindings(true);
        }
       
        private void addNewClassBtn_Click(object sender, EventArgs e)
        {
            ClassAddEditForm frmAdd = new ClassAddEditForm("Adding Classes Form", ClassAddEditForm.Operation.OP_ADD, bs);
            frmAdd.ShowDialog(this);
        }
        private void updateClassBtn_Click(object sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                return;
            }

            ClassAddEditForm frmEdit = new ClassAddEditForm("Editing Classes Form", ClassAddEditForm.Operation.OP_EDIT, bs);
            frmEdit.Show();
        }
        private void deleteClassBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Classroom cls = new Classroom();
                cls = (Classroom)bs.Current;
                bs.RemoveCurrent();
                classroomController.Delete(cls.ClassId);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bs.Clear();
            bs = new BindingSource(classroomController.GetDataByID(searchTxtBox.Text), null);
            dgvClassroom.DataSource = bs;
        }
    }
}
