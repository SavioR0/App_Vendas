
namespace Vendas.View
{
    partial class FormRegisterUser
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
            this.Btn_register_user = new DevExpress.XtraEditors.SimpleButton();
            this.nameValue = new DevExpress.XtraEditors.TextEdit();
            this.cpfValue = new DevExpress.XtraEditors.TextEdit();
            this.telValue = new DevExpress.XtraEditors.TextEdit();
            this.nameLabel = new DevExpress.XtraEditors.LabelControl();
            this.valorLabel = new DevExpress.XtraEditors.LabelControl();
            this.descricaoLabel = new DevExpress.XtraEditors.LabelControl();
            this.dateValue = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.EmailEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.PasswordEdit = new DevExpress.XtraEditors.TextEdit();
            this.ConfirmPasswordEdit = new DevExpress.XtraEditors.TextEdit();
            this.CityEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.CEPEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.NeighborhoodEdit = new DevExpress.XtraEditors.TextEdit();
            this.StreetEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.IsAdmin = new System.Windows.Forms.CheckBox();
            this.Numero = new DevExpress.XtraEditors.LabelControl();
            this.numberEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEPEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeighborhoodEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_register_user
            // 
            this.Btn_register_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_register_user.Location = new System.Drawing.Point(90, 403);
            this.Btn_register_user.Name = "Btn_register_user";
            this.Btn_register_user.Size = new System.Drawing.Size(325, 33);
            this.Btn_register_user.TabIndex = 14;
            this.Btn_register_user.Text = "Cadastrar";
            this.Btn_register_user.Click += new System.EventHandler(this.Btn_register_user_Click);
            // 
            // nameValue
            // 
            this.nameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameValue.Location = new System.Drawing.Point(139, 21);
            this.nameValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(270, 20);
            this.nameValue.TabIndex = 1;
            // 
            // cpfValue
            // 
            this.cpfValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpfValue.Location = new System.Drawing.Point(139, 47);
            this.cpfValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.cpfValue.Name = "cpfValue";
            this.cpfValue.Properties.BeepOnError = false;
            this.cpfValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.cpfValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.cpfValue.Properties.MaskSettings.Set("mask", "000\\.000\\.000-00");
            this.cpfValue.Properties.MaskSettings.Set("hideInsignificantZeros", false);
            this.cpfValue.Properties.UseMaskAsDisplayFormat = true;
            this.cpfValue.Size = new System.Drawing.Size(270, 20);
            this.cpfValue.TabIndex = 2;
            // 
            // telValue
            // 
            this.telValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telValue.Location = new System.Drawing.Point(139, 73);
            this.telValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.telValue.Name = "telValue";
            this.telValue.Properties.BeepOnError = false;
            this.telValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.telValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.telValue.Properties.MaskSettings.Set("mask", "(##) # ########");
            this.telValue.Properties.UseMaskAsDisplayFormat = true;
            this.telValue.Size = new System.Drawing.Size(270, 20);
            this.telValue.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Location = new System.Drawing.Point(102, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "Nome :";
            // 
            // valorLabel
            // 
            this.valorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorLabel.Location = new System.Drawing.Point(84, 76);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(52, 13);
            this.valorLabel.TabIndex = 31;
            this.valorLabel.Text = "Telefone : ";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoLabel.Location = new System.Drawing.Point(107, 50);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(29, 13);
            this.descricaoLabel.TabIndex = 30;
            this.descricaoLabel.Text = "CPF : ";
            // 
            // dateValue
            // 
            this.dateValue.EditValue = null;
            this.dateValue.Location = new System.Drawing.Point(139, 99);
            this.dateValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.dateValue.Name = "dateValue";
            this.dateValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValue.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValue.Size = new System.Drawing.Size(138, 20);
            this.dateValue.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 102);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Data de nasc.: ";
            // 
            // EmailEdit
            // 
            this.EmailEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailEdit.Location = new System.Drawing.Point(139, 284);
            this.EmailEdit.MaximumSize = new System.Drawing.Size(1000, 0);
            this.EmailEdit.Name = "EmailEdit";
            this.EmailEdit.Properties.BeepOnError = false;
            this.EmailEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.EmailEdit.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.EmailEdit.Properties.MaskSettings.Set("mask", "(##) # ########");
            this.EmailEdit.Properties.UseMaskAsDisplayFormat = true;
            this.EmailEdit.Size = new System.Drawing.Size(270, 20);
            this.EmailEdit.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(102, 287);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Email : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(96, 314);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Senha : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(61, 340);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Confir. senha : ";
            // 
            // PasswordEdit
            // 
            this.PasswordEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordEdit.Location = new System.Drawing.Point(139, 311);
            this.PasswordEdit.MaximumSize = new System.Drawing.Size(1000, 0);
            this.PasswordEdit.Name = "PasswordEdit";
            this.PasswordEdit.Properties.BeepOnError = false;
            this.PasswordEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.PasswordEdit.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.PasswordEdit.Properties.MaskSettings.Set("mask", "(##) # ########");
            this.PasswordEdit.Properties.UseMaskAsDisplayFormat = true;
            this.PasswordEdit.Size = new System.Drawing.Size(270, 20);
            this.PasswordEdit.TabIndex = 11;
            // 
            // ConfirmPasswordEdit
            // 
            this.ConfirmPasswordEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmPasswordEdit.Location = new System.Drawing.Point(139, 337);
            this.ConfirmPasswordEdit.MaximumSize = new System.Drawing.Size(1000, 0);
            this.ConfirmPasswordEdit.Name = "ConfirmPasswordEdit";
            this.ConfirmPasswordEdit.Properties.BeepOnError = false;
            this.ConfirmPasswordEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.ConfirmPasswordEdit.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.ConfirmPasswordEdit.Properties.MaskSettings.Set("mask", "(##) # ########");
            this.ConfirmPasswordEdit.Properties.UseMaskAsDisplayFormat = true;
            this.ConfirmPasswordEdit.Size = new System.Drawing.Size(270, 20);
            this.ConfirmPasswordEdit.TabIndex = 12;
            // 
            // CityEdit
            // 
            this.CityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityEdit.Location = new System.Drawing.Point(139, 163);
            this.CityEdit.MaximumSize = new System.Drawing.Size(1000, 0);
            this.CityEdit.Name = "CityEdit";
            this.CityEdit.Properties.BeepOnError = false;
            this.CityEdit.Properties.UseMaskAsDisplayFormat = true;
            this.CityEdit.Size = new System.Drawing.Size(270, 20);
            this.CityEdit.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(105, 140);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "CEP : ";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(98, 192);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 13);
            this.labelControl7.TabIndex = 44;
            this.labelControl7.Text = "Bairro : ";
            // 
            // CEPEdit
            // 
            this.CEPEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CEPEdit.Location = new System.Drawing.Point(139, 137);
            this.CEPEdit.MaximumSize = new System.Drawing.Size(1000, 0);
            this.CEPEdit.Name = "CEPEdit";
            this.CEPEdit.Properties.BeepOnError = false;
            this.CEPEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CEPEdit.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CEPEdit.Properties.MaskSettings.Set("mask", "#####-###");
            this.CEPEdit.Properties.UseMaskAsDisplayFormat = true;
            this.CEPEdit.Size = new System.Drawing.Size(270, 20);
            this.CEPEdit.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Location = new System.Drawing.Point(90, 166);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 13);
            this.labelControl8.TabIndex = 46;
            this.labelControl8.Text = "Cidade :  ";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Location = new System.Drawing.Point(71, 220);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 13);
            this.labelControl9.TabIndex = 47;
            this.labelControl9.Text = "Logradouro : ";
            // 
            // NeighborhoodEdit
            // 
            this.NeighborhoodEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeighborhoodEdit.Location = new System.Drawing.Point(139, 189);
            this.NeighborhoodEdit.MaximumSize = new System.Drawing.Size(1000, 0);
            this.NeighborhoodEdit.Name = "NeighborhoodEdit";
            this.NeighborhoodEdit.Properties.BeepOnError = false;
            this.NeighborhoodEdit.Properties.UseMaskAsDisplayFormat = true;
            this.NeighborhoodEdit.Size = new System.Drawing.Size(270, 20);
            this.NeighborhoodEdit.TabIndex = 7;
            // 
            // StreetEdit
            // 
            this.StreetEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetEdit.Location = new System.Drawing.Point(139, 217);
            this.StreetEdit.MaximumSize = new System.Drawing.Size(1000, 0);
            this.StreetEdit.Name = "StreetEdit";
            this.StreetEdit.Properties.BeepOnError = false;
            this.StreetEdit.Properties.UseMaskAsDisplayFormat = true;
            this.StreetEdit.Size = new System.Drawing.Size(270, 20);
            this.StreetEdit.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(139, 366);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 13);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "Usuário Administrador ? ";
            // 
            // IsAdmin
            // 
            this.IsAdmin.AutoSize = true;
            this.IsAdmin.Location = new System.Drawing.Point(262, 366);
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.Size = new System.Drawing.Size(15, 14);
            this.IsAdmin.TabIndex = 13;
            this.IsAdmin.UseVisualStyleBackColor = true;
            // 
            // Numero
            // 
            this.Numero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Numero.Location = new System.Drawing.Point(84, 246);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(47, 13);
            this.Numero.TabIndex = 53;
            this.Numero.Text = "Número : ";
            // 
            // numberEdit
            // 
            this.numberEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberEdit.Location = new System.Drawing.Point(139, 243);
            this.numberEdit.MaximumSize = new System.Drawing.Size(1000, 0);
            this.numberEdit.Name = "numberEdit";
            this.numberEdit.Properties.BeepOnError = false;
            this.numberEdit.Properties.UseMaskAsDisplayFormat = true;
            this.numberEdit.Size = new System.Drawing.Size(138, 20);
            this.numberEdit.TabIndex = 9;
            // 
            // FormRegisterUser
            // 
            this.AccessibleName = "Cadastro de usuário";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.numberEdit);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.IsAdmin);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.StreetEdit);
            this.Controls.Add(this.NeighborhoodEdit);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.CEPEdit);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.CityEdit);
            this.Controls.Add(this.ConfirmPasswordEdit);
            this.Controls.Add(this.PasswordEdit);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.EmailEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.cpfValue);
            this.Controls.Add(this.telValue);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.Btn_register_user);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(16, 450);
            this.Name = "FormRegisterUser";
            this.Text = "Cadastro de usuário";
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEPEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeighborhoodEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btn_register_user;
        private DevExpress.XtraEditors.TextEdit nameValue;
        private DevExpress.XtraEditors.TextEdit cpfValue;
        public DevExpress.XtraEditors.TextEdit telValue;
        private DevExpress.XtraEditors.LabelControl nameLabel;
        private DevExpress.XtraEditors.LabelControl valorLabel;
        private DevExpress.XtraEditors.LabelControl descricaoLabel;
        private DevExpress.XtraEditors.DateEdit dateValue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit EmailEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.TextEdit PasswordEdit;
        public DevExpress.XtraEditors.TextEdit ConfirmPasswordEdit;
        public DevExpress.XtraEditors.TextEdit CityEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.TextEdit CEPEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.TextEdit NeighborhoodEdit;
        public DevExpress.XtraEditors.TextEdit StreetEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.CheckBox IsAdmin;
        private DevExpress.XtraEditors.LabelControl Numero;
        public DevExpress.XtraEditors.TextEdit numberEdit;
    }
}