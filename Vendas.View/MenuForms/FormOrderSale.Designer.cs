
namespace vendas.MenuForms
{
    partial class FormOrderSale
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderSale));
			this.gridSale = new DevExpress.XtraGrid.GridControl();
			this.bindingSourceSales = new System.Windows.Forms.BindingSource(this.components);
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Data = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.labelTExt4 = new System.Windows.Forms.Label();
			this.btnSearchProd = new DevExpress.XtraEditors.SimpleButton();
			this.textEditSearch = new DevExpress.XtraEditors.TextEdit();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.btnExclude = new DevExpress.XtraEditors.SimpleButton();
			this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.orderDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.IdOrder = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Produto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.descrição = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Valor_unitario = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Valor_total = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.comboBoxFilterSale = new DevExpress.XtraEditors.ComboBoxEdit();
			this.LabelNumOrder = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.GenerateReport = new DevExpress.XtraEditors.SimpleButton();
			this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
			this.Pedidos = new DevExpress.XtraTab.XtraTabPage();
			((System.ComponentModel.ISupportInitialize)(this.gridSale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.xtraTabPage2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterSale.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
			this.xtraTabControl2.SuspendLayout();
			this.Pedidos.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridSale
			// 
			this.gridSale.DataSource = this.bindingSourceSales;
			this.gridSale.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridSale.Location = new System.Drawing.Point(3, 42);
			this.gridSale.MainView = this.gridView3;
			this.gridSale.Name = "gridSale";
			this.gridSale.Size = new System.Drawing.Size(985, 245);
			this.gridSale.TabIndex = 10;
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
            this.Id,
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
			this.gridView3.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewSales_FocusedRowChanged);
			// 
			// Id
			// 
			this.Id.Caption = "Id";
			this.Id.FieldName = "Id";
			this.Id.Name = "Id";
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(0, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 112;
			this.label6.Text = "Filtro";
			// 
			// labelTExt4
			// 
			this.labelTExt4.AutoSize = true;
			this.labelTExt4.Location = new System.Drawing.Point(118, 9);
			this.labelTExt4.Name = "labelTExt4";
			this.labelTExt4.Size = new System.Drawing.Size(49, 13);
			this.labelTExt4.TabIndex = 111;
			this.labelTExt4.Text = "Pesquisa";
			// 
			// btnSearchProd
			// 
			this.btnSearchProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearchProd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProd.ImageOptions.Image")));
			this.btnSearchProd.Location = new System.Drawing.Point(778, 1);
			this.btnSearchProd.Name = "btnSearchProd";
			this.btnSearchProd.Size = new System.Drawing.Size(100, 30);
			this.btnSearchProd.TabIndex = 3;
			this.btnSearchProd.Text = "&Filtrar";
			this.btnSearchProd.ToolTip = "F - Aplicar filtro";
			this.btnSearchProd.Click += new System.EventHandler(this.BtnSearchProd_Click);
			// 
			// textEditSearch
			// 
			this.textEditSearch.EditValue = "";
			this.textEditSearch.Enabled = false;
			this.textEditSearch.Location = new System.Drawing.Point(172, 6);
			this.textEditSearch.Name = "textEditSearch";
			this.textEditSearch.Properties.BeepOnError = false;
			this.textEditSearch.Size = new System.Drawing.Size(191, 20);
			this.textEditSearch.TabIndex = 2;
			this.textEditSearch.ToolTip = "Informe o que deseja filtrar";
			// 
			// simpleButton1
			// 
			this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.simpleButton1.Location = new System.Drawing.Point(12, 471);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(100, 35);
			this.simpleButton1.TabIndex = 6;
			this.simpleButton1.Text = "&Cadastrar";
			this.simpleButton1.ToolTip = "C - Cadastrar pedido";
			this.simpleButton1.Click += new System.EventHandler(this.Register_Click_1);
			// 
			// btnExclude
			// 
			this.btnExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExclude.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExclude.ImageOptions.Image")));
			this.btnExclude.Location = new System.Drawing.Point(118, 471);
			this.btnExclude.Name = "btnExclude";
			this.btnExclude.Size = new System.Drawing.Size(100, 35);
			this.btnExclude.TabIndex = 7;
			this.btnExclude.Text = "&Excluir";
			this.btnExclude.ToolTip = "E - Excluir pedido";
			this.btnExclude.Click += new System.EventHandler(this.BtnExclude_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
			this.btnEdit.Location = new System.Drawing.Point(224, 471);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(100, 35);
			this.btnEdit.TabIndex = 8;
			this.btnEdit.Text = "E&ditar";
			this.btnEdit.ToolTip = "D - Editar pedido";
			this.btnEdit.Visible = false;
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
			this.xtraTabControl1.Size = new System.Drawing.Size(1008, 537);
			this.xtraTabControl1.TabIndex = 117;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
			// 
			// xtraTabPage2
			// 
			this.xtraTabPage2.Controls.Add(this.tableLayoutPanel1);
			this.xtraTabPage2.Controls.Add(this.GenerateReport);
			this.xtraTabPage2.Controls.Add(this.simpleButton1);
			this.xtraTabPage2.Controls.Add(this.btnExclude);
			this.xtraTabPage2.Controls.Add(this.btnEdit);
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new System.Drawing.Size(1006, 512);
			this.xtraTabPage2.Text = "Pedidos";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.xtraTabControl2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.gridSale, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.92019F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.07981F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 465);
			this.tableLayoutPanel1.TabIndex = 125;
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.orderDTOBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(983, 144);
			this.gridControl1.TabIndex = 11;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// orderDTOBindingSource
			// 
			this.orderDTOBindingSource.DataSource = typeof(Vendas.DTO.OrderDTO);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdOrder,
            this.Produto,
            this.descrição,
            this.Valor_unitario,
            this.Quantidade,
            this.Valor_total,
            this.Vendedor});
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsSelection.UseIndicatorForSelection = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.OptionsView.ShowIndicator = false;
			// 
			// IdOrder
			// 
			this.IdOrder.Caption = "id";
			this.IdOrder.FieldName = "Id";
			this.IdOrder.Name = "IdOrder";
			// 
			// Produto
			// 
			this.Produto.Caption = "Produto";
			this.Produto.FieldName = "ProductDTO.Name";
			this.Produto.Name = "Produto";
			this.Produto.Visible = true;
			this.Produto.VisibleIndex = 0;
			// 
			// descrição
			// 
			this.descrição.Caption = "Descrição";
			this.descrição.FieldName = "ProductDTO.Description";
			this.descrição.Name = "descrição";
			this.descrição.Visible = true;
			this.descrição.VisibleIndex = 1;
			// 
			// Valor_unitario
			// 
			this.Valor_unitario.Caption = "Valor Unitário";
			this.Valor_unitario.FieldName = "ProductDTO.Value";
			this.Valor_unitario.Name = "Valor_unitario";
			this.Valor_unitario.Visible = true;
			this.Valor_unitario.VisibleIndex = 3;
			// 
			// Quantidade
			// 
			this.Quantidade.Caption = "Quantidade";
			this.Quantidade.FieldName = "Quantity";
			this.Quantidade.Name = "Quantidade";
			this.Quantidade.Visible = true;
			this.Quantidade.VisibleIndex = 2;
			// 
			// Valor_total
			// 
			this.Valor_total.Caption = "Valor Total";
			this.Valor_total.FieldName = "ValueOrder";
			this.Valor_total.Name = "Valor_total";
			this.Valor_total.Visible = true;
			this.Valor_total.VisibleIndex = 4;
			// 
			// Vendedor
			// 
			this.Vendedor.Caption = "Vendedor";
			this.Vendedor.FieldName = "ProductDTO.SellerName";
			this.Vendedor.Name = "Vendedor";
			this.Vendedor.Visible = true;
			this.Vendedor.VisibleIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.simpleButton2);
			this.panel1.Controls.Add(this.comboBoxFilterSale);
			this.panel1.Controls.Add(this.labelTExt4);
			this.panel1.Controls.Add(this.LabelNumOrder);
			this.panel1.Controls.Add(this.btnSearchProd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textEditSearch);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(985, 33);
			this.panel1.TabIndex = 0;
			// 
			// simpleButton2
			// 
			this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
			this.simpleButton2.Location = new System.Drawing.Point(884, 1);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(100, 30);
			this.simpleButton2.TabIndex = 4;
			this.simpleButton2.Text = "&Atualizar";
			this.simpleButton2.ToolTip = "F - Aplicar filtro";
			this.simpleButton2.Click += new System.EventHandler(this.UpdateGridButton_Click);
			// 
			// comboBoxFilterSale
			// 
			this.comboBoxFilterSale.EditValue = "";
			this.comboBoxFilterSale.Location = new System.Drawing.Point(37, 6);
			this.comboBoxFilterSale.Name = "comboBoxFilterSale";
			this.comboBoxFilterSale.Properties.BeepOnError = false;
			this.comboBoxFilterSale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.comboBoxFilterSale.Properties.Items.AddRange(new object[] {
            "Id",
            "Cliente",
            "Vendedor",
            "Produto",
            "Valor",
            "Estoque"});
			this.comboBoxFilterSale.Size = new System.Drawing.Size(75, 20);
			this.comboBoxFilterSale.TabIndex = 1;
			this.comboBoxFilterSale.ToolTip = "Informe o atributo para o filtro";
			this.comboBoxFilterSale.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterSale_SelectedIndexChanged);
			// 
			// LabelNumOrder
			// 
			this.LabelNumOrder.AutoSize = true;
			this.LabelNumOrder.Location = new System.Drawing.Point(497, 9);
			this.LabelNumOrder.Name = "LabelNumOrder";
			this.LabelNumOrder.Size = new System.Drawing.Size(13, 13);
			this.LabelNumOrder.TabIndex = 124;
			this.LabelNumOrder.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(369, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 13);
			this.label1.TabIndex = 123;
			this.label1.Text = "Pedidos Cadastrados :";
			// 
			// GenerateReport
			// 
			this.GenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.GenerateReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GenerateReport.ImageOptions.Image")));
			this.GenerateReport.Location = new System.Drawing.Point(895, 471);
			this.GenerateReport.Name = "GenerateReport";
			this.GenerateReport.Size = new System.Drawing.Size(100, 35);
			this.GenerateReport.TabIndex = 9;
			this.GenerateReport.Text = "&Relatório";
			this.GenerateReport.ToolTip = "R - Gerar relatório de Pedidos";
			this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
			// 
			// xtraTabControl2
			// 
			this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl2.Location = new System.Drawing.Point(3, 293);
			this.xtraTabControl2.Name = "xtraTabControl2";
			this.xtraTabControl2.SelectedTabPage = this.Pedidos;
			this.xtraTabControl2.Size = new System.Drawing.Size(985, 169);
			this.xtraTabControl2.TabIndex = 126;
			this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Pedidos});
			// 
			// Pedidos
			// 
			this.Pedidos.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.Pedidos.Controls.Add(this.gridControl1);
			this.Pedidos.Name = "Pedidos";
			this.Pedidos.Size = new System.Drawing.Size(983, 144);
			this.Pedidos.Text = "Pedidos";
			// 
			// FormOrderSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 537);
			this.Controls.Add(this.xtraTabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormOrderSale";
			this.Text = "FormPurcharse";
			((System.ComponentModel.ISupportInitialize)(this.gridSale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.xtraTabPage2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterSale.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
			this.xtraTabControl2.ResumeLayout(false);
			this.Pedidos.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridSale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTExt4;
        private DevExpress.XtraEditors.SimpleButton btnSearchProd;
        private DevExpress.XtraEditors.TextEdit textEditSearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnExclude;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton GenerateReport;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label LabelNumOrder;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxFilterSale;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private System.Windows.Forms.BindingSource bindingSourceSales;
		private DevExpress.XtraGrid.Columns.GridColumn Data;
		private DevExpress.XtraGrid.Columns.GridColumn Id;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn IdOrder;
		private DevExpress.XtraGrid.Columns.GridColumn Produto;
		private DevExpress.XtraGrid.Columns.GridColumn Valor_unitario;
		private DevExpress.XtraGrid.Columns.GridColumn Quantidade;
		private System.Windows.Forms.BindingSource orderDTOBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn Valor_total;
		private DevExpress.XtraGrid.Columns.GridColumn descrição;
		private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
		private DevExpress.XtraTab.XtraTabPage Pedidos;
	}
}