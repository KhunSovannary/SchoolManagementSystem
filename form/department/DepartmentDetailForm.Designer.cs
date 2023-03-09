namespace SchoolManagementSystem.form.department
{
    partial class DepartmentDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentDetailForm));
            this.dgvDep = new System.Windows.Forms.DataGridView();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteDepBtn = new System.Windows.Forms.Button();
            this.updateDepBtn = new System.Windows.Forms.Button();
            this.addNewDepBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDep)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDep
            // 
            this.dgvDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDep.Location = new System.Drawing.Point(12, 204);
            this.dgvDep.Name = "dgvDep";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDep.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDep.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDep.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDep.RowTemplate.Height = 24;
            this.dgvDep.Size = new System.Drawing.Size(1167, 440);
            this.dgvDep.TabIndex = 35;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(830, 149);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(216, 22);
            this.searchTxtBox.TabIndex = 34;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(1071, 146);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(107, 32);
            this.SearchBtn.TabIndex = 33;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Search By Department ID";
            // 
            // deleteDepBtn
            // 
            this.deleteDepBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDepBtn.Location = new System.Drawing.Point(414, 76);
            this.deleteDepBtn.Name = "deleteDepBtn";
            this.deleteDepBtn.Size = new System.Drawing.Size(189, 67);
            this.deleteDepBtn.TabIndex = 30;
            this.deleteDepBtn.Text = "Delete Department";
            this.deleteDepBtn.UseVisualStyleBackColor = true;
            this.deleteDepBtn.Click += new System.EventHandler(this.deleteDepBtn_Click);
            // 
            // updateDepBtn
            // 
            this.updateDepBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDepBtn.Location = new System.Drawing.Point(219, 76);
            this.updateDepBtn.Name = "updateDepBtn";
            this.updateDepBtn.Size = new System.Drawing.Size(189, 67);
            this.updateDepBtn.TabIndex = 29;
            this.updateDepBtn.Text = "Update Department";
            this.updateDepBtn.UseVisualStyleBackColor = true;
            this.updateDepBtn.Click += new System.EventHandler(this.updateDepBtn_Click);
            // 
            // addNewDepBtn
            // 
            this.addNewDepBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewDepBtn.Location = new System.Drawing.Point(24, 76);
            this.addNewDepBtn.Name = "addNewDepBtn";
            this.addNewDepBtn.Size = new System.Drawing.Size(189, 67);
            this.addNewDepBtn.TabIndex = 28;
            this.addNewDepBtn.Text = "Add New Department";
            this.addNewDepBtn.UseVisualStyleBackColor = true;
            this.addNewDepBtn.Click += new System.EventHandler(this.addNewDepBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Department Detail";
            // 
            // DepartmentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 676);
            this.Controls.Add(this.dgvDep);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteDepBtn);
            this.Controls.Add(this.updateDepBtn);
            this.Controls.Add(this.addNewDepBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DepartmentDetailForm";
            this.Text = "Department Detail";
            this.Load += new System.EventHandler(this.DepartmentDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDep;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteDepBtn;
        private System.Windows.Forms.Button updateDepBtn;
        private System.Windows.Forms.Button addNewDepBtn;
        private System.Windows.Forms.Label label1;
    }
}