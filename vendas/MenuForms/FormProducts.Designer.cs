
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnExclude = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterProd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProduct
            // 
            this.gridProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProduct.DataSource = typeof(Vendas.Entity.Entities.Product);
            this.gridProduct.Location = new System.Drawing.Point(12, 75);
            this.gridProduct.MainView = this.gridView2;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(1042, 418);
            this.gridProduct.TabIndex = 2;
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
            this.gridView2.OptionsBehavior.ReadOnly = true;
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Filtro :";
            // 
            // labelTExt4
            // 
            this.labelTExt4.AutoSize = true;
            this.labelTExt4.Location = new System.Drawing.Point(139, 52);
            this.labelTExt4.Name = "labelTExt4";
            this.labelTExt4.Size = new System.Drawing.Size(37, 13);
            this.labelTExt4.TabIndex = 44;
            this.labelTExt4.Text = "Valor :";
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProd.Location = new System.Drawing.Point(864, 47);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(191, 23);
            this.btnSearchProd.TabIndex = 42;
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
            this.comboBoxFilterProd.TabIndex = 41;
            // 
            // textEditSearch
            // 
            this.textEditSearch.EditValue = "";
            this.textEditSearch.Enabled = false;
            this.textEditSearch.Location = new System.Drawing.Point(183, 49);
            this.textEditSearch.Name = "textEditSearch";
            this.textEditSearch.Properties.BeepOnError = false;
            this.textEditSearch.Size = new System.Drawing.Size(191, 20);
            this.textEditSearch.TabIndex = 43;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl4.Location = new System.Drawing.Point(456, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 25);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Produtos";
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
            this.panel1.TabIndex = 108;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(814, 522);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 30);
            this.btnEdit.TabIndex = 109;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnExclude
            // 
            this.btnExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExclude.Location = new System.Drawing.Point(691, 522);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(117, 30);
            this.btnExclude.TabIndex = 110;
            this.btnExclude.Text = "Excluir";
            this.btnExclude.Click += new System.EventHandler(this.BtnExclude_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(937, 522);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 30);
            this.simpleButton1.TabIndex = 111;
            this.simpleButton1.Text = "Cadastrar";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // FormProducts
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
            this.Controls.Add(this.gridProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFilterProd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSearch.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnExclude;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}