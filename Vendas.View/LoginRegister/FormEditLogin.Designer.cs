
namespace Vendas.View
{
    partial class FormEditLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditLogin));
            this.ConfirmPasswordValue = new DevExpress.XtraEditors.TextEdit();
            this.PasswordValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_register_user = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmPasswordValue
            // 
            this.ConfirmPasswordValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmPasswordValue.Location = new System.Drawing.Point(128, 96);
            this.ConfirmPasswordValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.ConfirmPasswordValue.Name = "ConfirmPasswordValue";
            this.ConfirmPasswordValue.Properties.BeepOnError = false;
            this.ConfirmPasswordValue.Properties.UseMaskAsDisplayFormat = true;
            this.ConfirmPasswordValue.Properties.UseSystemPasswordChar = true;
            this.ConfirmPasswordValue.Size = new System.Drawing.Size(273, 20);
            this.ConfirmPasswordValue.TabIndex = 41;
            this.ConfirmPasswordValue.ToolTip = "Inofrme a senha para confirmação";
            // 
            // PasswordValue
            // 
            this.PasswordValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordValue.Location = new System.Drawing.Point(128, 70);
            this.PasswordValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.PasswordValue.Name = "PasswordValue";
            this.PasswordValue.Properties.BeepOnError = false;
            this.PasswordValue.Properties.UseMaskAsDisplayFormat = true;
            this.PasswordValue.Properties.UseSystemPasswordChar = true;
            this.PasswordValue.Size = new System.Drawing.Size(273, 20);
            this.PasswordValue.TabIndex = 40;
            this.PasswordValue.ToolTip = "Informe a nova senha";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(47, 99);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Confir. senha : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(54, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Nova Senha : ";
            // 
            // Btn_register_user
            // 
            this.Btn_register_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_register_user.Location = new System.Drawing.Point(199, 145);
            this.Btn_register_user.Name = "Btn_register_user";
            this.Btn_register_user.Size = new System.Drawing.Size(100, 30);
            this.Btn_register_user.TabIndex = 44;
            this.Btn_register_user.Text = "Cadastrar";
            this.Btn_register_user.ToolTip = "C- Confirmar Edição de Senha";
            this.Btn_register_user.Click += new System.EventHandler(this.Btn_register_user_Click);
            // 
            // FormEditLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 210);
            this.Controls.Add(this.Btn_register_user);
            this.Controls.Add(this.ConfirmPasswordValue);
            this.Controls.Add(this.PasswordValue);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(483, 249);
            this.MinimumSize = new System.Drawing.Size(483, 249);
            this.Name = "FormEditLogin";
            this.Text = "Editar Senha";
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.TextEdit ConfirmPasswordValue;
        public DevExpress.XtraEditors.TextEdit PasswordValue;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton Btn_register_user;
    }
}