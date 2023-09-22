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
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(214, 382);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(239, 33);
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
            this.lbResgisterUser.Location = new System.Drawing.Point(296, 431);
            this.lbResgisterUser.Name = "lbResgisterUser";
            this.lbResgisterUser.Size = new System.Drawing.Size(75, 16);
            this.lbResgisterUser.TabIndex = 1;
            this.lbResgisterUser.Text = "Cadastrar-se";
            this.lbResgisterUser.Click += new System.EventHandler(this.lbResgisterUser_Click);
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 477);
            this.Controls.Add(this.lbResgisterUser);
            this.Controls.Add(this.btn_login);
            this.Name = "LoginUser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.LabelControl lbResgisterUser;
    }
}

