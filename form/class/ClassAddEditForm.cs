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
    public partial class ClassAddEditForm : Form
    {
        public ClassAddEditForm()
        {
            InitializeComponent();
        }
        public enum Operation
        {
            OP_NONE = 0,
            OP_ADD = 1,
            OP_EDIT = 2
        }
        private string title;
        private BindingSource bs;
        private Operation op;
        private BindingSource b;
        private Classroom cur;
        private string id;
        public ClassAddEditForm(string title, Operation op, BindingSource bs)
        {
            InitializeComponent();
            this.title = title;
            this.bs = bs;
            if (bs == null)
            {
                this.Close();
            }
            this.op = op;
            if (this.op == Operation.OP_NONE)
            {
                this.Close();
            }

        }
        private void ClassAddEditForm_Load(object sender, EventArgs e)
        {
            this.Text = title;

            cur = new Classroom("", "", "", "", 0);
            if (op == Operation.OP_EDIT)
            {
                cur = (Classroom)bs.Current;
                id = cur.ClassId;
            }
           
            b = new BindingSource(cur, null);

            classIDTxtBox.DataBindings.Add("Text", b, "ClassId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            classNameTxtBox.DataBindings.Add("Text", b, "ClassName").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            teacherIDTxtBox.DataBindings.Add("Text", b, "TeacherId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            stuCountTxtBox.DataBindings.Add("Text", b, "StudentCount").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            equipIDTxtBox.DataBindings.Add("Text", b, "EquipmentId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            b.ResetBindings(false);
            classIDTxtBox.KeyPress += ValidateKeyPress;
            classNameTxtBox.KeyPress += ValidateKeyPress;
            teacherIDTxtBox.KeyPress += ValidateKeyPress;
            stuCountTxtBox.KeyPress += ValidateKeyPress;
            equipIDTxtBox.KeyPress += ValidateKeyPress;

        }
        private void ValidateKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                (sender as TextBox).DataBindings["Text"].ReadValue();
            }
        }


   
        

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            b.RaiseListChangedEvents = false;
            classIDTxtBox.DataBindings["Text"].WriteValue();
            classNameTxtBox.DataBindings["Text"].WriteValue();
            teacherIDTxtBox.DataBindings["Text"].WriteValue();
            stuCountTxtBox.DataBindings["Text"].WriteValue();
            equipIDTxtBox.DataBindings["Text"].WriteValue();

            b.RaiseListChangedEvents = true;

            if (op == Operation.OP_ADD)
            {

                model.Classroom.InsertData(classIDTxtBox.Text,classNameTxtBox.Text,teacherIDTxtBox.Text,
                    equipIDTxtBox.Text,int.Parse(stuCountTxtBox.Text));
                bs.Position = bs.List.Add(cur.Clone());
                //cur.SetData("", "", 0);
                b.CancelEdit();
                this.Close();
            }
            else
            {
                model.Classroom.UpdateData(classIDTxtBox.Text, classNameTxtBox.Text, teacherIDTxtBox.Text,
                    equipIDTxtBox.Text, int.Parse(stuCountTxtBox.Text));
                b.CancelEdit();
                this.Close();
            }
            bs.ResetBindings(false);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            b.CancelEdit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            classIDTxtBox.Text = "";
            classNameTxtBox.Text = "";
            teacherIDTxtBox.Text = "";
            stuCountTxtBox.Text = "";
            equipIDTxtBox.Text = "" ;
        }
    }

}
