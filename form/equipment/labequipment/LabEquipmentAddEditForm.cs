using SchoolManagementSystem.controller.equipment;
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
    public partial class LabEquipmentAddEditForm : Form
    {
        public LabEquipmentAddEditForm()
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
        private LabEquipments cur;
        private string id;
        LabEquipmentController labEquipmentController = new LabEquipmentController();
        public LabEquipmentAddEditForm(string title, Operation op, BindingSource bs)
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
        private void saveBtn_Click(object sender, EventArgs e)
        {

            b.RaiseListChangedEvents = false;
            equIDTxtBox.DataBindings["Text"].WriteValue();
            equipNameTxtBox.DataBindings["Text"].WriteValue();
            costTxtBox.DataBindings["Text"].WriteValue();
            equipCountTxtBox.DataBindings["Text"].WriteValue();
          

            b.RaiseListChangedEvents = true;
            LabEquipments labEquip = new LabEquipments(equIDTxtBox.Text, Double.Parse(costTxtBox.Text), equipNameTxtBox.Text, int.Parse(equipCountTxtBox.Text));
            if (op == Operation.OP_ADD)
            {

                labEquipmentController.Insert(labEquip);
                bs.Position = bs.List.Add(cur.Clone());
                //cur.SetData("", "", 0);
                b.CancelEdit();
                this.Close();
            }
            else
            {
                labEquipmentController.Update(labEquip);
                b.CancelEdit();
                this.Close();
            }
            bs.ResetBindings(false);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            equIDTxtBox.Text = "";
            equipNameTxtBox.Text = "";
            costTxtBox.Text = "";
            equipCountTxtBox.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            b.CancelEdit();
        }

        private void LabEquipmentAddEditForm_Load(object sender, EventArgs e)
        {
            this.Text = title;

            cur = new LabEquipments();
            if (op == Operation.OP_EDIT)
            {
                cur = (LabEquipments)bs.Current;
                
            }

            b = new BindingSource(cur, null);

            equIDTxtBox.DataBindings.Add("Text", b, "EquipmentId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            equipNameTxtBox.DataBindings.Add("Text", b, "EquipmentName").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            costTxtBox.DataBindings.Add("Text", b, "Cost").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            equipCountTxtBox.DataBindings.Add("Text", b, "EquipmentCount").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            b.ResetBindings(false);
            equIDTxtBox.KeyPress += ValidateKeyPress;
             equipNameTxtBox.KeyPress += ValidateKeyPress;
            costTxtBox.KeyPress += ValidateKeyPress;
            equipCountTxtBox.KeyPress += ValidateKeyPress;
        }
        private void ValidateKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                (sender as TextBox).DataBindings["Text"].ReadValue();
            }
        }

    }

}
