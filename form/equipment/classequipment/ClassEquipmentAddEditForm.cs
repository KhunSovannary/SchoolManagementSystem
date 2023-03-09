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
    public partial class ClassEquipmentAddEditForm : Form
    {
                    public ClassEquipmentAddEditForm()
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
                    private ClassEquipments cur;
       
                    public ClassEquipmentAddEditForm(string title, Operation op, BindingSource bs)
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
                        costTxtBox.DataBindings["Text"].WriteValue();
                        classIDTxtBox.DataBindings["Text"].WriteValue();
                        chairCountTxtBox.DataBindings["Text"].WriteValue();
                        fanCountTxtBox.DataBindings["Text"].WriteValue();
                        lightCountTxtBox.DataBindings["Text"].WriteValue();
           

                        b.RaiseListChangedEvents = true;

                        if (op == Operation.OP_ADD)
                        {

                            ClassEquipments.InsertData(equIDTxtBox.Text,Double.Parse(costTxtBox.Text), classIDTxtBox.Text,int.Parse(chairCountTxtBox.Text),
                                int.Parse(fanCountTxtBox.Text), int.Parse(lightCountTxtBox.Text));
                            bs.Position = bs.List.Add(cur.Clone());
                            //cur.SetData("", "", 0);
                            b.CancelEdit();
                            this.Close();
                        }
                        else
                        {
                            ClassEquipments.UpdateData(equIDTxtBox.Text, Double.Parse(costTxtBox.Text), classIDTxtBox.Text, int.Parse(chairCountTxtBox.Text),
                                int.Parse(fanCountTxtBox.Text), int.Parse(lightCountTxtBox.Text));
                            b.CancelEdit();
                            this.Close();
                        }
                        bs.ResetBindings(false);
                    }

                    private void clearBtn_Click(object sender, EventArgs e)
                    {
                        equIDTxtBox.Text = "";
                        costTxtBox.Text = "";
                        classIDTxtBox.Text = "";
                        chairCountTxtBox.Text = "";
                        fanCountTxtBox.Text = "";
                        lightCountTxtBox.Text = "";
        }

                    private void closeBtn_Click(object sender, EventArgs e)
                    {
                               b.CancelEdit();
                    }

                    private void ClassEquipmentAddEditForm_Load(object sender, EventArgs e)
                    {
                        this.Text = title;

                        cur = new ClassEquipments();
                        if (op == Operation.OP_EDIT)
                        {
                            cur = (ClassEquipments)bs.Current;

                        }

                        b = new BindingSource(cur, null);

                        equIDTxtBox.DataBindings.Add("Text", b, "EquipmentId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                        costTxtBox.DataBindings.Add("Text", b, "Cost").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                        classIDTxtBox.DataBindings.Add("Text", b, "ClassId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                        chairCountTxtBox.DataBindings.Add("Text", b, "ChairCount").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                        fanCountTxtBox.DataBindings.Add("Text", b, "FanCount").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                        lightCountTxtBox.DataBindings.Add("Text", b, "LightCount").DataSourceUpdateMode = DataSourceUpdateMode.Never;
                        b.ResetBindings(false);

                        equIDTxtBox.KeyPress += ValidateKeyPress;
                        costTxtBox.KeyPress += ValidateKeyPress;
                        classIDTxtBox.KeyPress += ValidateKeyPress;
                        chairCountTxtBox.KeyPress += ValidateKeyPress;
                        fanCountTxtBox.KeyPress += ValidateKeyPress;
                        lightCountTxtBox.KeyPress += ValidateKeyPress;
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
