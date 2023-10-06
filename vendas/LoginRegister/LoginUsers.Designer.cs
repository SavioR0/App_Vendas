using System;
using System.Windows.Forms;

namespace Vendas.View
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.PasswordValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.UserNameValue = new DevExpress.XtraEditors.TextEdit();
            this.UserName = new DevExpress.XtraEditors.LabelControl();
            this.pictureBoxPerfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.Location = new System.Drawing.Point(187, 256);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(239, 27);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit1.Location = new System.Drawing.Point(504, 320);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Distribuida?";
            this.checkEdit1.Size = new System.Drawing.Size(75, 20);
            this.checkEdit1.TabIndex = 2;
            this.checkEdit1.Visible = false;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // PasswordValue
            // 
            this.PasswordValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordValue.EditValue = "123456";
            this.PasswordValue.Location = new System.Drawing.Point(153, 210);
            this.PasswordValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.PasswordValue.Name = "PasswordValue";
            this.PasswordValue.Properties.BeepOnError = false;
            this.PasswordValue.Properties.UseMaskAsDisplayFormat = true;
            this.PasswordValue.Properties.UseSystemPasswordChar = true;
            this.PasswordValue.Size = new System.Drawing.Size(336, 20);
            this.PasswordValue.TabIndex = 40;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(108, 213);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Senha : ";
            // 
            // UserNameValue
            // 
            this.UserNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameValue.EditValue = "saviorodrigues14";
            this.UserNameValue.Location = new System.Drawing.Point(153, 183);
            this.UserNameValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.UserNameValue.Name = "UserNameValue";
            this.UserNameValue.Properties.BeepOnError = false;
            this.UserNameValue.Properties.UseMaskAsDisplayFormat = true;
            this.UserNameValue.Size = new System.Drawing.Size(336, 20);
            this.UserNameValue.TabIndex = 39;
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.Location = new System.Drawing.Point(88, 186);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(59, 13);
            this.UserName.TabIndex = 41;
            this.UserName.Text = "UserName : ";
            // 
            // pictureBoxPerfile
            // 
            this.pictureBoxPerfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPerfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPerfile.Image")));
            this.pictureBoxPerfile.Location = new System.Drawing.Point(233, 36);
            this.pictureBoxPerfile.Name = "pictureBoxPerfile";
            this.pictureBoxPerfile.Size = new System.Drawing.Size(143, 119);
            this.pictureBoxPerfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPerfile.TabIndex = 43;
            this.pictureBoxPerfile.TabStop = false;
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 352);
            this.Controls.Add(this.pictureBoxPerfile);
            this.Controls.Add(this.PasswordValue);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.UserNameValue);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.btn_login);
            this.MinimumSize = new System.Drawing.Size(607, 391);
            this.Name = "LoginUser";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        public DevExpress.XtraEditors.TextEdit PasswordValue;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit UserNameValue;
        private DevExpress.XtraEditors.LabelControl UserName;
        private PictureBox pictureBoxPerfile;
    }
}

