﻿using SchoolManagementSystem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.form.student
{
    public partial class StudentAddEditForm : Form
    {
      
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
        private Student cur;
        private string id;
        public StudentAddEditForm(string title,Operation op, BindingSource bs)
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
            stuIDTxtBox.DataBindings["Text"].WriteValue();
            stuNameTxtBox.DataBindings["Text"].WriteValue();
            stugenderTxtBox.DataBindings["Text"].WriteValue();
            studobTxtBox.DataBindings["Text"].WriteValue();
            stuclassTxtBox.DataBindings["Text"].WriteValue();
            stupNumTxtBox.DataBindings["Text"].WriteValue();
            stuaddressTxtBox.DataBindings["Text"].WriteValue();
            depTxtBox.DataBindings["Text"].WriteValue();
            MemoryStream stream = new MemoryStream();
            byte[] stuPhoto1;
            if (studentPic.Image == null)
            {
                studentPic.Image = Properties.Resources.pic1;
                studentPic.Image.Save(stream, studentPic.Image.RawFormat);
            }
            else
                studentPic.Image.Save(stream, studentPic.Image.RawFormat);
            stuPhoto1 = stream.ToArray();
            studentPic.DataBindings["Image"].WriteValue();
            b.RaiseListChangedEvents = true;




            if (op == Operation.OP_ADD)
            {

                Student.InsertData(stuIDTxtBox.Text, stuNameTxtBox.Text, stugenderTxtBox.Text, studobTxtBox.Text,
                    stuaddressTxtBox.Text, stupNumTxtBox.Text, stuclassTxtBox.Text, depTxtBox.Text,stuPhoto1);
                Console.WriteLine(stuPhoto1.ToString());
                bs.Position = bs.List.Add(cur.Clone());
                //cur.SetData("", "", 0);
                b.CancelEdit();
                this.Close() ;
            }
            else
            {
                Student.UpdateData(stuIDTxtBox.Text, stuNameTxtBox.Text, stugenderTxtBox.Text, studobTxtBox.Text,
                    stuaddressTxtBox.Text, stupNumTxtBox.Text, stuclassTxtBox.Text, depTxtBox.Text,stuPhoto1);
                b.CancelEdit();
                this.Close();
            }
            bs.ResetBindings(false);
        }
   
        private void closeBtn_Click(object sender, EventArgs e)
        {
            b.CancelEdit();
        }

        private void StudentAddEditForm_Load(object sender, EventArgs e)
        {
            this.Text = title;

            cur = new Student("", "", "", "", "", "", "", "",null);
            if (op == Operation.OP_EDIT)
            {
                cur = (Student)bs.Current;
                id = cur.Id;
            }
            b = new BindingSource(cur, null);
            
            stuIDTxtBox.DataBindings.Add("Text", b, "Id").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            stuNameTxtBox.DataBindings.Add("Text", b, "Name").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            stugenderTxtBox.DataBindings.Add("Text", b, "Gender").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            studobTxtBox.DataBindings.Add("Text", b, "Dob").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            stuclassTxtBox.DataBindings.Add("Text", b, "ClassId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            stupNumTxtBox.DataBindings.Add("Text", b, "PhoneNumber").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            stuaddressTxtBox.DataBindings.Add("Text", b, "Address").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            depTxtBox.DataBindings.Add("Text", b, "DepartmentId").DataSourceUpdateMode = DataSourceUpdateMode.Never;
            studentPic.DataBindings.Add("Image", b, "Photo", true).DataSourceUpdateMode = DataSourceUpdateMode.Never;

            b.ResetBindings(false);

            stuIDTxtBox.KeyPress += ValidateKeyPress;
            stuNameTxtBox.KeyPress += ValidateKeyPress;
            stugenderTxtBox.KeyPress += ValidateKeyPress;
            studobTxtBox.KeyPress += ValidateKeyPress;
            stuclassTxtBox.KeyPress += ValidateKeyPress;
            stupNumTxtBox.KeyPress += ValidateKeyPress;
            stuaddressTxtBox.KeyPress += ValidateKeyPress;
            depTxtBox.KeyPress += ValidateKeyPress;
            
        }

        private void addPhotoBtn_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                studentPic.SizeMode = PictureBoxSizeMode.StretchImage;
                studentPic.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }  
           
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            stuIDTxtBox.Text = "";
            stuNameTxtBox.Text = "";
            stugenderTxtBox.Text = "";
            studobTxtBox.Text = ""; 
            stuclassTxtBox.Text = "";
            stupNumTxtBox.Text = "";
            stuaddressTxtBox.Text = "";
            depTxtBox.Text = "";
            studentPic.Image = null;
        }
    }
}