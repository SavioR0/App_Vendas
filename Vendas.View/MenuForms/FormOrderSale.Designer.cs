
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
			this.comboBoxFilterSale = new DevExpress.XtraEditors.ComboBoxEdit();
			this.LabelNumOrder = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.GenerateReport = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridSale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.xtraTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterSale.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridSale
			// 
			this.gridSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridSale.DataSource = this.bindingSourceSales;
			this.gridSale.Location = new System.Drawing.Point(12, 33);
			this.gridSale.MainView = this.gridView3;
			this.gridSale.Name = "gridSale";
			this.gridSale.Size = new System.Drawing.Size(983, 432);
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
			this.label6.Location = new System.Drawing.Point(11, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 112;
			this.label6.Text = "Filtro";
			// 
			// labelTExt4
			// 
			this.labelTExt4.AutoSize = true;
			this.labelTExt4.Location = new System.Drawing.Point(129, 10);
			this.labelTExt4.Name = "labelTExt4";
			this.labelTExt4.Size = new System.Drawing.Size(49, 13);
			this.labelTExt4.TabIndex = 111;
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
			this.xtraTabPage2.Controls.Add(this.comboBoxFilterSale);
			this.xtraTabPage2.Controls.Add(this.LabelNumOrder);
			this.xtraTabPage2.Controls.Add(this.label1);
			this.xtraTabPage2.Controls.Add(this.simpleButton2);
			this.xtraTabPage2.Controls.Add(this.GenerateReport);
			this.xtraTabPage2.Controls.Add(this.label6);
			this.xtraTabPage2.Controls.Add(this.simpleButton1);
			this.xtraTabPage2.Controls.Add(this.gridSale);
			this.xtraTabPage2.Controls.Add(this.btnExclude);
			this.xtraTabPage2.Controls.Add(this.textEditSearch);
			this.xtraTabPage2.Controls.Add(this.btnEdit);
			this.xtraTabPage2.Controls.Add(this.btnSearchProd);
			this.xtraTabPage2.Controls.Add(this.labelTExt4);
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new System.Drawing.Size(1006, 512);
			this.xtraTabPage2.Text = "Pedidos";
			// 
			// comboBoxFilterSale
			// 
			this.comboBoxFilterSale.EditValue = "";
			this.comboBoxFilterSale.Location = new System.Drawing.Point(48, 7);
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
			this.LabelNumOrder.Location = new System.Drawing.Point(508, 10);
			this.LabelNumOrder.Name = "LabelNumOrder";
			this.LabelNumOrder.Size = new System.Drawing.Size(13, 13);
			this.LabelNumOrder.TabIndex = 124;
			this.LabelNumOrder.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(380, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 13);
			this.label1.TabIndex = 123;
			this.label1.Text = "Pedidos Cadastrados :";
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
			this.GenerateReport.TabIndex = 9;
			this.GenerateReport.Text = "&Relatório";
			this.GenerateReport.ToolTip = "R - Gerar relatório de Pedidos";
			this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
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
			this.xtraTabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterSale.Properties)).EndInit();
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
	}
}