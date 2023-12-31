﻿
namespace vendas.MenuForms
{
    partial class FormRegisterOrder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterOrder));
			this.ValueTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.label3 = new System.Windows.Forms.Label();
			this.gridOrders = new DevExpress.XtraGrid.GridControl();
			this.OrderDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NameP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.descricao = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ValorU = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnExclude = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numValueEdit = new DevExpress.XtraEditors.SpinEdit();
			this.ComboBoxProduct = new DevExpress.XtraEditors.ComboBoxEdit();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
			this.ValueEdit = new System.Windows.Forms.Label();
			this.Label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ValueTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderDTOBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numValueEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ComboBoxProduct.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.xtraTabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ValueTextEdit
			// 
			this.ValueTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ValueTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
			this.ValueTextEdit.Location = new System.Drawing.Point(1342, 476);
			this.ValueTextEdit.Name = "ValueTextEdit";
			this.ValueTextEdit.Properties.BeepOnError = false;
			this.ValueTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.ValueTextEdit.Properties.MaskSettings.Set("mask", "c");
			this.ValueTextEdit.Properties.ReadOnly = true;
			this.ValueTextEdit.Size = new System.Drawing.Size(135, 20);
			this.ValueTextEdit.TabIndex = 67;
			this.ValueTextEdit.ToolTip = "Valor total da compra";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1288, 479);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 66;
			this.label3.Text = "TOTAL :  ";
			// 
			// gridOrders
			// 
			this.gridOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridOrders.DataSource = this.OrderDTOBindingSource;
			this.gridOrders.Location = new System.Drawing.Point(11, 33);
			this.gridOrders.MainView = this.gridView2;
			this.gridOrders.Name = "gridOrders";
			this.gridOrders.Size = new System.Drawing.Size(984, 432);
			this.gridOrders.TabIndex = 6;
			this.gridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// OrderDTOBindingSource
			// 
			this.OrderDTOBindingSource.DataSource = typeof(Vendas.DTO.OrderDTO);
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.NameP,
            this.descricao,
            this.Vendedor,
            this.ValorU,
            this.Quantidade,
            this.Valor});
			this.gridView2.GridControl = this.gridOrders;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsBehavior.ReadOnly = true;
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// Id
			// 
			this.Id.Caption = "Id";
			this.Id.FieldName = "ProductDTO.Id";
			this.Id.Name = "Id";
			this.Id.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
			this.Id.Width = 47;
			// 
			// NameP
			// 
			this.NameP.Caption = "Nome";
			this.NameP.FieldName = "ProductDTO.Name";
			this.NameP.Name = "NameP";
			this.NameP.Visible = true;
			this.NameP.VisibleIndex = 0;
			this.NameP.Width = 109;
			// 
			// descricao
			// 
			this.descricao.Caption = "Descrição";
			this.descricao.FieldName = "ProductDTO.Description";
			this.descricao.Name = "descricao";
			this.descricao.Visible = true;
			this.descricao.VisibleIndex = 1;
			this.descricao.Width = 241;
			// 
			// Vendedor
			// 
			this.Vendedor.Caption = "Vendedor";
			this.Vendedor.FieldName = "ProductDTO.SellerName";
			this.Vendedor.Name = "Vendedor";
			this.Vendedor.Visible = true;
			this.Vendedor.VisibleIndex = 5;
			this.Vendedor.Width = 226;
			// 
			// ValorU
			// 
			this.ValorU.Caption = "Valor Unitário";
			this.ValorU.FieldName = "ProductDTO.Value";
			this.ValorU.Name = "ValorU";
			this.ValorU.Visible = true;
			this.ValorU.VisibleIndex = 3;
			// 
			// Quantidade
			// 
			this.Quantidade.Caption = "Quantidade";
			this.Quantidade.FieldName = "Quantity";
			this.Quantidade.Name = "Quantidade";
			this.Quantidade.Visible = true;
			this.Quantidade.VisibleIndex = 2;
			this.Quantidade.Width = 140;
			// 
			// Valor
			// 
			this.Valor.Caption = "Valor Total";
			this.Valor.FieldName = "ValueOrder";
			this.Valor.Name = "Valor";
			this.Valor.Visible = true;
			this.Valor.VisibleIndex = 4;
			this.Valor.Width = 102;
			// 
			// btnExclude
			// 
			this.btnExclude.AccessibleName = "btnExclude";
			this.btnExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExclude.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExclude.ImageOptions.Image")));
			this.btnExclude.Location = new System.Drawing.Point(789, 2);
			this.btnExclude.Name = "btnExclude";
			this.btnExclude.Size = new System.Drawing.Size(100, 30);
			this.btnExclude.TabIndex = 3;
			this.btnExclude.Text = "&Remover";
			this.btnExclude.ToolTip = "R - Remover produto selecionado";
			this.btnExclude.Click += new System.EventHandler(this.RemoveOrderList);
			// 
			// simpleButton1
			// 
			this.simpleButton1.AccessibleName = "btnUpdate";
			this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.simpleButton1.Location = new System.Drawing.Point(11, 471);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(100, 30);
			this.simpleButton1.TabIndex = 5;
			this.simpleButton1.Text = "&Comprar";
			this.simpleButton1.ToolTip = "F - Finalizar pedidos realizar a compra";
			this.simpleButton1.Click += new System.EventHandler(this.RegisterOrders);
			// 
			// btnUpdate
			// 
			this.btnUpdate.AccessibleName = "btnUpdate";
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
			this.btnUpdate.Location = new System.Drawing.Point(895, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 30);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "&Adicionar";
			this.btnUpdate.ToolTip = "A - Adicionar o produto no carrinho";
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(167, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 61;
			this.label2.Text = "Quantidade";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 58;
			this.label1.Text = "Produto";
			// 
			// numValueEdit
			// 
			this.numValueEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numValueEdit.Location = new System.Drawing.Point(236, 7);
			this.numValueEdit.Name = "numValueEdit";
			this.numValueEdit.Properties.BeepOnError = false;
			this.numValueEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.numValueEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
			this.numValueEdit.Properties.MaskSettings.Set("mask", "d");
			this.numValueEdit.Size = new System.Drawing.Size(100, 20);
			this.numValueEdit.TabIndex = 2;
			this.numValueEdit.ToolTip = "Informe a quantidade do produto selecionado";
			// 
			// ComboBoxProduct
			// 
			this.ComboBoxProduct.Location = new System.Drawing.Point(61, 7);
			this.ComboBoxProduct.Name = "ComboBoxProduct";
			this.ComboBoxProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ComboBoxProduct.Size = new System.Drawing.Size(100, 20);
			this.ComboBoxProduct.TabIndex = 1;
			this.ComboBoxProduct.ToolTip = "Selecione o produto";
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
			this.xtraTabControl1.Size = new System.Drawing.Size(1008, 537);
			this.xtraTabControl1.TabIndex = 68;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
			// 
			// xtraTabPage2
			// 
			this.xtraTabPage2.Controls.Add(this.ValueEdit);
			this.xtraTabPage2.Controls.Add(this.Label);
			this.xtraTabPage2.Controls.Add(this.label1);
			this.xtraTabPage2.Controls.Add(this.ValueTextEdit);
			this.xtraTabPage2.Controls.Add(this.label2);
			this.xtraTabPage2.Controls.Add(this.label3);
			this.xtraTabPage2.Controls.Add(this.btnUpdate);
			this.xtraTabPage2.Controls.Add(this.gridOrders);
			this.xtraTabPage2.Controls.Add(this.simpleButton1);
			this.xtraTabPage2.Controls.Add(this.ComboBoxProduct);
			this.xtraTabPage2.Controls.Add(this.numValueEdit);
			this.xtraTabPage2.Controls.Add(this.btnExclude);
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new System.Drawing.Size(1006, 512);
			this.xtraTabPage2.Text = "Registro de Pedidos";
			// 
			// ValueEdit
			// 
			this.ValueEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ValueEdit.AutoSize = true;
			this.ValueEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ValueEdit.Location = new System.Drawing.Point(867, 475);
			this.ValueEdit.Name = "ValueEdit";
			this.ValueEdit.Size = new System.Drawing.Size(13, 18);
			this.ValueEdit.TabIndex = 69;
			this.ValueEdit.Text = " ";
			// 
			// Label
			// 
			this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Label.AutoSize = true;
			this.Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label.Location = new System.Drawing.Point(762, 475);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(99, 18);
			this.Label.TabIndex = 68;
			this.Label.Text = "Valor Total :";
			// 
			// FormRegisterOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 537);
			this.Controls.Add(this.xtraTabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormRegisterOrder";
			this.Text = "FormRegisterOrder";
			((System.ComponentModel.ISupportInitialize)(this.ValueTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderDTOBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numValueEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ComboBoxProduct.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.xtraTabPage2.ResumeLayout(false);
			this.xtraTabPage2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit ValueTextEdit;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn NameP;
        private DevExpress.XtraGrid.Columns.GridColumn descricao;
        private DevExpress.XtraGrid.Columns.GridColumn Quantidade;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraEditors.SimpleButton btnExclude;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit numValueEdit;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxProduct;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Label ValueEdit;
        private System.Windows.Forms.Label Label;
		private System.Windows.Forms.BindingSource OrderDTOBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn ValorU;
	}
}