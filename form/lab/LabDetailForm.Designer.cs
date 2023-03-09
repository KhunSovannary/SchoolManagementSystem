namespace SchoolManagementSystem.form.lab
{
    partial class LabDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabDetailForm));
            this.dgvLab = new System.Windows.Forms.DataGridView();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteLabBtn = new System.Windows.Forms.Button();
            this.updateLabBtn = new System.Windows.Forms.Button();
            this.addNewLabBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLab)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLab
            // 
            this.dgvLab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLab.Location = new System.Drawing.Point(11, 223);
            this.dgvLab.Name = "dgvLab";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLab.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLab.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLab.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLab.RowTemplate.Height = 24;
            this.dgvLab.Size = new System.Drawing.Size(1176, 441);
            this.dgvLab.TabIndex = 44;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(830, 146);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(216, 22);
            this.searchTxtBox.TabIndex = 43;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(1071, 143);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(107, 32);
            this.SearchBtn.TabIndex = 42;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(652, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Search By Lab ID";
            // 
            // deleteLabBtn
            // 
            this.deleteLabBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabBtn.Location = new System.Drawing.Point(414, 73);
            this.deleteLabBtn.Name = "deleteLabBtn";
            this.deleteLabBtn.Size = new System.Drawing.Size(189, 51);
            this.deleteLabBtn.TabIndex = 39;
            this.deleteLabBtn.Text = "Delete Lab";
            this.deleteLabBtn.UseVisualStyleBackColor = true;
            this.deleteLabBtn.Click += new System.EventHandler(this.deleteLabBtn_Click);
            // 
            // updateLabBtn
            // 
            this.updateLabBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabBtn.Location = new System.Drawing.Point(219, 73);
            this.updateLabBtn.Name = "updateLabBtn";
            this.updateLabBtn.Size = new System.Drawing.Size(189, 51);
            this.updateLabBtn.TabIndex = 38;
            this.updateLabBtn.Text = "Update Lab";
            this.updateLabBtn.UseVisualStyleBackColor = true;
            this.updateLabBtn.Click += new System.EventHandler(this.updateLabBtn_Click);
            // 
            // addNewLabBtn
            // 
            this.addNewLabBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewLabBtn.Location = new System.Drawing.Point(24, 73);
            this.addNewLabBtn.Name = "addNewLabBtn";
            this.addNewLabBtn.Size = new System.Drawing.Size(189, 51);
            this.addNewLabBtn.TabIndex = 37;
            this.addNewLabBtn.Text = "Add New Lab";
            this.addNewLabBtn.UseVisualStyleBackColor = true;
            this.addNewLabBtn.Click += new System.EventHandler(this.addNewLabBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "Lab Detail";
            // 
            // LabDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 676);
            this.Controls.Add(this.dgvLab);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteLabBtn);
            this.Controls.Add(this.updateLabBtn);
            this.Controls.Add(this.addNewLabBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LabDetailForm";
            this.Text = "Lab Detail";
            this.Load += new System.EventHandler(this.LabDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLab;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteLabBtn;
        private System.Windows.Forms.Button updateLabBtn;
        private System.Windows.Forms.Button addNewLabBtn;
        private System.Windows.Forms.Label label1;
    }
}