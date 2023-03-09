
namespace SchoolManagementSystem.form
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxtbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.resetPasswordBtn = new System.Windows.Forms.LinkLabel();
            this.signUpBtn = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // userNameTxtbox
            // 
            this.userNameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxtbox.Location = new System.Drawing.Point(351, 141);
            this.userNameTxtbox.Name = "userNameTxtbox";
            this.userNameTxtbox.Size = new System.Drawing.Size(212, 28);
            this.userNameTxtbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to ABC school";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(215, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbox.Location = new System.Drawing.Point(351, 207);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(212, 28);
            this.passwordTxtbox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBtn.Location = new System.Drawing.Point(339, 291);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(94, 40);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // resetPasswordBtn
            // 
            this.resetPasswordBtn.AutoSize = true;
            this.resetPasswordBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordBtn.Location = new System.Drawing.Point(372, 249);
            this.resetPasswordBtn.Name = "resetPasswordBtn";
            this.resetPasswordBtn.Size = new System.Drawing.Size(191, 23);
            this.resetPasswordBtn.TabIndex = 4;
            this.resetPasswordBtn.TabStop = true;
            this.resetPasswordBtn.Text = "Forget password ?";
            this.resetPasswordBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetPasswordBtn_LinkClicked);
            // 
            // signUpBtn
            // 
            this.signUpBtn.AutoSize = true;
            this.signUpBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.Location = new System.Drawing.Point(446, 357);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(133, 23);
            this.signUpBtn.TabIndex = 4;
            this.signUpBtn.TabStop = true;
            this.signUpBtn.Text = "Sign Up Now";
            this.signUpBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpBtn_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(199, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Don\'t have account ?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.resetPasswordBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtbox);
            this.Controls.Add(this.userNameTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Administrator Login ";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTxtbox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel resetPasswordBtn;
        private System.Windows.Forms.LinkLabel signUpBtn;
        private System.Windows.Forms.Label label4;
    }
}