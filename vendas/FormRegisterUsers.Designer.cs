
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
            this.EmailValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.CityValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.CEPValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.NeighborhoodValue = new DevExpress.XtraEditors.TextEdit();
            this.StreetValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.IsAdminValue = new System.Windows.Forms.CheckBox();
            this.Numero = new DevExpress.XtraEditors.LabelControl();
            this.numberValue = new DevExpress.XtraEditors.TextEdit();
            this.LastNameValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEPValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeighborhoodValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_register_user
            // 
            this.Btn_register_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_register_user.Location = new System.Drawing.Point(84, 366);
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
            this.cpfValue.Location = new System.Drawing.Point(139, 73);
            this.cpfValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.cpfValue.Name = "cpfValue";
            this.cpfValue.Properties.BeepOnError = false;
            this.cpfValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.cpfValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.cpfValue.Properties.MaskSettings.Set("mask", "000\\.000\\.000-00");
            this.cpfValue.Properties.MaskSettings.Set("hideInsignificantZeros", false);
            this.cpfValue.Properties.UseMaskAsDisplayFormat = true;
            this.cpfValue.Size = new System.Drawing.Size(270, 20);
            this.cpfValue.TabIndex = 3;
            // 
            // telValue
            // 
            this.telValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telValue.Location = new System.Drawing.Point(139, 99);
            this.telValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.telValue.Name = "telValue";
            this.telValue.Properties.BeepOnError = false;
            this.telValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.telValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.telValue.Properties.MaskSettings.Set("mask", "(##) # ########");
            this.telValue.Properties.UseMaskAsDisplayFormat = true;
            this.telValue.Size = new System.Drawing.Size(270, 20);
            this.telValue.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Location = new System.Drawing.Point(97, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 13);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "Nome : ";
            // 
            // valorLabel
            // 
            this.valorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorLabel.Location = new System.Drawing.Point(82, 102);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(52, 13);
            this.valorLabel.TabIndex = 31;
            this.valorLabel.Text = "Telefone : ";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoLabel.Location = new System.Drawing.Point(105, 76);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(29, 13);
            this.descricaoLabel.TabIndex = 30;
            this.descricaoLabel.Text = "CPF : ";
            // 
            // dateValue
            // 
            this.dateValue.EditValue = null;
            this.dateValue.Location = new System.Drawing.Point(139, 125);
            this.dateValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.dateValue.Name = "dateValue";
            this.dateValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValue.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValue.Size = new System.Drawing.Size(138, 20);
            this.dateValue.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(60, 128);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Data de nasc.: ";
            // 
            // EmailValue
            // 
            this.EmailValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailValue.Location = new System.Drawing.Point(139, 310);
            this.EmailValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Properties.BeepOnError = false;
            this.EmailValue.Properties.UseMaskAsDisplayFormat = true;
            this.EmailValue.Size = new System.Drawing.Size(270, 20);
            this.EmailValue.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(100, 313);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Email : ";
            // 
            // CityValue
            // 
            this.CityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityValue.Location = new System.Drawing.Point(139, 189);
            this.CityValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.CityValue.Name = "CityValue";
            this.CityValue.Properties.BeepOnError = false;
            this.CityValue.Properties.UseMaskAsDisplayFormat = true;
            this.CityValue.Size = new System.Drawing.Size(270, 20);
            this.CityValue.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(105, 166);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "CEP : ";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(96, 218);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 13);
            this.labelControl7.TabIndex = 44;
            this.labelControl7.Text = "Bairro : ";
            // 
            // CEPValue
            // 
            this.CEPValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CEPValue.Location = new System.Drawing.Point(139, 163);
            this.CEPValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.CEPValue.Name = "CEPValue";
            this.CEPValue.Properties.BeepOnError = false;
            this.CEPValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CEPValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CEPValue.Properties.MaskSettings.Set("mask", "#####-###");
            this.CEPValue.Properties.UseMaskAsDisplayFormat = true;
            this.CEPValue.Size = new System.Drawing.Size(270, 20);
            this.CEPValue.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Location = new System.Drawing.Point(88, 192);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 13);
            this.labelControl8.TabIndex = 46;
            this.labelControl8.Text = "Cidade :  ";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Location = new System.Drawing.Point(69, 246);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 13);
            this.labelControl9.TabIndex = 47;
            this.labelControl9.Text = "Logradouro : ";
            // 
            // NeighborhoodValue
            // 
            this.NeighborhoodValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeighborhoodValue.Location = new System.Drawing.Point(139, 215);
            this.NeighborhoodValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.NeighborhoodValue.Name = "NeighborhoodValue";
            this.NeighborhoodValue.Properties.BeepOnError = false;
            this.NeighborhoodValue.Properties.UseMaskAsDisplayFormat = true;
            this.NeighborhoodValue.Size = new System.Drawing.Size(270, 20);
            this.NeighborhoodValue.TabIndex = 8;
            // 
            // StreetValue
            // 
            this.StreetValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetValue.Location = new System.Drawing.Point(139, 243);
            this.StreetValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.StreetValue.Name = "StreetValue";
            this.StreetValue.Properties.BeepOnError = false;
            this.StreetValue.Properties.UseMaskAsDisplayFormat = true;
            this.StreetValue.Size = new System.Drawing.Size(270, 20);
            this.StreetValue.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(80, 337);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "Vendedor? ";
            // 
            // IsAdminValue
            // 
            this.IsAdminValue.AutoSize = true;
            this.IsAdminValue.Location = new System.Drawing.Point(139, 337);
            this.IsAdminValue.Name = "IsAdminValue";
            this.IsAdminValue.Size = new System.Drawing.Size(15, 14);
            this.IsAdminValue.TabIndex = 14;
            this.IsAdminValue.UseVisualStyleBackColor = true;
            // 
            // Numero
            // 
            this.Numero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Numero.Location = new System.Drawing.Point(87, 272);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(47, 13);
            this.Numero.TabIndex = 53;
            this.Numero.Text = "Número : ";
            // 
            // numberValue
            // 
            this.numberValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberValue.Location = new System.Drawing.Point(139, 269);
            this.numberValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.numberValue.Name = "numberValue";
            this.numberValue.Properties.BeepOnError = false;
            this.numberValue.Properties.UseMaskAsDisplayFormat = true;
            this.numberValue.Size = new System.Drawing.Size(138, 20);
            this.numberValue.TabIndex = 10;
            // 
            // LastNameValue
            // 
            this.LastNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameValue.Location = new System.Drawing.Point(139, 47);
            this.LastNameValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(270, 20);
            this.LastNameValue.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Location = new System.Drawing.Point(70, 50);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(64, 13);
            this.labelControl10.TabIndex = 55;
            this.labelControl10.Text = "Sobrenome : ";
            // 
            // FormRegisterUser
            // 
            this.AccessibleName = "Cadastro de usuário";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.LastNameValue);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.numberValue);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.IsAdminValue);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.StreetValue);
            this.Controls.Add(this.NeighborhoodValue);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.CEPValue);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.CityValue);
            this.Controls.Add(this.EmailValue);
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
            this.MaximumSize = new System.Drawing.Size(500, 550);
            this.MinimumSize = new System.Drawing.Size(16, 450);
            this.Name = "FormRegisterUser";
            this.Text = "Cadastro de usuário";
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEPValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeighborhoodValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameValue.Properties)).EndInit();
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
        public DevExpress.XtraEditors.TextEdit EmailValue;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit CityValue;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.TextEdit CEPValue;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.TextEdit NeighborhoodValue;
        public DevExpress.XtraEditors.TextEdit StreetValue;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.CheckBox IsAdminValue;
        private DevExpress.XtraEditors.LabelControl Numero;
        public DevExpress.XtraEditors.TextEdit numberValue;
        private DevExpress.XtraEditors.TextEdit LastNameValue;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}