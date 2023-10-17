
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ValueTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.gridOrders = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExclude = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numValueEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ComboBoxProduct = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValueEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxProduct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(406, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(173, 25);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Realizar Pedidos";
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
            this.panel1.TabIndex = 107;
            // 
            // ValueTextEdit
            // 
            this.ValueTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.ValueTextEdit.Location = new System.Drawing.Point(919, 532);
            this.ValueTextEdit.Name = "ValueTextEdit";
            this.ValueTextEdit.Properties.BeepOnError = false;
            this.ValueTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.ValueTextEdit.Properties.MaskSettings.Set("mask", "c");
            this.ValueTextEdit.Properties.ReadOnly = true;
            this.ValueTextEdit.Size = new System.Drawing.Size(135, 20);
            this.ValueTextEdit.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(865, 535);
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
            this.gridOrders.DataSource = typeof(Vendas.Entity.Entities.Product);
            this.gridOrders.Location = new System.Drawing.Point(12, 74);
            this.gridOrders.MainView = this.gridView2;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(1042, 425);
            this.gridOrders.TabIndex = 65;
            this.gridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView2.GridControl = this.gridOrders;
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
            this.Vendedor.Width = 226;
            // 
            // btnExclude
            // 
            this.btnExclude.AccessibleName = "btnExclude";
            this.btnExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExclude.Location = new System.Drawing.Point(12, 530);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(135, 24);
            this.btnExclude.TabIndex = 64;
            this.btnExclude.Text = "Remover Produto";
            this.btnExclude.Click += new System.EventHandler(this.RemoveOrderList);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AccessibleName = "btnUpdate";
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(156, 530);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(186, 24);
            this.simpleButton1.TabIndex = 63;
            this.simpleButton1.Text = "Finalizar Pedidos";
            this.simpleButton1.Click += new System.EventHandler(this.RegisterOrders);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleName = "btnUpdate";
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(880, 44);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 24);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "Adicionar Produto(s)";
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Quantidade : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
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
            this.numValueEdit.Location = new System.Drawing.Point(242, 46);
            this.numValueEdit.Name = "numValueEdit";
            this.numValueEdit.Properties.BeepOnError = false;
            this.numValueEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numValueEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.numValueEdit.Properties.MaskSettings.Set("mask", "d");
            this.numValueEdit.Size = new System.Drawing.Size(100, 20);
            this.numValueEdit.TabIndex = 60;
            // 
            // ComboBoxProduct
            // 
            this.ComboBoxProduct.Location = new System.Drawing.Point(59, 46);
            this.ComboBoxProduct.Name = "ComboBoxProduct";
            this.ComboBoxProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxProduct.Size = new System.Drawing.Size(100, 20);
            this.ComboBoxProduct.TabIndex = 59;
            this.ComboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProduct_SelectedIndexChanged);
            // 
            // FormRegisterOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 564);
            this.Controls.Add(this.ValueTextEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.ComboBoxProduct);
            this.Controls.Add(this.btnExclude);
            this.Controls.Add(this.numValueEdit);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegisterOrder";
            this.Text = "FormRegisterOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValueEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxProduct.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit ValueTextEdit;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn IdP;
        private DevExpress.XtraGrid.Columns.GridColumn NameP;
        private DevExpress.XtraGrid.Columns.GridColumn descricao;
        private DevExpress.XtraGrid.Columns.GridColumn estoque;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraEditors.SimpleButton btnExclude;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit numValueEdit;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxProduct;
    }
}