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
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.lbResgisterUser = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.PasswordValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.UserNameValue = new DevExpress.XtraEditors.TextEdit();
            this.UserName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(195, 284);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(239, 27);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // lbResgisterUser
            // 
            this.lbResgisterUser.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResgisterUser.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbResgisterUser.Appearance.Options.UseFont = true;
            this.lbResgisterUser.Appearance.Options.UseForeColor = true;
            this.lbResgisterUser.Location = new System.Drawing.Point(278, 317);
            this.lbResgisterUser.Name = "lbResgisterUser";
            this.lbResgisterUser.Size = new System.Drawing.Size(75, 16);
            this.lbResgisterUser.TabIndex = 1;
            this.lbResgisterUser.Text = "Cadastrar-se";
            this.lbResgisterUser.Click += new System.EventHandler(this.lbResgisterUser_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(548, 402);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Distribuida?";
            this.checkEdit1.Size = new System.Drawing.Size(75, 20);
            this.checkEdit1.TabIndex = 2;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // PasswordValue
            // 
            this.PasswordValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordValue.EditValue = "123456";
            this.PasswordValue.Location = new System.Drawing.Point(136, 232);
            this.PasswordValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.PasswordValue.Name = "PasswordValue";
            this.PasswordValue.Properties.BeepOnError = false;
            this.PasswordValue.Properties.UseMaskAsDisplayFormat = true;
            this.PasswordValue.Properties.UseSystemPasswordChar = true;
            this.PasswordValue.Size = new System.Drawing.Size(380, 20);
            this.PasswordValue.TabIndex = 40;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(91, 235);
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
            this.UserNameValue.Location = new System.Drawing.Point(136, 205);
            this.UserNameValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.UserNameValue.Name = "UserNameValue";
            this.UserNameValue.Properties.BeepOnError = false;
            this.UserNameValue.Properties.UseMaskAsDisplayFormat = true;
            this.UserNameValue.Size = new System.Drawing.Size(380, 20);
            this.UserNameValue.TabIndex = 39;
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.Location = new System.Drawing.Point(71, 208);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(59, 13);
            this.UserName.TabIndex = 41;
            this.UserName.Text = "UserName : ";
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 434);
            this.Controls.Add(this.PasswordValue);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.UserNameValue);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.lbResgisterUser);
            this.Controls.Add(this.btn_login);
            this.Name = "LoginUser";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.LabelControl lbResgisterUser;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        public DevExpress.XtraEditors.TextEdit PasswordValue;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit UserNameValue;
        private DevExpress.XtraEditors.LabelControl UserName;
    }
}

