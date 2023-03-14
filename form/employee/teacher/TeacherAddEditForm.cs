using SchoolManagementSystem.controller.employee;
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

namespace SchoolManagementSystem.form.employee.teacher
{
    public partial class TeacherAddEditForm : Form
    {
        public TeacherAddEditForm()
        {
            InitializeComponent();
        }

        public TeacherAddEditForm(string title, Operation op, BindingSource bs)
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
        private Teacher cur;
        private string id;
        TeacherController teacherController = new TeacherController();
        private void TeacherAddEditForm_Load(object sender, EventArgs e)
        {
            this.Text = title;

            cur = new Teacher();
            if (op == Operation.OP_EDIT)
            {
                cur = (Teacher)bs.Current;
                id = cur.Id;
            }


            b = new BindingSource(cur, null);

            TeachIDTxtBox.DataBindings.Add("Text", b, "Id").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            TeachNameTxtBox.DataBindings.Add("Text", b, "Name").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            genderTxtBox.DataBindings.Add("Text", b, "Gender").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            dobTxtBox.DataBindings.Add("Text", b, "Dob").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            phoneNumTxtBox.DataBindings.Add("Text", b, "PhoneNumber").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            addressTxtBox.DataBindings.Add("Text", b, "Address").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            SalaryTxtBox.DataBindings.Add("Text", b, "Salary").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            DepartIDTxtBox.DataBindings.Add("Text", b, "DepartmentId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            teachPhoto.DataBindings.Add("Image", b, "Photo", true).DataSourceUpdateMode = DataSourceUpdateMode.Never;
          
            TeachIDTxtBox.KeyPress += ValidateKeyPress;
            TeachNameTxtBox.KeyPress += ValidateKeyPress;
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
            TeachIDTxtBox.DataBindings["Text"].WriteValue();
            genderTxtBox.DataBindings["Text"].WriteValue();
            dobTxtBox.DataBindings["Text"].WriteValue();
            phoneNumTxtBox.DataBindings["Text"].WriteValue();
            addressTxtBox.DataBindings["Text"].WriteValue();
            TeachNameTxtBox.DataBindings["Text"].WriteValue();
            SalaryTxtBox.DataBindings["Text"].WriteValue();
            DepartIDTxtBox.DataBindings["Text"].WriteValue();
            
            MemoryStream stream = new MemoryStream();
            byte[] teachPhoto1;
            if (teachPhoto.Image == null)
            {
                teachPhoto.Image = Properties.Resources.pic1;
                teachPhoto.Image.Save(stream, teachPhoto.Image.RawFormat);
            }
            else
                teachPhoto.Image.Save(stream, teachPhoto.Image.RawFormat);
            teachPhoto1 = stream.ToArray();
            teachPhoto.DataBindings["Image"].WriteValue();
           

            b.RaiseListChangedEvents = true;
            Teacher t = new Teacher(TeachIDTxtBox.Text, TeachNameTxtBox.Text, dobTxtBox.Text, genderTxtBox.Text, phoneNumTxtBox.Text,
                    addressTxtBox.Text, Double.Parse(SalaryTxtBox.Text), DepartIDTxtBox.Text, teachPhoto1);
            if (op == Operation.OP_ADD)
            {
                teacherController.Insert(t);
                bs.Position = bs.List.Add(cur.Clone());

                //cur.SetData("", "", 0);
                b.CancelEdit();
                this.Close();
            }
            else
            {
                teacherController.Update(t);
                b.CancelEdit();
                this.Close();
            }
            bs.ResetBindings(false);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            TeachIDTxtBox.Text = "";
            TeachNameTxtBox.Text = "";
            genderTxtBox.Text = "";
            dobTxtBox.Text = "";
            phoneNumTxtBox.Text = "";
            addressTxtBox.Text = "";
            SalaryTxtBox.Text = "";
            DepartIDTxtBox.Text = "";
            teachPhoto.Image = null;

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            b.CancelEdit();
        }

        private void addPhotoBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                teachPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                teachPhoto.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
