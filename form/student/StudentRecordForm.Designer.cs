
namespace SchoolManagementSystem
{
    partial class StudentRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addNewStudent = new System.Windows.Forms.Button();
            this.dgvStudentRecord = new System.Windows.Forms.DataGridView();
            this.updateStudent = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewStudent
            // 
            this.addNewStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewStudent.Location = new System.Drawing.Point(22, 75);
            this.addNewStudent.Name = "addNewStudent";
            this.addNewStudent.Size = new System.Drawing.Size(141, 62);
            this.addNewStudent.TabIndex = 0;
            this.addNewStudent.Text = "Add New Student";
            this.addNewStudent.UseVisualStyleBackColor = true;
            this.addNewStudent.Click += new System.EventHandler(this.addNewStudent_Click);
            // 
            // dgvStudentRecord
            // 
            this.dgvStudentRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentRecord.Location = new System.Drawing.Point(12, 212);
            this.dgvStudentRecord.Name = "dgvStudentRecord";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudentRecord.RowHeadersWidth = 51;
            this.dgvStudentRecord.RowTemplate.Height = 24;
            this.dgvStudentRecord.Size = new System.Drawing.Size(1175, 452);
            this.dgvStudentRecord.TabIndex = 1;
            // 
            // updateStudent
            // 
            this.updateStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudent.Location = new System.Drawing.Point(185, 75);
            this.updateStudent.Name = "updateStudent";
            this.updateStudent.Size = new System.Drawing.Size(141, 62);
            this.updateStudent.TabIndex = 0;
            this.updateStudent.Text = "Update Student";
            this.updateStudent.UseVisualStyleBackColor = true;
            this.updateStudent.Click += new System.EventHandler(this.updateStudent_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStudent.Location = new System.Drawing.Point(344, 75);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(141, 62);
            this.deleteStudent.TabIndex = 0;
            this.deleteStudent.Text = "Delete Student";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(769, 155);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(216, 22);
            this.searchTxtBox.TabIndex = 37;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(1010, 152);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(107, 32);
            this.SearchBtn.TabIndex = 36;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Search By Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "Student Record";
            // 
            // StudentRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.updateStudent);
            this.Controls.Add(this.addNewStudent);
            this.Controls.Add(this.dgvStudentRecord);
            this.Name = "StudentRecordForm";
            this.Text = "Student Record";
            this.Load += new System.EventHandler(this.StudentRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewStudent;
        private System.Windows.Forms.DataGridView dgvStudentRecord;
        private System.Windows.Forms.Button updateStudent;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

