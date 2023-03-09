
namespace SchoolManagementSystem.form.equipment.labequipment
{
    partial class LabEquipmentDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabEquipmentDetailForm));
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLabEquipment = new System.Windows.Forms.DataGridView();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.updateEquipBtn = new System.Windows.Forms.Button();
            this.addNewEquipBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 34);
            this.label3.TabIndex = 43;
            this.label3.Text = "Lab Equipment Detail";
            // 
            // dgvLabEquipment
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvLabEquipment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLabEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLabEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLabEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabEquipment.Location = new System.Drawing.Point(24, 221);
            this.dgvLabEquipment.Name = "dgvLabEquipment";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLabEquipment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLabEquipment.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLabEquipment.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLabEquipment.RowTemplate.Height = 24;
            this.dgvLabEquipment.Size = new System.Drawing.Size(1151, 428);
            this.dgvLabEquipment.TabIndex = 42;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(846, 169);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(216, 32);
            this.searchTxtBox.TabIndex = 41;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(1068, 169);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(107, 32);
            this.SearchBtn.TabIndex = 40;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Search By ID:";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(464, 103);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(189, 67);
            this.Delete.TabIndex = 38;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // updateEquipBtn
            // 
            this.updateEquipBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEquipBtn.Location = new System.Drawing.Point(253, 103);
            this.updateEquipBtn.Name = "updateEquipBtn";
            this.updateEquipBtn.Size = new System.Drawing.Size(205, 67);
            this.updateEquipBtn.TabIndex = 37;
            this.updateEquipBtn.Text = "Update Equipment";
            this.updateEquipBtn.UseVisualStyleBackColor = true;
            this.updateEquipBtn.Click += new System.EventHandler(this.updateEquipBtn_Click);
            // 
            // addNewEquipBtn
            // 
            this.addNewEquipBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewEquipBtn.Location = new System.Drawing.Point(23, 103);
            this.addNewEquipBtn.Name = "addNewEquipBtn";
            this.addNewEquipBtn.Size = new System.Drawing.Size(224, 67);
            this.addNewEquipBtn.TabIndex = 36;
            this.addNewEquipBtn.Text = "Add New Equipment";
            this.addNewEquipBtn.UseVisualStyleBackColor = true;
            this.addNewEquipBtn.Click += new System.EventHandler(this.addNewEquipBtn_Click);
            // 
            // LabEquipmentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 676);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLabEquipment);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.updateEquipBtn);
            this.Controls.Add(this.addNewEquipBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LabEquipmentDetailForm";
            this.Text = "LabEquipment Detail";
            this.Load += new System.EventHandler(this.LabEquipmentDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLabEquipment;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button updateEquipBtn;
        private System.Windows.Forms.Button addNewEquipBtn;
    }
}