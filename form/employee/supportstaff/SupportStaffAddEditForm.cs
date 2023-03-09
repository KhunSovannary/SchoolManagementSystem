using SchoolManagementSystem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.form.employee.supportstaff
{
    public partial class SupportStaffAddEditForm : Form
    {
        public SupportStaffAddEditForm()
        {
            InitializeComponent();
        }
        public SupportStaffAddEditForm(string title, Operation op, BindingSource bs)
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
        private SupportStaff cur;
        private string id;

        private void SupportStaffAddEditForm_Load(object sender, EventArgs e)
        {
            this.Text = title;

            cur = new SupportStaff();
            if (op == Operation.OP_EDIT)
            {
                cur = (SupportStaff)bs.Current;
                id = cur.Id;
            }


            b = new BindingSource(cur, null);

            ssIDTxtBox.DataBindings.Add("Text", b, "Id").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            ssNameTxtBox.DataBindings.Add("Text", b, "Name").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            genderTxtBox.DataBindings.Add("Text", b, "Gender").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            dobTxtBox.DataBindings.Add("Text", b, "Dob").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            phoneNumTxtBox.DataBindings.Add("Text", b, "PhoneNumber").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            addressTxtBox.DataBindings.Add("Text", b, "Address").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            SalaryTxtBox.DataBindings.Add("Text", b, "Salary").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            DepartIDTxtBox.DataBindings.Add("Text", b, "DepartmentId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            jobTitleTxtBox.DataBindings.Add("Text", b, "JobTitle").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            ssPhoto.DataBindings.Add("Image", b, "Photo", true).DataSourceUpdateMode = DataSourceUpdateMode.Never;
           
            ssIDTxtBox.KeyPress += ValidateKeyPress;
            ssNameTxtBox.KeyPress += ValidateKeyPress;
            genderTxtBox.KeyPress += ValidateKeyPress;
            dobTxtBox.KeyPress += ValidateKeyPress;
            phoneNumTxtBox.KeyPress += ValidateKeyPress;
            addressTxtBox.KeyPress += ValidateKeyPress;
            SalaryTxtBox.KeyPress += ValidateKeyPress;
            DepartIDTxtBox.KeyPress += ValidateKeyPress;
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
            ssIDTxtBox.DataBindings["Text"].WriteValue();
            genderTxtBox.DataBindings["Text"].WriteValue();
            dobTxtBox.DataBindings["Text"].WriteValue();
            phoneNumTxtBox.DataBindings["Text"].WriteValue();
            addressTxtBox.DataBindings["Text"].WriteValue();
            ssNameTxtBox.DataBindings["Text"].WriteValue();
            SalaryTxtBox.DataBindings["Text"].WriteValue();
            DepartIDTxtBox.DataBindings["Text"].WriteValue();
            jobTitleTxtBox.DataBindings["Text"].WriteValue();
           

            MemoryStream stream = new MemoryStream();
            byte[] ssPhoto1;
            if (ssPhoto.Image == null)
            {
                ssPhoto.Image = Properties.Resources.pic1;
                ssPhoto.Image.Save(stream, ssPhoto.Image.RawFormat);
            }
            else
                ssPhoto.Image.Save(stream, ssPhoto.Image.RawFormat);
            ssPhoto1 = stream.ToArray();
            ssPhoto.DataBindings["Image"].WriteValue();
            
            b.RaiseListChangedEvents = true;

            if (op == Operation.OP_ADD)
            {
                model.SupportStaff.InsertData(ssIDTxtBox.Text, ssNameTxtBox.Text, dobTxtBox.Text, genderTxtBox.Text, phoneNumTxtBox.Text,
                    addressTxtBox.Text, Double.Parse(SalaryTxtBox.Text), DepartIDTxtBox.Text,jobTitleTxtBox.Text,ssPhoto1);
                bs.Position = bs.List.Add(cur.Clone());

                //cur.SetData("", "", 0);
                b.CancelEdit();
                this.Close();
            }
            else
            {
                model.SupportStaff.UpdateData(ssIDTxtBox.Text, ssNameTxtBox.Text, dobTxtBox.Text, genderTxtBox.Text, phoneNumTxtBox.Text,
                    addressTxtBox.Text, Double.Parse(SalaryTxtBox.Text), DepartIDTxtBox.Text, jobTitleTxtBox.Text, ssPhoto1);
                b.CancelEdit();
                this.Close();
            }
            bs.ResetBindings(false);
        }

        private void addPhotoBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ssPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                ssPhoto.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ssIDTxtBox.Text = "";
            ssNameTxtBox.Text = "";
            genderTxtBox.Text = "";
            dobTxtBox.Text = "";
            phoneNumTxtBox.Text = "";
            addressTxtBox.Text = "";
            SalaryTxtBox.Text = "";
            DepartIDTxtBox.Text = "";
            jobTitleTxtBox.Text = "";
            ssPhoto.Image = null;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
