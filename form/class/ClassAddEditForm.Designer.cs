
namespace SchoolManagementSystem
{
    partial class ClassAddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassAddEditForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.equipID = new System.Windows.Forms.Label();
            this.classIDTxtBox = new System.Windows.Forms.TextBox();
            this.classNameTxtBox = new System.Windows.Forms.TextBox();
            this.teacherIDTxtBox = new System.Windows.Forms.TextBox();
            this.stuCountTxtBox = new System.Windows.Forms.TextBox();
            this.equipIDTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(401, 358);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(122, 37);
            this.closeBtn.TabIndex = 89;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(249, 358);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(122, 37);
            this.clearBtn.TabIndex = 88;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(90, 358);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(122, 37);
            this.saveBtn.TabIndex = 87;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Class Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Class ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 34);
            this.label1.TabIndex = 63;
            this.label1.Text = "Class";
            // 
            // equipID
            // 
            this.equipID.AutoSize = true;
            this.equipID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipID.Location = new System.Drawing.Point(47, 292);
            this.equipID.Name = "equipID";
            this.equipID.Size = new System.Drawing.Size(141, 23);
            this.equipID.TabIndex = 93;
            this.equipID.Text = "Equipment ID";
            // 
            // classIDTxtBox
            // 
            this.classIDTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classIDTxtBox.Location = new System.Drawing.Point(209, 72);
            this.classIDTxtBox.Name = "classIDTxtBox";
            this.classIDTxtBox.Size = new System.Drawing.Size(376, 32);
            this.classIDTxtBox.TabIndex = 92;
            // 
            // classNameTxtBox
            // 
            this.classNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameTxtBox.Location = new System.Drawing.Point(209, 126);
            this.classNameTxtBox.Name = "classNameTxtBox";
            this.classNameTxtBox.Size = new System.Drawing.Size(376, 32);
            this.classNameTxtBox.TabIndex = 92;
            // 
            // teacherIDTxtBox
            // 
            this.teacherIDTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherIDTxtBox.Location = new System.Drawing.Point(209, 176);
            this.teacherIDTxtBox.Name = "teacherIDTxtBox";
            this.teacherIDTxtBox.Size = new System.Drawing.Size(376, 32);
            this.teacherIDTxtBox.TabIndex = 92;
            // 
            // stuCountTxtBox
            // 
            this.stuCountTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuCountTxtBox.Location = new System.Drawing.Point(209, 231);
            this.stuCountTxtBox.Name = "stuCountTxtBox";
            this.stuCountTxtBox.Size = new System.Drawing.Size(376, 32);
            this.stuCountTxtBox.TabIndex = 92;
            // 
            // equipIDTxtBox
            // 
            this.equipIDTxtBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipIDTxtBox.Location = new System.Drawing.Point(209, 283);
            this.equipIDTxtBox.Name = "equipIDTxtBox";
            this.equipIDTxtBox.Size = new System.Drawing.Size(376, 32);
            this.equipIDTxtBox.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 66;
            this.label7.Text = "Teacher ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 23);
            this.label8.TabIndex = 66;
            this.label8.Text = "Student Count";
            // 
            // ClassAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 439);
            this.Controls.Add(this.equipID);
            this.Controls.Add(this.equipIDTxtBox);
            this.Controls.Add(this.stuCountTxtBox);
            this.Controls.Add(this.teacherIDTxtBox);
            this.Controls.Add(this.classNameTxtBox);
            this.Controls.Add(this.classIDTxtBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClassAddEditForm";
            this.Text = "AddNewClassForm";
            this.Load += new System.EventHandler(this.ClassAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label equipID;
        private System.Windows.Forms.TextBox classIDTxtBox;
        private System.Windows.Forms.TextBox classNameTxtBox;
        private System.Windows.Forms.TextBox teacherIDTxtBox;
        private System.Windows.Forms.TextBox stuCountTxtBox;
        private System.Windows.Forms.TextBox equipIDTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}