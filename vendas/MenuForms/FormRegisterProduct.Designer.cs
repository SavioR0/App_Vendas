
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
            this.titlePage = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueValue.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameValue
            // 
            this.nameValue.EditValue = "Produto 1";
            this.nameValue.Location = new System.Drawing.Point(143, 90);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(670, 20);
            this.nameValue.TabIndex = 21;
            // 
            // stockValue
            // 
            this.stockValue.EditValue = "50";
            this.stockValue.Location = new System.Drawing.Point(366, 142);
            this.stockValue.Name = "stockValue";
            this.stockValue.Properties.BeepOnError = false;
            this.stockValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.stockValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.stockValue.Properties.MaskSettings.Set("mask", "d");
            this.stockValue.Size = new System.Drawing.Size(447, 20);
            this.stockValue.TabIndex = 24;
            // 
            // btnRegisterEditProduct
            // 
            this.btnRegisterEditProduct.Location = new System.Drawing.Point(526, 521);
            this.btnRegisterEditProduct.Name = "btnRegisterEditProduct";
            this.btnRegisterEditProduct.Size = new System.Drawing.Size(288, 33);
            this.btnRegisterEditProduct.TabIndex = 25;
            this.btnRegisterEditProduct.Text = "Cadastrar";
            this.btnRegisterEditProduct.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // descriptionValue
            // 
            this.descriptionValue.EditValue = "Esse produto é bom";
            this.descriptionValue.Location = new System.Drawing.Point(143, 116);
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.Size = new System.Drawing.Size(670, 20);
            this.descriptionValue.TabIndex = 22;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(311, 145);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Estoque : ";
            // 
            // valueValue
            // 
            this.valueValue.EditValue = "200";
            this.valueValue.Location = new System.Drawing.Point(143, 142);
            this.valueValue.Name = "valueValue";
            this.valueValue.Properties.BeepOnError = false;
            this.valueValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.valueValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.valueValue.Properties.MaskSettings.Set("mask", "c");
            this.valueValue.Properties.MaskSettings.Set("culture", "pt-BR");
            this.valueValue.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.valueValue.Properties.UseMaskAsDisplayFormat = true;
            this.valueValue.Size = new System.Drawing.Size(60, 20);
            this.valueValue.TabIndex = 23;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Location = new System.Drawing.Point(103, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "Nome :";
            // 
            // valorLabel
            // 
            this.valorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorLabel.Location = new System.Drawing.Point(106, 145);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(34, 13);
            this.valorLabel.TabIndex = 28;
            this.valorLabel.Text = "Valor : ";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoLabel.Location = new System.Drawing.Point(84, 119);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(56, 13);
            this.descricaoLabel.TabIndex = 27;
            this.descricaoLabel.Text = "Descrição : ";
            // 
            // titlePage
            // 
            this.titlePage.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePage.Appearance.Options.UseFont = true;
            this.titlePage.Location = new System.Drawing.Point(320, 6);
            this.titlePage.Name = "titlePage";
            this.titlePage.Size = new System.Drawing.Size(216, 25);
            this.titlePage.TabIndex = 0;
            this.titlePage.Text = "Cadastro de Produto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.titlePage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 38);
            this.panel1.TabIndex = 107;
            // 
            // FormRegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.stockValue);
            this.Controls.Add(this.btnRegisterEditProduct);
            this.Controls.Add(this.descriptionValue);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.valueValue);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.descricaoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegisterProduct";
            this.Text = "FormRegisterProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueValue.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.LabelControl titlePage;
        private System.Windows.Forms.Panel panel1;
    }
}