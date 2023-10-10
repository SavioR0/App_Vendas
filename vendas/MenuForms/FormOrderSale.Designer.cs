
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTExt4 = new System.Windows.Forms.Label();
            this.btnSearchProd = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxFilterProd = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditSearch = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnExclude = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.Produto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterProd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSale
            // 
            this.gridSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSale.DataSource = typeof(Vendas.Entity.Entities.Sale);
            this.gridSale.Location = new System.Drawing.Point(12, 75);
            this.gridSale.MainView = this.gridView3;
            this.gridSale.Name = "gridSale";
            this.gridSale.Size = new System.Drawing.Size(1042, 418);
            this.gridSale.TabIndex = 2;
            this.gridSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Produto,
            this.Cliente,
            this.Vendedor,
            this.Value});
            this.gridView3.GridControl = this.gridSale;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 38);
            this.panel1.TabIndex = 113;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(472, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 25);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Pedidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 112;
            this.label6.Text = "Filtro :";
            // 
            // labelTExt4
            // 
            this.labelTExt4.AutoSize = true;
            this.labelTExt4.Location = new System.Drawing.Point(139, 52);
            this.labelTExt4.Name = "labelTExt4";
            this.labelTExt4.Size = new System.Drawing.Size(37, 13);
            this.labelTExt4.TabIndex = 111;
            this.labelTExt4.Text = "Valor :";
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProd.Location = new System.Drawing.Point(863, 47);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(191, 23);
            this.btnSearchProd.TabIndex = 109;
            this.btnSearchProd.Text = "Filtrar";
            // 
            // comboBoxFilterProd
            // 
            this.comboBoxFilterProd.EditValue = "";
            this.comboBoxFilterProd.Location = new System.Drawing.Point(55, 49);
            this.comboBoxFilterProd.Name = "comboBoxFilterProd";
            this.comboBoxFilterProd.Properties.BeepOnError = false;
            this.comboBoxFilterProd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxFilterProd.Properties.Items.AddRange(new object[] {
            "Id",
            "Nome"});
            this.comboBoxFilterProd.Size = new System.Drawing.Size(75, 20);
            this.comboBoxFilterProd.TabIndex = 108;
            // 
            // textEditSearch
            // 
            this.textEditSearch.EditValue = "";
            this.textEditSearch.Enabled = false;
            this.textEditSearch.Location = new System.Drawing.Point(183, 49);
            this.textEditSearch.Name = "textEditSearch";
            this.textEditSearch.Properties.BeepOnError = false;
            this.textEditSearch.Size = new System.Drawing.Size(191, 20);
            this.textEditSearch.TabIndex = 110;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(937, 522);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 30);
            this.simpleButton1.TabIndex = 116;
            this.simpleButton1.Text = "Cadastrar";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // btnExclude
            // 
            this.btnExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExclude.Location = new System.Drawing.Point(691, 522);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(117, 30);
            this.btnExclude.TabIndex = 115;
            this.btnExclude.Text = "Excluir";
            this.btnExclude.Click += new System.EventHandler(this.BtnExclude_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(814, 522);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 30);
            this.btnEdit.TabIndex = 114;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // Produto
            // 
            this.Produto.Caption = "Produto";
            this.Produto.FieldName = "Product.Name";
            this.Produto.Name = "Produto";
            this.Produto.Visible = true;
            this.Produto.VisibleIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Client.Name";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 1;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Seller.Name";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 2;
            // 
            // Value
            // 
            this.Value.Caption = "Valor";
            this.Value.FieldName = "Product.Value";
            this.Value.Name = "Value";
            this.Value.Visible = true;
            this.Value.VisibleIndex = 3;
            // 
            // FormOrderSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 564);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnExclude);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTExt4);
            this.Controls.Add(this.btnSearchProd);
            this.Controls.Add(this.comboBoxFilterProd);
            this.Controls.Add(this.textEditSearch);
            this.Controls.Add(this.gridSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrderSale";
            this.Text = "FormPurcharse";
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterProd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridSale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTExt4;
        private DevExpress.XtraEditors.SimpleButton btnSearchProd;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxFilterProd;
        private DevExpress.XtraEditors.TextEdit textEditSearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnExclude;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn Produto;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
    }
}