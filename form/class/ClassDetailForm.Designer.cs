
namespace SchoolManagementSystem
{
    partial class ClassDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassDetailForm));
            this.dgvClassroom = new System.Windows.Forms.DataGridView();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteClassBtn = new System.Windows.Forms.Button();
            this.updateClassBtn = new System.Windows.Forms.Button();
            this.addNewClassBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassroom
            // 
            this.dgvClassroom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassroom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassroom.Location = new System.Drawing.Point(12, 223);
            this.dgvClassroom.Name = "dgvClassroom";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassroom.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClassroom.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClassroom.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClassroom.RowTemplate.Height = 24;
            this.dgvClassroom.Size = new System.Drawing.Size(1176, 441);
            this.dgvClassroom.TabIndex = 17;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(834, 157);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(216, 22);
            this.searchTxtBox.TabIndex = 16;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(1075, 154);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(107, 32);
            this.SearchBtn.TabIndex = 15;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search By Class ID";
            // 
            // deleteClassBtn
            // 
            this.deleteClassBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClassBtn.Location = new System.Drawing.Point(418, 84);
            this.deleteClassBtn.Name = "deleteClassBtn";
            this.deleteClassBtn.Size = new System.Drawing.Size(189, 51);
            this.deleteClassBtn.TabIndex = 12;
            this.deleteClassBtn.Text = "Delete Class";
            this.deleteClassBtn.UseVisualStyleBackColor = true;
            this.deleteClassBtn.Click += new System.EventHandler(this.deleteClassBtn_Click);
            // 
            // updateClassBtn
            // 
            this.updateClassBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateClassBtn.Location = new System.Drawing.Point(223, 84);
            this.updateClassBtn.Name = "updateClassBtn";
            this.updateClassBtn.Size = new System.Drawing.Size(189, 51);
            this.updateClassBtn.TabIndex = 11;
            this.updateClassBtn.Text = "Update Class";
            this.updateClassBtn.UseVisualStyleBackColor = true;
            this.updateClassBtn.Click += new System.EventHandler(this.updateClassBtn_Click);
            // 
            // addNewClassBtn
            // 
            this.addNewClassBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewClassBtn.Location = new System.Drawing.Point(28, 84);
            this.addNewClassBtn.Name = "addNewClassBtn";
            this.addNewClassBtn.Size = new System.Drawing.Size(189, 51);
            this.addNewClassBtn.TabIndex = 10;
            this.addNewClassBtn.Text = "Add New Class";
            this.addNewClassBtn.UseVisualStyleBackColor = true;
            this.addNewClassBtn.Click += new System.EventHandler(this.addNewClassBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Class Detail";
            // 
            // ClassDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 676);
            this.Controls.Add(this.dgvClassroom);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteClassBtn);
            this.Controls.Add(this.updateClassBtn);
            this.Controls.Add(this.addNewClassBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClassDetailForm";
            this.Text = "Class Detail";
            this.Load += new System.EventHandler(this.ClassDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassroom;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteClassBtn;
        private System.Windows.Forms.Button updateClassBtn;
        private System.Windows.Forms.Button addNewClassBtn;
        private System.Windows.Forms.Label label1;
    }
}