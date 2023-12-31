﻿
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterUser));
            this.LastNameValue = new DevExpress.XtraEditors.TextEdit();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.numberValue = new DevExpress.XtraEditors.TextEdit();
            this.bindingSourceAddress = new System.Windows.Forms.BindingSource(this.components);
            this.Numero = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.StreetValue = new DevExpress.XtraEditors.TextEdit();
            this.DistrictValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.CityValue = new DevExpress.XtraEditors.TextEdit();
            this.EmailValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateValue = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nameValue = new DevExpress.XtraEditors.TextEdit();
            this.nameLabel = new DevExpress.XtraEditors.LabelControl();
            this.valorLabel = new DevExpress.XtraEditors.LabelControl();
            this.descricaoLabel = new DevExpress.XtraEditors.LabelControl();
            this.Btn_register_user = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditTypeUser = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnRegisterBiometricPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelBiomerticAlert = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.CEPValue = new System.Windows.Forms.MaskedTextBox();
            this.cpfValue = new System.Windows.Forms.MaskedTextBox();
            this.telValue = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.StateValue = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistrictValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTypeUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StateValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LastNameValue
            // 
            this.LastNameValue.EditValue = "";
            this.LastNameValue.Location = new System.Drawing.Point(107, 69);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(517, 20);
            this.LastNameValue.TabIndex = 2;
            this.LastNameValue.ToolTip = "Informe o sobrenome do usuário";
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataSource = typeof(Vendas.Entity.Entities.User);
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Location = new System.Drawing.Point(107, 52);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(57, 13);
            this.labelControl10.TabIndex = 105;
            this.labelControl10.Text = "Sobrenome ";
            // 
            // numberValue
            // 
            this.numberValue.EditValue = "";
            this.numberValue.Location = new System.Drawing.Point(107, 357);
            this.numberValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.numberValue.Name = "numberValue";
            this.numberValue.Properties.BeepOnError = false;
            this.numberValue.Properties.UseMaskAsDisplayFormat = true;
            this.numberValue.Size = new System.Drawing.Size(89, 20);
            this.numberValue.TabIndex = 11;
            this.numberValue.ToolTip = "Informe o número da residência";
            // 
            // bindingSourceAddress
            // 
            this.bindingSourceAddress.DataSource = typeof(Vendas.Entity.Entities.Address);
            // 
            // Numero
            // 
            this.Numero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Numero.Location = new System.Drawing.Point(107, 340);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(40, 13);
            this.Numero.TabIndex = 104;
            this.Numero.Text = "Número ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(107, 423);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 13);
            this.labelControl2.TabIndex = 103;
            this.labelControl2.Text = "Tipo de Usuário ";
            // 
            // StreetValue
            // 
            this.StreetValue.EditValue = "";
            this.StreetValue.Location = new System.Drawing.Point(107, 316);
            this.StreetValue.Name = "StreetValue";
            this.StreetValue.Properties.BeepOnError = false;
            this.StreetValue.Properties.UseMaskAsDisplayFormat = true;
            this.StreetValue.Size = new System.Drawing.Size(517, 20);
            this.StreetValue.TabIndex = 10;
            this.StreetValue.ToolTip = "Informe o nome do logradouro";
            // 
            // DistrictValue
            // 
            this.DistrictValue.EditValue = "";
            this.DistrictValue.Location = new System.Drawing.Point(107, 275);
            this.DistrictValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.DistrictValue.Name = "DistrictValue";
            this.DistrictValue.Properties.BeepOnError = false;
            this.DistrictValue.Properties.UseMaskAsDisplayFormat = true;
            this.DistrictValue.Size = new System.Drawing.Size(517, 20);
            this.DistrictValue.TabIndex = 9;
            this.DistrictValue.ToolTip = "Digite o nome do bairro";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Location = new System.Drawing.Point(107, 299);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 13);
            this.labelControl9.TabIndex = 102;
            this.labelControl9.Text = "Logradouro ";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Location = new System.Drawing.Point(227, 216);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 13);
            this.labelControl8.TabIndex = 101;
            this.labelControl8.Text = "Cidade  ";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(107, 258);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 13);
            this.labelControl7.TabIndex = 100;
            this.labelControl7.Text = "Bairro";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(107, 175);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(22, 13);
            this.labelControl6.TabIndex = 99;
            this.labelControl6.Text = "CEP ";
            // 
            // CityValue
            // 
            this.CityValue.EditValue = "";
            this.CityValue.Location = new System.Drawing.Point(226, 233);
            this.CityValue.Name = "CityValue";
            this.CityValue.Properties.BeepOnError = false;
            this.CityValue.Properties.UseMaskAsDisplayFormat = true;
            this.CityValue.Size = new System.Drawing.Size(398, 20);
            this.CityValue.TabIndex = 8;
            this.CityValue.ToolTip = "Digite o nome da cidade";
            // 
            // EmailValue
            // 
            this.EmailValue.EditValue = "";
            this.EmailValue.Location = new System.Drawing.Point(107, 398);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Properties.BeepOnError = false;
            this.EmailValue.Properties.UseMaskAsDisplayFormat = true;
            this.EmailValue.Size = new System.Drawing.Size(517, 20);
            this.EmailValue.TabIndex = 12;
            this.EmailValue.ToolTip = "Informe o e-mail do usuário";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(107, 381);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 98;
            this.labelControl3.Text = "Email ";
            // 
            // dateValue
            // 
            this.dateValue.EditValue = new System.DateTime(((long)(0)));
            this.dateValue.Location = new System.Drawing.Point(107, 110);
            this.dateValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.dateValue.Name = "dateValue";
            this.dateValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValue.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateValue.Size = new System.Drawing.Size(89, 20);
            this.dateValue.TabIndex = 3;
            this.dateValue.ToolTip = "Informe  a data de Nascimento do Usuário";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(107, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 13);
            this.labelControl1.TabIndex = 97;
            this.labelControl1.Text = "Data de nascimento  ";
            // 
            // nameValue
            // 
            this.nameValue.EditValue = "";
            this.nameValue.Location = new System.Drawing.Point(107, 28);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(517, 20);
            this.nameValue.TabIndex = 1;
            this.nameValue.ToolTip = "Informe o primeiro nome";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Location = new System.Drawing.Point(107, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(30, 13);
            this.nameLabel.TabIndex = 94;
            this.nameLabel.Text = "Nome ";
            // 
            // valorLabel
            // 
            this.valorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorLabel.Location = new System.Drawing.Point(226, 93);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(45, 13);
            this.valorLabel.TabIndex = 96;
            this.valorLabel.Text = "Telefone ";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoLabel.Location = new System.Drawing.Point(107, 134);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(22, 13);
            this.descricaoLabel.TabIndex = 95;
            this.descricaoLabel.Text = "CPF ";
            // 
            // Btn_register_user
            // 
            this.Btn_register_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_register_user.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_register_user.ImageOptions.Image")));
            this.Btn_register_user.Location = new System.Drawing.Point(213, 471);
            this.Btn_register_user.Name = "Btn_register_user";
            this.Btn_register_user.Size = new System.Drawing.Size(100, 30);
            this.Btn_register_user.TabIndex = 15;
            this.Btn_register_user.Text = "&Cadastrar";
            this.Btn_register_user.ToolTip = "C - Cadastrar novo usuário";
            this.Btn_register_user.Click += new System.EventHandler(this.Btn_register_user_Click_1);
            // 
            // comboBoxEditTypeUser
            // 
            this.comboBoxEditTypeUser.Location = new System.Drawing.Point(107, 440);
            this.comboBoxEditTypeUser.Name = "comboBoxEditTypeUser";
            this.comboBoxEditTypeUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditTypeUser.Properties.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Cliente"});
            this.comboBoxEditTypeUser.Size = new System.Drawing.Size(89, 20);
            this.comboBoxEditTypeUser.TabIndex = 13;
            this.comboBoxEditTypeUser.ToolTip = "Selecione de tipo de usuário";
            // 
            // btnRegisterBiometricPrint
            // 
            this.btnRegisterBiometricPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegisterBiometricPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterBiometricPrint.ImageOptions.Image")));
            this.btnRegisterBiometricPrint.Location = new System.Drawing.Point(107, 471);
            this.btnRegisterBiometricPrint.Name = "btnRegisterBiometricPrint";
            this.btnRegisterBiometricPrint.Size = new System.Drawing.Size(100, 30);
            this.btnRegisterBiometricPrint.TabIndex = 14;
            this.btnRegisterBiometricPrint.Text = "&Biometria";
            this.btnRegisterBiometricPrint.ToolTip = "D - Cadastro de Biometria";
            this.btnRegisterBiometricPrint.Click += new System.EventHandler(this.BtnRegisterBiometricPrint_Click);
            // 
            // labelBiomerticAlert
            // 
            this.labelBiomerticAlert.Location = new System.Drawing.Point(277, 443);
            this.labelBiomerticAlert.Name = "labelBiomerticAlert";
            this.labelBiomerticAlert.Size = new System.Drawing.Size(0, 13);
            this.labelBiomerticAlert.TabIndex = 109;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.MinimumSize = new System.Drawing.Size(1008, 537);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1008, 537);
            this.xtraTabControl1.TabIndex = 110;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.CEPValue);
            this.xtraTabPage1.Controls.Add(this.cpfValue);
            this.xtraTabPage1.Controls.Add(this.telValue);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.nameLabel);
            this.xtraTabPage1.Controls.Add(this.labelBiomerticAlert);
            this.xtraTabPage1.Controls.Add(this.Btn_register_user);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.btnRegisterBiometricPrint);
            this.xtraTabPage1.Controls.Add(this.descricaoLabel);
            this.xtraTabPage1.Controls.Add(this.comboBoxEditTypeUser);
            this.xtraTabPage1.Controls.Add(this.valorLabel);
            this.xtraTabPage1.Controls.Add(this.LastNameValue);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.numberValue);
            this.xtraTabPage1.Controls.Add(this.nameValue);
            this.xtraTabPage1.Controls.Add(this.Numero);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.dateValue);
            this.xtraTabPage1.Controls.Add(this.StreetValue);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.DistrictValue);
            this.xtraTabPage1.Controls.Add(this.EmailValue);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.CityValue);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.StateValue);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1006, 512);
            this.xtraTabPage1.Text = "Registro de Usuários";
            // 
            // CEPValue
            // 
            this.CEPValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CEPValue.Location = new System.Drawing.Point(107, 192);
            this.CEPValue.Mask = "00000-999";
            this.CEPValue.Name = "CEPValue";
            this.CEPValue.Size = new System.Drawing.Size(89, 21);
            this.CEPValue.TabIndex = 6;
            this.CEPValue.Leave += new System.EventHandler(this.CEPValue_Leave);
            // 
            // cpfValue
            // 
            this.cpfValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpfValue.Location = new System.Drawing.Point(107, 150);
            this.cpfValue.Mask = "000\\.000\\.000-00";
            this.cpfValue.Name = "cpfValue";
            this.cpfValue.Size = new System.Drawing.Size(89, 21);
            this.cpfValue.TabIndex = 5;
            // 
            // telValue
            // 
            this.telValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telValue.Location = new System.Drawing.Point(227, 110);
            this.telValue.Mask = "(99) 00000-0000";
            this.telValue.Name = "telValue";
            this.telValue.Size = new System.Drawing.Size(86, 21);
            this.telValue.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(108, 217);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 111;
            this.labelControl4.Text = "Estado";
            // 
            // StateValue
            // 
            this.StateValue.EditValue = "";
            this.StateValue.Location = new System.Drawing.Point(107, 234);
            this.StateValue.Name = "StateValue";
            this.StateValue.Properties.BeepOnError = false;
            this.StateValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StateValue.Properties.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.StateValue.Size = new System.Drawing.Size(89, 20);
            this.StateValue.TabIndex = 7;
            this.StateValue.ToolTip = "Digite o nome da cidade";
            // 
            // FormRegisterUser
            // 
            this.AccessibleName = "Cadastro de usuário";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1008, 537);
            this.Name = "FormRegisterUser";
            this.Text = "Cadastro de usuário";
            ((System.ComponentModel.ISupportInitialize)(this.LastNameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistrictValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTypeUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StateValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit LastNameValue;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.TextEdit numberValue;
        private DevExpress.XtraEditors.LabelControl Numero;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit StreetValue;
        public DevExpress.XtraEditors.TextEdit DistrictValue;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.TextEdit CityValue;
        public DevExpress.XtraEditors.TextEdit EmailValue;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateValue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit nameValue;
        private DevExpress.XtraEditors.LabelControl nameLabel;
        private DevExpress.XtraEditors.LabelControl valorLabel;
        private DevExpress.XtraEditors.LabelControl descricaoLabel;
        private DevExpress.XtraEditors.SimpleButton Btn_register_user;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditTypeUser;
        private DevExpress.XtraEditors.SimpleButton btnRegisterBiometricPrint;
        private DevExpress.XtraEditors.LabelControl labelBiomerticAlert;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit StateValue;
        private System.Windows.Forms.MaskedTextBox telValue;
        private System.Windows.Forms.MaskedTextBox cpfValue;
        private System.Windows.Forms.MaskedTextBox CEPValue;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private System.Windows.Forms.BindingSource bindingSourceAddress;
    }
}