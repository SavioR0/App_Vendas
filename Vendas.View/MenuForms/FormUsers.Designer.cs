
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
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
			this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridUsers = new DevExpress.XtraGrid.GridControl();
			this.bindingSourceUsuarios = new System.Windows.Forms.BindingSource(this.components);
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.venda = new DevExpress.XtraTab.XtraTabControl();
			this.compras = new DevExpress.XtraTab.XtraTabPage();
			this.gridSale = new DevExpress.XtraGrid.GridControl();
			this.bindingSourceSales = new System.Windows.Forms.BindingSource(this.components);
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Data = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.pedido = new DevExpress.XtraTab.XtraTabControl();
			this.Pedidos = new DevExpress.XtraTab.XtraTabPage();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.orderDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colProductDTO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Descrição = new DevExpress.XtraGrid.Columns.GridColumn();
			this.valor_unitario = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colValueOrder = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.LabelNumUser = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.GenerateReport = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterUsers.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Usuários)).BeginInit();
			this.Usuários.SuspendLayout();
			this.xtraTabPage1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.venda)).BeginInit();
			this.venda.SuspendLayout();
			this.compras.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pedido)).BeginInit();
			this.pedido.SuspendLayout();
			this.Pedidos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// Tipo
			// 
			this.Tipo.Caption = "Tipo Usuário";
			this.Tipo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.Tipo.FieldName = "TypeUserName";
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
			this.gridUsers.DataSource = this.bindingSourceUsuarios;
			this.gridUsers.Location = new System.Drawing.Point(3, 3);
			this.gridUsers.MainView = this.gridView1;
			this.gridUsers.Name = "gridUsers";
			this.gridUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
			this.gridUsers.Size = new System.Drawing.Size(986, 122);
			this.gridUsers.TabIndex = 9;
			this.gridUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// bindingSourceUsuarios
			// 
			this.bindingSourceUsuarios.DataSource = typeof(Vendas.DTO.UserDTO);
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
			gridFormatRule2.Column = this.Tipo;
			gridFormatRule2.ColumnApplyTo = this.Tipo;
			gridFormatRule2.Name = "Format0";
			formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
			formatConditionRuleValue2.Expression = "[TypeUser] = 1";
			gridFormatRule2.Rule = formatConditionRuleValue2;
			this.gridView1.FormatRules.Add(gridFormatRule2);
			this.gridView1.GridControl = this.gridUsers;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsBehavior.ReadOnly = true;
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.OptionsView.ShowIndicator = false;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewUsers_FocusedRowChanged);
			this.gridView1.DataSourceChanged += new System.EventHandler(this.GridViewUsers_FocusedRowChanged);
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
			this.UserName.FieldName = "Name";
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
			this.btnSearchProd.Location = new System.Drawing.Point(789, 2);
			this.btnSearchProd.Name = "btnSearchProd";
			this.btnSearchProd.Size = new System.Drawing.Size(100, 30);
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
			this.btnExclude.Size = new System.Drawing.Size(100, 35);
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
			this.simpleButton1.Size = new System.Drawing.Size(100, 35);
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
			this.btnEdit.Size = new System.Drawing.Size(100, 35);
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
			this.xtraTabPage1.Controls.Add(this.tableLayoutPanel1);
			this.xtraTabPage1.Controls.Add(this.LabelNumUser);
			this.xtraTabPage1.Controls.Add(this.label1);
			this.xtraTabPage1.Controls.Add(this.simpleButton2);
			this.xtraTabPage1.Controls.Add(this.GenerateReport);
			this.xtraTabPage1.Controls.Add(this.label6);
			this.xtraTabPage1.Controls.Add(this.simpleButton1);
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
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.gridUsers, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.venda, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.pedido, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 33);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.38983F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.61017F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 432);
			this.tableLayoutPanel1.TabIndex = 125;
			// 
			// venda
			// 
			this.venda.Dock = System.Windows.Forms.DockStyle.Fill;
			this.venda.Location = new System.Drawing.Point(3, 131);
			this.venda.Name = "venda";
			this.venda.SelectedTabPage = this.compras;
			this.venda.Size = new System.Drawing.Size(986, 161);
			this.venda.TabIndex = 10;
			this.venda.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.compras});
			// 
			// compras
			// 
			this.compras.Controls.Add(this.gridSale);
			this.compras.Name = "compras";
			this.compras.Size = new System.Drawing.Size(984, 136);
			this.compras.Text = "Compras";
			// 
			// gridSale
			// 
			this.gridSale.DataSource = this.bindingSourceSales;
			this.gridSale.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridSale.Location = new System.Drawing.Point(0, 0);
			this.gridSale.MainView = this.gridView3;
			this.gridSale.Name = "gridSale";
			this.gridSale.Size = new System.Drawing.Size(984, 136);
			this.gridSale.TabIndex = 11;
			this.gridSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
			// 
			// bindingSourceSales
			// 
			this.bindingSourceSales.DataSource = typeof(Vendas.DTO.SaleDTO);
			// 
			// gridView3
			// 
			this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.Cliente,
            this.Data,
            this.Valor});
			this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView3.GridControl = this.gridSale;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsBehavior.Editable = false;
			this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView3.OptionsSelection.UseIndicatorForSelection = false;
			this.gridView3.OptionsView.ShowGroupPanel = false;
			this.gridView3.OptionsView.ShowIndicator = false;
			this.gridView3.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView3_FocusedRowChanged);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Id";
			this.gridColumn1.FieldName = "Id";
			this.gridColumn1.Name = "gridColumn1";
			// 
			// Cliente
			// 
			this.Cliente.Caption = "Cliente";
			this.Cliente.FieldName = "NameClient";
			this.Cliente.Name = "Cliente";
			this.Cliente.Visible = true;
			this.Cliente.VisibleIndex = 1;
			// 
			// Data
			// 
			this.Data.Caption = "Data";
			this.Data.FieldName = "DateSale";
			this.Data.Name = "Data";
			this.Data.Visible = true;
			this.Data.VisibleIndex = 0;
			// 
			// Valor
			// 
			this.Valor.Caption = "Valor";
			this.Valor.FieldName = "Value";
			this.Valor.Name = "Valor";
			this.Valor.Visible = true;
			this.Valor.VisibleIndex = 2;
			// 
			// pedido
			// 
			this.pedido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pedido.Location = new System.Drawing.Point(3, 298);
			this.pedido.Name = "pedido";
			this.pedido.SelectedTabPage = this.Pedidos;
			this.pedido.Size = new System.Drawing.Size(986, 131);
			this.pedido.TabIndex = 11;
			this.pedido.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Pedidos});
			// 
			// Pedidos
			// 
			this.Pedidos.Controls.Add(this.gridControl1);
			this.Pedidos.Name = "Pedidos";
			this.Pedidos.Size = new System.Drawing.Size(984, 106);
			this.Pedidos.Text = "Pedidos";
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.orderDTOBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView2;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(984, 106);
			this.gridControl1.TabIndex = 12;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// orderDTOBindingSource
			// 
			this.orderDTOBindingSource.DataSource = typeof(Vendas.DTO.OrderDTO);
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductDTO,
            this.Descrição,
            this.valor_unitario,
            this.colValueOrder,
            this.colQuantity,
            this.colId});
			this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView2.GridControl = this.gridControl1;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsBehavior.Editable = false;
			this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView2.OptionsSelection.UseIndicatorForSelection = false;
			this.gridView2.OptionsView.ShowGroupPanel = false;
			this.gridView2.OptionsView.ShowIndicator = false;
			// 
			// colProductDTO
			// 
			this.colProductDTO.Caption = "Produto";
			this.colProductDTO.FieldName = "ProductDTO.Name";
			this.colProductDTO.Name = "colProductDTO";
			this.colProductDTO.Visible = true;
			this.colProductDTO.VisibleIndex = 0;
			// 
			// Descrição
			// 
			this.Descrição.Caption = "Descrição";
			this.Descrição.FieldName = "ProductDTO.Description";
			this.Descrição.Name = "Descrição";
			this.Descrição.Visible = true;
			this.Descrição.VisibleIndex = 1;
			// 
			// valor_unitario
			// 
			this.valor_unitario.Caption = "Valor Unitário";
			this.valor_unitario.FieldName = "ProductDTO.Value";
			this.valor_unitario.Name = "valor_unitario";
			this.valor_unitario.Visible = true;
			this.valor_unitario.VisibleIndex = 2;
			// 
			// colValueOrder
			// 
			this.colValueOrder.Caption = "Valor Total";
			this.colValueOrder.FieldName = "ValueOrder";
			this.colValueOrder.Name = "colValueOrder";
			this.colValueOrder.Visible = true;
			this.colValueOrder.VisibleIndex = 3;
			// 
			// colQuantity
			// 
			this.colQuantity.Caption = "Quantidade";
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 4;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
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
			this.simpleButton2.Location = new System.Drawing.Point(895, 2);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(100, 30);
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
			this.GenerateReport.Size = new System.Drawing.Size(100, 35);
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
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterUsers.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Usuários)).EndInit();
			this.Usuários.ResumeLayout(false);
			this.xtraTabPage1.ResumeLayout(false);
			this.xtraTabPage1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.venda)).EndInit();
			this.venda.ResumeLayout(false);
			this.compras.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pedido)).EndInit();
			this.pedido.ResumeLayout(false);
			this.Pedidos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl venda;
        private DevExpress.XtraTab.XtraTabPage compras;
        private System.Windows.Forms.BindingSource bindingSourceUsuarios;
        private System.Windows.Forms.BindingSource bindingSourceSales;
		private DevExpress.XtraTab.XtraTabControl pedido;
		private DevExpress.XtraTab.XtraTabPage Pedidos;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private System.Windows.Forms.BindingSource orderDTOBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.Columns.GridColumn colValueOrder;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colProductDTO;
		private DevExpress.XtraGrid.Columns.GridColumn Descrição;
		private DevExpress.XtraGrid.Columns.GridColumn valor_unitario;
		private DevExpress.XtraGrid.GridControl gridSale;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn Cliente;
		private DevExpress.XtraGrid.Columns.GridColumn Data;
		private DevExpress.XtraGrid.Columns.GridColumn Valor;
	}
}