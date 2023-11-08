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
            this.PasswordValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.UserNameValue = new DevExpress.XtraEditors.TextEdit();
            this.UserName = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameValue.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(245, 207);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 30);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "&Login";
            this.btn_login.ToolTip = "L - Relizar login";
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // PasswordValue
            // 
            this.PasswordValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PasswordValue.EditValue = "123456";
            this.PasswordValue.Location = new System.Drawing.Point(113, 154);
            this.PasswordValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.PasswordValue.Name = "PasswordValue";
            this.PasswordValue.Properties.BeepOnError = false;
            this.PasswordValue.Properties.UseMaskAsDisplayFormat = true;
            this.PasswordValue.Properties.UseSystemPasswordChar = true;
            this.PasswordValue.Size = new System.Drawing.Size(365, 20);
            this.PasswordValue.TabIndex = 40;
            this.PasswordValue.ToolTip = "Informe a senha";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(113, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Senha";
            // 
            // UserNameValue
            // 
            this.UserNameValue.EditValue = "sáviorodrigues14";
            this.UserNameValue.Location = new System.Drawing.Point(113, 109);
            this.UserNameValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.UserNameValue.Name = "UserNameValue";
            this.UserNameValue.Properties.BeepOnError = false;
            this.UserNameValue.Properties.UseMaskAsDisplayFormat = true;
            this.UserNameValue.Size = new System.Drawing.Size(365, 20);
            this.UserNameValue.TabIndex = 39;
            this.UserNameValue.ToolTip = "Informe o usuário";
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.Location = new System.Drawing.Point(113, 90);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(36, 13);
            this.UserName.TabIndex = 41;
            this.UserName.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "1.0.10.0 em 27/10/2023";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserNameValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkEdit1);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.PasswordValue);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 360);
            this.panel1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Copyright ©  Savio\'s Vendas";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(258, 328);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Distribuida?";
            this.checkEdit1.Size = new System.Drawing.Size(75, 20);
            this.checkEdit1.TabIndex = 2;
            this.checkEdit1.Visible = false;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.CheckEdit1_CheckedChanged);
            // 
            // LoginUser
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 360);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(607, 391);
            this.Name = "LoginUser";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameValue.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_login;
        public DevExpress.XtraEditors.TextEdit PasswordValue;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit UserNameValue;
        private DevExpress.XtraEditors.LabelControl UserName;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}

