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
    public partial class DepartmentAddEditForm : Form
    {
        public DepartmentAddEditForm()
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
        private Department cur;
        private string id;
        public DepartmentAddEditForm(string title, Operation op, BindingSource bs)
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
        private void DepartmentAddEditForm_Load(object sender, EventArgs e)
        {
            this.Text = title;

            cur = new Department();
            if (op == Operation.OP_EDIT)
            {
                cur = (Department)bs.Current;
                id = cur.DepartmentId;
            }

            b = new BindingSource(cur, null);

            depIDTxtBox.DataBindings.Add("Text", b, "DepartmentId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            depNameTxtBox.DataBindings.Add("Text", b, "DepartmentName").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                      
            b.ResetBindings(false);
            depIDTxtBox.KeyPress += ValidateKeyPress;
            depNameTxtBox.KeyPress += ValidateKeyPress;
           
           
            
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
            depIDTxtBox.DataBindings["Text"].WriteValue();
            depNameTxtBox.DataBindings["Text"].WriteValue();
           
            b.RaiseListChangedEvents = true;

            if (op == Operation.OP_ADD)
            {

                model.Department.InsertData(depIDTxtBox.Text,depNameTxtBox.Text);
                bs.Position = bs.List.Add(cur.Clone());
                //cur.SetData("", "", 0);
                b.CancelEdit();
                this.Close();
            }
            else
            {
                model.Department.UpdateData(depIDTxtBox.Text, depNameTxtBox.Text);
                b.CancelEdit();
                this.Close();
            }
            bs.ResetBindings(false);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            depIDTxtBox.Text = "";
            depNameTxtBox.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            b.CancelEdit();
        }
       
    }
}
