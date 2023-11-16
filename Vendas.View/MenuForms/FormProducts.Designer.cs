
namespace vendas.MenuForms
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTExt4 = new System.Windows.Forms.Label();
            this.btnSearchProd = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxFilterProd = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnExclude = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.LabelNumProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.GenerateReport = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterProd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProduct
            // 
            this.gridProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProduct.DataSource = typeof(Vendas.Entity.Entities.Product);
            this.gridProduct.Location = new System.Drawing.Point(12, 33);
            this.gridProduct.MainView = this.gridView2;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(983, 432);
            this.gridProduct.TabIndex = 10;
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
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridProduct;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // IdP
            // 
            this.IdP.Caption = "Id";
            this.IdP.FieldName = "Id";
            this.IdP.Name = "IdP";
            this.IdP.Width = 47;
            // 
            // NameP
            // 
            this.NameP.Caption = "Nome";
            this.NameP.FieldName = "Name";
            this.NameP.Name = "NameP";
            this.NameP.Visible = true;
            this.NameP.VisibleIndex = 0;
            this.NameP.Width = 109;
            // 
            // descricao
            // 
            this.descricao.Caption = "Descrição";
            this.descricao.FieldName = "Description";
            this.descricao.Name = "descricao";
            this.descricao.Visible = true;
            this.descricao.VisibleIndex = 1;
            this.descricao.Width = 241;
            // 
            // estoque
            // 
            this.estoque.Caption = "Estoque";
            this.estoque.FieldName = "Stock";
            this.estoque.Name = "estoque";
            this.estoque.Visible = true;
            this.estoque.VisibleIndex = 2;
            this.estoque.Width = 140;
            // 
            // Valor
            // 
            this.Valor.Caption = "Valor";
            this.Valor.FieldName = "Value";
            this.Valor.Name = "Valor";
            this.Valor.Visible = true;
            this.Valor.VisibleIndex = 3;
            this.Valor.Width = 102;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Seller.Name";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 4;
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
            // comboBoxFilterProd
            // 
            this.comboBoxFilterProd.EditValue = "";
            this.comboBoxFilterProd.Location = new System.Drawing.Point(47, 7);
            this.comboBoxFilterProd.Name = "comboBoxFilterProd";
            this.comboBoxFilterProd.Properties.BeepOnError = false;
            this.comboBoxFilterProd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxFilterProd.Properties.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Descrição",
            "Estoque",
            "Valor",
            "Vendedor"});
            this.comboBoxFilterProd.Size = new System.Drawing.Size(75, 20);
            this.comboBoxFilterProd.TabIndex = 1;
            this.comboBoxFilterProd.ToolTip = "Informe o atributo para o filtro";
            this.comboBoxFilterProd.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterProd_SelectedIndexChanged);
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
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(107, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "E&ditar";
            this.btnEdit.ToolTip = "D - Editar produto";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnExclude
            // 
            this.btnExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExclude.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExclude.ImageOptions.Image")));
            this.btnExclude.Location = new System.Drawing.Point(213, 0);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(100, 35);
            this.btnExclude.TabIndex = 8;
            this.btnExclude.Text = "&Excluir";
            this.btnExclude.ToolTip = "E - Excluir produto";
            this.btnExclude.Click += new System.EventHandler(this.BtnExclude_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 35);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "&Cadastrar";
            this.simpleButton1.ToolTip = "C - Cadastrar produto";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(1008, 537);
            this.xtraTabControl1.TabIndex = 112;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panelControl1);
            this.xtraTabPage2.Controls.Add(this.LabelNumProd);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Controls.Add(this.GenerateReport);
            this.xtraTabPage2.Controls.Add(this.textEditSearch);
            this.xtraTabPage2.Controls.Add(this.gridProduct);
            this.xtraTabPage2.Controls.Add(this.comboBoxFilterProd);
            this.xtraTabPage2.Controls.Add(this.btnSearchProd);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.labelTExt4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1006, 512);
            this.xtraTabPage2.Text = "Produtos";
            // 
            // LabelNumProd
            // 
            this.LabelNumProd.AutoSize = true;
            this.LabelNumProd.Location = new System.Drawing.Point(508, 10);
            this.LabelNumProd.Name = "LabelNumProd";
            this.LabelNumProd.Size = new System.Drawing.Size(13, 13);
            this.LabelNumProd.TabIndex = 122;
            this.LabelNumProd.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Produtos Cadastrados :";
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
            this.GenerateReport.ToolTip = "R - Gerar Relatório de Produtos";
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnExclude);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Location = new System.Drawing.Point(12, 471);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(315, 38);
            this.panelControl1.TabIndex = 123;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterProd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn IdP;
        private DevExpress.XtraGrid.Columns.GridColumn NameP;
        private DevExpress.XtraGrid.Columns.GridColumn descricao;
        private DevExpress.XtraGrid.Columns.GridColumn estoque;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTExt4;
        private DevExpress.XtraEditors.SimpleButton btnSearchProd;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxFilterProd;
        private DevExpress.XtraEditors.TextEdit textEditSearch;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnExclude;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton GenerateReport;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelNumProd;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}