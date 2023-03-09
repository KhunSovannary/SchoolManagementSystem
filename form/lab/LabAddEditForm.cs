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
    public partial class LabAddEditForm : Form
    {
        public LabAddEditForm()
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
        private Lab cur;
        private string id;
        public LabAddEditForm(string title, Operation op, BindingSource bs)
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
        private void LabAddEditForm_Load(object sender, EventArgs e)
        {
            this.Text = title;

            cur = new Lab();
            if (op == Operation.OP_EDIT)
            {
                cur = (Lab)bs.Current;
                id = cur.LabId;
            }

            b = new BindingSource(cur, null);

            labIDTxtBox.DataBindings.Add("Text", b, "LabId").DataSourceUpdateMode = DataSourceUpdateMode.Never;     
            labNameTxtBox.DataBindings.Add("Text", b, "LabName").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            equIDTxtBox.DataBindings.Add("Text", b, "EquipmentId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            b.ResetBindings(false);
            labIDTxtBox.KeyPress += ValidateKeyPress;        
            labNameTxtBox.KeyPress += ValidateKeyPress;
            equIDTxtBox.KeyPress += ValidateKeyPress;
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
            labIDTxtBox.DataBindings["Text"].WriteValue();
            labNameTxtBox.DataBindings["Text"].WriteValue();
            equIDTxtBox.DataBindings["Text"].WriteValue();

            b.RaiseListChangedEvents = true;

            if (op == Operation.OP_ADD)
            {
               
                model.Lab.InsertData(labIDTxtBox.Text, labNameTxtBox.Text, equIDTxtBox.Text);
                bs.Position = bs.List.Add(cur.Clone());
                //cur.SetData("", "", 0);
                b.CancelEdit();
                this.Close();
            }
            else
            {
               model.Lab.UpdateData(labIDTxtBox.Text, labNameTxtBox.Text, equIDTxtBox.Text);
                b.CancelEdit();
                this.Close();
            }
            bs.ResetBindings(false);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            labIDTxtBox.Text = "";
            labNameTxtBox.Text = "";
            equIDTxtBox.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            b.CancelEdit();
        }
       
      
    }
}
