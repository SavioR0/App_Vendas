
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
            this.gridSale = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Produto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTExt4 = new System.Windows.Forms.Label();
            this.btnSearchProd = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxFilterSale = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditSearch = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnExclude = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.GenerateReport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSale
            // 
            this.gridSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSale.DataSource = typeof(Vendas.Entity.Entities.Sale);
            this.gridSale.Location = new System.Drawing.Point(12, 33);
            this.gridSale.MainView = this.gridView3;
            this.gridSale.Name = "gridSale";
            this.gridSale.Size = new System.Drawing.Size(984, 432);
            this.gridSale.TabIndex = 2;
            this.gridSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Produto,
            this.Cliente,
            this.Vendedor,
            this.Value});
            this.gridView3.GridControl = this.gridSale;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 64;
            // 
            // Produto
            // 
            this.Produto.Caption = "Produto";
            this.Produto.FieldName = "Product.Name";
            this.Produto.Name = "Produto";
            this.Produto.Visible = true;
            this.Produto.VisibleIndex = 1;
            this.Produto.Width = 237;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Client.Name";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 2;
            this.Cliente.Width = 357;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Seller.Name";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 3;
            this.Vendedor.Width = 272;
            // 
            // Value
            // 
            this.Value.Caption = "Valor";
            this.Value.FieldName = "Product.Value";
            this.Value.Name = "Value";
            this.Value.Visible = true;
            this.Value.VisibleIndex = 4;
            this.Value.Width = 87;
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
            this.btnSearchProd.Location = new System.Drawing.Point(845, 7);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(150, 20);
            this.btnSearchProd.TabIndex = 109;
            this.btnSearchProd.Text = "Filtrar";
            this.btnSearchProd.ToolTip = "Aplicar filtro";
            this.btnSearchProd.Click += new System.EventHandler(this.BtnSearchProd_Click);
            // 
            // comboBoxFilterSale
            // 
            this.comboBoxFilterSale.EditValue = "";
            this.comboBoxFilterSale.Location = new System.Drawing.Point(47, 7);
            this.comboBoxFilterSale.Name = "comboBoxFilterSale";
            this.comboBoxFilterSale.Properties.BeepOnError = false;
            this.comboBoxFilterSale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxFilterSale.Properties.Items.AddRange(new object[] {
            "Id",
            "Vendedor",
            "Produto"});
            this.comboBoxFilterSale.Size = new System.Drawing.Size(75, 20);
            this.comboBoxFilterSale.TabIndex = 108;
            this.comboBoxFilterSale.ToolTip = "Informe o atributo para o filtro";
            this.comboBoxFilterSale.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterSale_SelectedIndexChanged);
            // 
            // textEditSearch
            // 
            this.textEditSearch.EditValue = "";
            this.textEditSearch.Enabled = false;
            this.textEditSearch.Location = new System.Drawing.Point(183, 7);
            this.textEditSearch.Name = "textEditSearch";
            this.textEditSearch.Properties.BeepOnError = false;
            this.textEditSearch.Size = new System.Drawing.Size(191, 20);
            this.textEditSearch.TabIndex = 110;
            this.textEditSearch.ToolTip = "Informe o que deseja filtrar";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(846, 471);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(150, 30);
            this.simpleButton1.TabIndex = 116;
            this.simpleButton1.Text = "Cadastrar";
            this.simpleButton1.ToolTip = "Cadastrar pedido";
            this.simpleButton1.Click += new System.EventHandler(this.Register_Click_1);
            // 
            // btnExclude
            // 
            this.btnExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExclude.Location = new System.Drawing.Point(690, 471);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(150, 30);
            this.btnExclude.TabIndex = 115;
            this.btnExclude.Text = "Excluir";
            this.btnExclude.ToolTip = "Excluir pedido";
            this.btnExclude.Click += new System.EventHandler(this.BtnExclude_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(534, 471);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 30);
            this.btnEdit.TabIndex = 114;
            this.btnEdit.Text = "Editar";
            this.btnEdit.ToolTip = "Editar pedido";
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
            this.xtraTabPage2.Controls.Add(this.GenerateReport);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.simpleButton1);
            this.xtraTabPage2.Controls.Add(this.gridSale);
            this.xtraTabPage2.Controls.Add(this.btnExclude);
            this.xtraTabPage2.Controls.Add(this.textEditSearch);
            this.xtraTabPage2.Controls.Add(this.btnEdit);
            this.xtraTabPage2.Controls.Add(this.comboBoxFilterSale);
            this.xtraTabPage2.Controls.Add(this.btnSearchProd);
            this.xtraTabPage2.Controls.Add(this.labelTExt4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1006, 512);
            this.xtraTabPage2.Text = "Pedidos";
            // 
            // GenerateReport
            // 
            this.GenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateReport.Location = new System.Drawing.Point(12, 471);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(150, 30);
            this.GenerateReport.TabIndex = 117;
            this.GenerateReport.Text = "Gerar Relatório";
            this.GenerateReport.ToolTip = "Gerar relatório de Pedidos";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridSale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTExt4;
        private DevExpress.XtraEditors.SimpleButton btnSearchProd;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxFilterSale;
        private DevExpress.XtraEditors.TextEdit textEditSearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnExclude;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn Produto;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton GenerateReport;
    }
}