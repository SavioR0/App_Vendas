
namespace vendas.MenuForms
{
    partial class FormRegisterProduct
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
            this.nameValue = new DevExpress.XtraEditors.TextEdit();
            this.stockValue = new DevExpress.XtraEditors.TextEdit();
            this.btnRegisterEditProduct = new DevExpress.XtraEditors.SimpleButton();
            this.descriptionValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.valueValue = new DevExpress.XtraEditors.TextEdit();
            this.nameLabel = new DevExpress.XtraEditors.LabelControl();
            this.valorLabel = new DevExpress.XtraEditors.LabelControl();
            this.descricaoLabel = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameValue
            // 
            this.nameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameValue.EditValue = "";
            this.nameValue.Location = new System.Drawing.Point(107, 34);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(794, 20);
            this.nameValue.TabIndex = 21;
            this.nameValue.ToolTip = "Informe o nome do produto";
            // 
            // stockValue
            // 
            this.stockValue.EditValue = "";
            this.stockValue.Location = new System.Drawing.Point(286, 116);
            this.stockValue.Name = "stockValue";
            this.stockValue.Properties.BeepOnError = false;
            this.stockValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.stockValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.stockValue.Properties.MaskSettings.Set("mask", "d");
            this.stockValue.Size = new System.Drawing.Size(140, 20);
            this.stockValue.TabIndex = 24;
            this.stockValue.ToolTip = "Informe a quantidade de produtos no estoque";
            // 
            // btnRegisterEditProduct
            // 
            this.btnRegisterEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterEditProduct.Location = new System.Drawing.Point(751, 471);
            this.btnRegisterEditProduct.Name = "btnRegisterEditProduct";
            this.btnRegisterEditProduct.Size = new System.Drawing.Size(150, 30);
            this.btnRegisterEditProduct.TabIndex = 25;
            this.btnRegisterEditProduct.Text = "&Cadastrar";
            this.btnRegisterEditProduct.ToolTip = "C - Cadastro ddo produto";
            this.btnRegisterEditProduct.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // descriptionValue
            // 
            this.descriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionValue.EditValue = "";
            this.descriptionValue.Location = new System.Drawing.Point(107, 75);
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.Size = new System.Drawing.Size(794, 20);
            this.descriptionValue.TabIndex = 22;
            this.descriptionValue.ToolTip = "informe a descrição do produto";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(286, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Estoque ";
            // 
            // valueValue
            // 
            this.valueValue.EditValue = " ";
            this.valueValue.Location = new System.Drawing.Point(107, 116);
            this.valueValue.Name = "valueValue";
            this.valueValue.Properties.BeepOnError = false;
            this.valueValue.Properties.MaskSettings.Set("mask", "c");
            this.valueValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.valueValue.Properties.UseMaskAsDisplayFormat = true;
            this.valueValue.Size = new System.Drawing.Size(162, 20);
            this.valueValue.TabIndex = 23;
            this.valueValue.ToolTip = "Informe valor que do produto";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Location = new System.Drawing.Point(107, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(27, 13);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "Nome";
            // 
            // valorLabel
            // 
            this.valorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorLabel.Location = new System.Drawing.Point(107, 99);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(27, 13);
            this.valorLabel.TabIndex = 28;
            this.valorLabel.Text = "Valor ";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoLabel.Location = new System.Drawing.Point(107, 58);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(49, 13);
            this.descricaoLabel.TabIndex = 27;
            this.descricaoLabel.Text = "Descrição ";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1008, 537);
            this.xtraTabControl1.TabIndex = 30;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AllowDrop = true;
            this.xtraTabPage1.Controls.Add(this.nameLabel);
            this.xtraTabPage1.Controls.Add(this.nameValue);
            this.xtraTabPage1.Controls.Add(this.descricaoLabel);
            this.xtraTabPage1.Controls.Add(this.stockValue);
            this.xtraTabPage1.Controls.Add(this.valorLabel);
            this.xtraTabPage1.Controls.Add(this.btnRegisterEditProduct);
            this.xtraTabPage1.Controls.Add(this.valueValue);
            this.xtraTabPage1.Controls.Add(this.descriptionValue);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1006, 512);
            this.xtraTabPage1.Text = "Registro de Produto";
            // 
            // FormRegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1008, 537);
            this.Name = "FormRegisterProduct";
            this.Text = "FormRegisterProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit nameValue;
        public DevExpress.XtraEditors.TextEdit stockValue;
        private DevExpress.XtraEditors.SimpleButton btnRegisterEditProduct;
        private DevExpress.XtraEditors.TextEdit descriptionValue;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit valueValue;
        private DevExpress.XtraEditors.LabelControl nameLabel;
        private DevExpress.XtraEditors.LabelControl valorLabel;
        private DevExpress.XtraEditors.LabelControl descricaoLabel;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
    }
}