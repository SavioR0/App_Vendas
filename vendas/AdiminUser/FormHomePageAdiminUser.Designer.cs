
namespace Vendas.View
{
    partial class FormHomePageAdminUser
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
            this.TabControlHomePage = new DevExpress.XtraTab.XtraTabControl();
            this.ProdutosTab = new DevExpress.XtraTab.XtraTabPage();
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClienteTab = new DevExpress.XtraTab.XtraTabPage();
            this.gridClient = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Data_Nascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VendaTab = new DevExpress.XtraTab.XtraTabPage();
            this.gridSale = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTExt4 = new System.Windows.Forms.Label();
            this.btnSearchProd = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxFilterProd = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnExclude = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlHomePage)).BeginInit();
            this.TabControlHomePage.SuspendLayout();
            this.ProdutosTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.ClienteTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.VendaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterProd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlHomePage
            // 
            this.TabControlHomePage.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.TabControlHomePage.Appearance.Options.UseBackColor = true;
            this.TabControlHomePage.Location = new System.Drawing.Point(12, 39);
            this.TabControlHomePage.Name = "TabControlHomePage";
            this.TabControlHomePage.SelectedTabPage = this.ProdutosTab;
            this.TabControlHomePage.Size = new System.Drawing.Size(891, 482);
            this.TabControlHomePage.TabIndex = 0;
            this.TabControlHomePage.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.ProdutosTab,
            this.ClienteTab,
            this.VendaTab});
            this.TabControlHomePage.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControlHomePage_SelectedPageChanged);
            // 
            // ProdutosTab
            // 
            this.ProdutosTab.Controls.Add(this.gridProduct);
            this.ProdutosTab.Name = "ProdutosTab";
            this.ProdutosTab.Size = new System.Drawing.Size(889, 457);
            this.ProdutosTab.Text = "Produtos";
            // 
            // gridProduct
            // 
            this.gridProduct.DataSource = typeof(Vendas.Entity.Entities.Product);
            this.gridProduct.Location = new System.Drawing.Point(0, 0);
            this.gridProduct.MainView = this.gridView2;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(890, 457);
            this.gridProduct.TabIndex = 1;
            this.gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdP,
            this.NameP,
            this.descricao,
            this.estoque,
            this.Valor,
            this.Vendedor});
            this.gridView2.GridControl = this.gridProduct;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // IdP
            // 
            this.IdP.Caption = "Id";
            this.IdP.FieldName = "Id";
            this.IdP.Name = "IdP";
            this.IdP.Visible = true;
            this.IdP.VisibleIndex = 0;
            this.IdP.Width = 47;
            // 
            // NameP
            // 
            this.NameP.Caption = "Nome";
            this.NameP.FieldName = "Name";
            this.NameP.Name = "NameP";
            this.NameP.Visible = true;
            this.NameP.VisibleIndex = 1;
            this.NameP.Width = 109;
            // 
            // descricao
            // 
            this.descricao.Caption = "Descrição";
            this.descricao.FieldName = "Description";
            this.descricao.Name = "descricao";
            this.descricao.Visible = true;
            this.descricao.VisibleIndex = 2;
            this.descricao.Width = 241;
            // 
            // estoque
            // 
            this.estoque.Caption = "Estoque";
            this.estoque.FieldName = "Stock";
            this.estoque.Name = "estoque";
            this.estoque.Visible = true;
            this.estoque.VisibleIndex = 3;
            this.estoque.Width = 140;
            // 
            // Valor
            // 
            this.Valor.Caption = "Valor";
            this.Valor.FieldName = "Value";
            this.Valor.Name = "Valor";
            this.Valor.Visible = true;
            this.Valor.VisibleIndex = 4;
            this.Valor.Width = 102;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Seller.Name";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 5;
            this.Vendedor.Width = 226;
            // 
            // ClienteTab
            // 
            this.ClienteTab.Controls.Add(this.gridClient);
            this.ClienteTab.Name = "ClienteTab";
            this.ClienteTab.Size = new System.Drawing.Size(889, 457);
            this.ClienteTab.Text = "Clientes";
            // 
            // gridClient
            // 
            this.gridClient.DataSource = typeof(Vendas.Entity.Entities.User);
            this.gridClient.Location = new System.Drawing.Point(0, 0);
            this.gridClient.MainView = this.gridView1;
            this.gridClient.Name = "gridClient";
            this.gridClient.Size = new System.Drawing.Size(890, 457);
            this.gridClient.TabIndex = 0;
            this.gridClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Nome,
            this.Cpf,
            this.Email,
            this.Telefone,
            this.Data_Nascimento,
            this.UserName});
            this.gridView1.GridControl = this.gridClient;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.FieldName = "Id";
            this.Id.MinWidth = 30;
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 30;
            // 
            // Nome
            // 
            this.Nome.Caption = "Nome";
            this.Nome.FieldName = "Name";
            this.Nome.Name = "Nome";
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 1;
            this.Nome.Width = 90;
            // 
            // Cpf
            // 
            this.Cpf.Caption = "Cpf";
            this.Cpf.FieldName = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.Visible = true;
            this.Cpf.VisibleIndex = 5;
            this.Cpf.Width = 178;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 2;
            this.Email.Width = 146;
            // 
            // Telefone
            // 
            this.Telefone.Caption = "Telefone";
            this.Telefone.FieldName = "Tel";
            this.Telefone.Name = "Telefone";
            this.Telefone.Visible = true;
            this.Telefone.VisibleIndex = 3;
            this.Telefone.Width = 146;
            // 
            // Data_Nascimento
            // 
            this.Data_Nascimento.Caption = "Data Nasc.";
            this.Data_Nascimento.FieldName = "DateOfBirth";
            this.Data_Nascimento.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Date;
            this.Data_Nascimento.Name = "Data_Nascimento";
            this.Data_Nascimento.Visible = true;
            this.Data_Nascimento.VisibleIndex = 4;
            this.Data_Nascimento.Width = 79;
            // 
            // UserName
            // 
            this.UserName.Caption = "UserName";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 6;
            this.UserName.Width = 196;
            // 
            // VendaTab
            // 
            this.VendaTab.Controls.Add(this.gridSale);
            this.VendaTab.Name = "VendaTab";
            this.VendaTab.Size = new System.Drawing.Size(889, 457);
            this.VendaTab.Text = "Vendas";
            // 
            // gridSale
            // 
            this.gridSale.DataSource = typeof(Vendas.Entity.Entities.Sale);
            this.gridSale.Location = new System.Drawing.Point(-1, 0);
            this.gridSale.MainView = this.gridView3;
            this.gridSale.Name = "gridSale";
            this.gridSale.Size = new System.Drawing.Size(890, 457);
            this.gridSale.TabIndex = 1;
            this.gridSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridSale;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Filtro :";
            // 
            // labelTExt4
            // 
            this.labelTExt4.AutoSize = true;
            this.labelTExt4.Location = new System.Drawing.Point(130, 15);
            this.labelTExt4.Name = "labelTExt4";
            this.labelTExt4.Size = new System.Drawing.Size(37, 13);
            this.labelTExt4.TabIndex = 39;
            this.labelTExt4.Text = "Valor :";
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProd.Location = new System.Drawing.Point(712, 10);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(191, 23);
            this.btnSearchProd.TabIndex = 37;
            this.btnSearchProd.Text = "Filtrar";
            this.btnSearchProd.Click += new System.EventHandler(this.BtnSearchProd_Click);
            // 
            // comboBoxFilterProd
            // 
            this.comboBoxFilterProd.EditValue = "";
            this.comboBoxFilterProd.Location = new System.Drawing.Point(46, 12);
            this.comboBoxFilterProd.Name = "comboBoxFilterProd";
            this.comboBoxFilterProd.Properties.BeepOnError = false;
            this.comboBoxFilterProd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxFilterProd.Properties.Items.AddRange(new object[] {
            "Id",
            "Nome"});
            this.comboBoxFilterProd.Size = new System.Drawing.Size(75, 20);
            this.comboBoxFilterProd.TabIndex = 36;
            this.comboBoxFilterProd.SelectedValueChanged += new System.EventHandler(this.ComboBoxFilterProd_SelectedValueChanged);
            // 
            // textEditSearch
            // 
            this.textEditSearch.EditValue = "";
            this.textEditSearch.Enabled = false;
            this.textEditSearch.Location = new System.Drawing.Point(174, 12);
            this.textEditSearch.Name = "textEditSearch";
            this.textEditSearch.Properties.BeepOnError = false;
            this.textEditSearch.Size = new System.Drawing.Size(191, 20);
            this.textEditSearch.TabIndex = 38;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleName = "";
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(149, 529);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 23);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Editar";
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleName = "";
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegister.Location = new System.Drawing.Point(286, 529);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(151, 23);
            this.btnRegister.TabIndex = 45;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "btnUpdate";
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(768, 527);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 23);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Atualizar";
            // 
            // btnExclude
            // 
            this.btnExclude.AccessibleName = "";
            this.btnExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExclude.Enabled = false;
            this.btnExclude.Location = new System.Drawing.Point(12, 529);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(135, 23);
            this.btnExclude.TabIndex = 49;
            this.btnExclude.Text = "Excluir";
            // 
            // FormHomePageAdminUser
            // 
            this.ClientSize = new System.Drawing.Size(915, 562);
            this.Controls.Add(this.btnExclude);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTExt4);
            this.Controls.Add(this.btnSearchProd);
            this.Controls.Add(this.comboBoxFilterProd);
            this.Controls.Add(this.textEditSearch);
            this.Controls.Add(this.TabControlHomePage);
            this.Name = "FormHomePageAdminUser";
            this.Text = "Página do vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.TabControlHomePage)).EndInit();
            this.TabControlHomePage.ResumeLayout(false);
            this.ProdutosTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ClienteTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.VendaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterProd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControlHomePage;
        private DevExpress.XtraTab.XtraTabPage ProdutosTab;
        private DevExpress.XtraTab.XtraTabPage ClienteTab;
        private DevExpress.XtraTab.XtraTabPage VendaTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTExt4;
        private DevExpress.XtraEditors.SimpleButton btnSearchProd;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxFilterProd;
        private DevExpress.XtraEditors.TextEdit textEditSearch;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnExclude;
        private DevExpress.XtraGrid.GridControl gridClient;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn Cpf;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Telefone;
        private DevExpress.XtraGrid.Columns.GridColumn Data_Nascimento;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn IdP;
        private DevExpress.XtraGrid.Columns.GridColumn NameP;
        private DevExpress.XtraGrid.Columns.GridColumn descricao;
        private DevExpress.XtraGrid.Columns.GridColumn estoque;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.GridControl gridSale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}