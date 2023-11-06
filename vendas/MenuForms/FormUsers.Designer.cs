﻿
namespace vendas.MenuForms
{
    partial class FormUsers
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUsers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Data_Nascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTExt4 = new System.Windows.Forms.Label();
            this.btnSearchProd = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxFilterUsers = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnExclude = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.Usuários = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.LabelNumUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.GenerateReport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usuários)).BeginInit();
            this.Usuários.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tipo
            // 
            this.Tipo.Caption = "Tipo Usuário";
            this.Tipo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Tipo.FieldName = "TypeUsers.Name";
            this.Tipo.Name = "Tipo";
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 6;
            this.Tipo.Width = 41;
            // 
            // gridUsers
            // 
            this.gridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUsers.DataSource = typeof(Vendas.Entity.Entities.User);
            this.gridUsers.Location = new System.Drawing.Point(12, 33);
            this.gridUsers.MainView = this.gridView1;
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridUsers.Size = new System.Drawing.Size(983, 432);
            this.gridUsers.TabIndex = 9;
            this.gridUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.AutoFillColumn = this.Tipo;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Nome,
            this.Cpf,
            this.Email,
            this.Telefone,
            this.Data_Nascimento,
            this.UserName,
            this.Tipo});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridFormatRule1.Column = this.Tipo;
            gridFormatRule1.ColumnApplyTo = this.Tipo;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "[TypeUser] = 1";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridUsers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // Id
            // 
            this.Id.FieldName = "Id";
            this.Id.MinWidth = 30;
            this.Id.Name = "Id";
            this.Id.Width = 53;
            // 
            // Nome
            // 
            this.Nome.Caption = "Nome";
            this.Nome.FieldName = "Name";
            this.Nome.Name = "Nome";
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 0;
            this.Nome.Width = 51;
            // 
            // Cpf
            // 
            this.Cpf.Caption = "Cpf";
            this.Cpf.FieldName = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.Visible = true;
            this.Cpf.VisibleIndex = 4;
            this.Cpf.Width = 62;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 1;
            this.Email.Width = 136;
            // 
            // Telefone
            // 
            this.Telefone.Caption = "Telefone";
            this.Telefone.FieldName = "Tel";
            this.Telefone.Name = "Telefone";
            this.Telefone.Visible = true;
            this.Telefone.VisibleIndex = 2;
            this.Telefone.Width = 46;
            // 
            // Data_Nascimento
            // 
            this.Data_Nascimento.Caption = "Data Nasc.";
            this.Data_Nascimento.FieldName = "DateOfBirth";
            this.Data_Nascimento.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Date;
            this.Data_Nascimento.Name = "Data_Nascimento";
            this.Data_Nascimento.Visible = true;
            this.Data_Nascimento.VisibleIndex = 3;
            this.Data_Nascimento.Width = 35;
            // 
            // UserName
            // 
            this.UserName.Caption = "UserName";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 5;
            this.UserName.Width = 105;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Filtro";
            // 
            // labelTExt4
            // 
            this.labelTExt4.AutoSize = true;
            this.labelTExt4.Location = new System.Drawing.Point(129, 10);
            this.labelTExt4.Name = "labelTExt4";
            this.labelTExt4.Size = new System.Drawing.Size(49, 13);
            this.labelTExt4.TabIndex = 44;
            this.labelTExt4.Text = "Pesquisa";
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProd.ImageOptions.Image")));
            this.btnSearchProd.Location = new System.Drawing.Point(789, 7);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(100, 20);
            this.btnSearchProd.TabIndex = 3;
            this.btnSearchProd.Text = "&Filtrar";
            this.btnSearchProd.ToolTip = "F - Aplicar filtro";
            this.btnSearchProd.Click += new System.EventHandler(this.BtnSearchProd_Click);
            // 
            // comboBoxFilterUsers
            // 
            this.comboBoxFilterUsers.EditValue = "";
            this.comboBoxFilterUsers.Location = new System.Drawing.Point(47, 7);
            this.comboBoxFilterUsers.Name = "comboBoxFilterUsers";
            this.comboBoxFilterUsers.Properties.BeepOnError = false;
            this.comboBoxFilterUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxFilterUsers.Properties.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Email",
            "Telefone",
            "Data Nasc.",
            "CPF",
            "Usuário",
            "Tipo Usuário"});
            this.comboBoxFilterUsers.Size = new System.Drawing.Size(75, 20);
            this.comboBoxFilterUsers.TabIndex = 1;
            this.comboBoxFilterUsers.ToolTip = "Informe o atributo para o filtro";
            this.comboBoxFilterUsers.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterProd_SelectedIndexChanged);
            // 
            // textEditSearch
            // 
            this.textEditSearch.EditValue = "";
            this.textEditSearch.Enabled = false;
            this.textEditSearch.Location = new System.Drawing.Point(183, 7);
            this.textEditSearch.Name = "textEditSearch";
            this.textEditSearch.Properties.BeepOnError = false;
            this.textEditSearch.Size = new System.Drawing.Size(191, 20);
            this.textEditSearch.TabIndex = 2;
            this.textEditSearch.ToolTip = "Informe o que deseja filtrar";
            // 
            // btnExclude
            // 
            this.btnExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExclude.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExclude.ImageOptions.Image")));
            this.btnExclude.Location = new System.Drawing.Point(118, 471);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(100, 30);
            this.btnExclude.TabIndex = 6;
            this.btnExclude.Text = "&Excluir";
            this.btnExclude.ToolTip = "E - Excluir usuário";
            this.btnExclude.Click += new System.EventHandler(this.BtnExclude_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 471);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 30);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "&Cadastrar";
            this.simpleButton1.ToolTip = "C - Cadastrar usuário";
            this.simpleButton1.Click += new System.EventHandler(this.RegisterUserButton_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(224, 471);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "E&ditar";
            this.btnEdit.ToolTip = "D - Editar usuário";
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // Usuários
            // 
            this.Usuários.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Usuários.Location = new System.Drawing.Point(0, 0);
            this.Usuários.Name = "Usuários";
            this.Usuários.SelectedTabPage = this.xtraTabPage1;
            this.Usuários.Size = new System.Drawing.Size(1008, 537);
            this.Usuários.TabIndex = 114;
            this.Usuários.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.LabelNumUser);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.GenerateReport);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.Controls.Add(this.gridUsers);
            this.xtraTabPage1.Controls.Add(this.btnEdit);
            this.xtraTabPage1.Controls.Add(this.textEditSearch);
            this.xtraTabPage1.Controls.Add(this.btnExclude);
            this.xtraTabPage1.Controls.Add(this.comboBoxFilterUsers);
            this.xtraTabPage1.Controls.Add(this.btnSearchProd);
            this.xtraTabPage1.Controls.Add(this.labelTExt4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1006, 512);
            this.xtraTabPage1.Text = "Usuários";
            // 
            // LabelNumUser
            // 
            this.LabelNumUser.AutoSize = true;
            this.LabelNumUser.Location = new System.Drawing.Point(508, 10);
            this.LabelNumUser.Name = "LabelNumUser";
            this.LabelNumUser.Size = new System.Drawing.Size(13, 13);
            this.LabelNumUser.TabIndex = 124;
            this.LabelNumUser.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Usuários Cadastrados :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(895, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(100, 20);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "&Atualizar";
            this.simpleButton2.ToolTip = "F - Aplicar filtro";
            this.simpleButton2.Click += new System.EventHandler(this.UpdateGridButton_Click);
            // 
            // GenerateReport
            // 
            this.GenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GenerateReport.ImageOptions.Image")));
            this.GenerateReport.Location = new System.Drawing.Point(895, 471);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(100, 30);
            this.GenerateReport.TabIndex = 8;
            this.GenerateReport.Text = "&Relatório";
            this.GenerateReport.ToolTip = "R - Gerar Relatório de Usuários";
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.Usuários);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUsers";
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usuários)).EndInit();
            this.Usuários.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn Cpf;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Telefone;
        private DevExpress.XtraGrid.Columns.GridColumn Data_Nascimento;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTExt4;
        private DevExpress.XtraEditors.SimpleButton btnSearchProd;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxFilterUsers;
        private DevExpress.XtraEditors.TextEdit textEditSearch;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraEditors.SimpleButton btnExclude;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraTab.XtraTabControl Usuários;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton GenerateReport;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label LabelNumUser;
        private System.Windows.Forms.Label label1;
    }
}