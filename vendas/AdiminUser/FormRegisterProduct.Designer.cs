
namespace vendas
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
            this.cadastroButton = new DevExpress.XtraEditors.SimpleButton();
            this.descriptionValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.valueValue = new DevExpress.XtraEditors.TextEdit();
            this.nameLabel = new DevExpress.XtraEditors.LabelControl();
            this.valorLabel = new DevExpress.XtraEditors.LabelControl();
            this.descricaoLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameValue
            // 
            this.nameValue.EditValue = "Produto 1";
            this.nameValue.Location = new System.Drawing.Point(70, 22);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(417, 20);
            this.nameValue.TabIndex = 12;
            // 
            // stockValue
            // 
            this.stockValue.EditValue = "50";
            this.stockValue.Location = new System.Drawing.Point(293, 74);
            this.stockValue.Name = "stockValue";
            this.stockValue.Properties.BeepOnError = false;
            this.stockValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.stockValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.stockValue.Properties.MaskSettings.Set("mask", "d");
            this.stockValue.Size = new System.Drawing.Size(194, 20);
            this.stockValue.TabIndex = 15;
            // 
            // cadastroButton
            // 
            this.cadastroButton.Location = new System.Drawing.Point(119, 127);
            this.cadastroButton.Name = "cadastroButton";
            this.cadastroButton.Size = new System.Drawing.Size(304, 33);
            this.cadastroButton.TabIndex = 16;
            this.cadastroButton.Text = "Cadastrar";
            this.cadastroButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // descriptionValue
            // 
            this.descriptionValue.EditValue = "Esse produto é bom";
            this.descriptionValue.Location = new System.Drawing.Point(70, 48);
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.Size = new System.Drawing.Size(417, 20);
            this.descriptionValue.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(238, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Estoque : ";
            // 
            // valueValue
            // 
            this.valueValue.EditValue = "200";
            this.valueValue.Location = new System.Drawing.Point(70, 74);
            this.valueValue.Name = "valueValue";
            this.valueValue.Properties.BeepOnError = false;
            this.valueValue.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.valueValue.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.valueValue.Properties.MaskSettings.Set("mask", "c");
            this.valueValue.Properties.MaskSettings.Set("culture", "pt-BR");
            this.valueValue.Properties.MaskSettings.Set("autoHideDecimalSeparator", true);
            this.valueValue.Properties.UseMaskAsDisplayFormat = true;
            this.valueValue.Size = new System.Drawing.Size(162, 20);
            this.valueValue.TabIndex = 14;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Location = new System.Drawing.Point(30, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Nome :";
            // 
            // valorLabel
            // 
            this.valorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorLabel.Location = new System.Drawing.Point(33, 77);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(34, 13);
            this.valorLabel.TabIndex = 19;
            this.valorLabel.Text = "Valor : ";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoLabel.Location = new System.Drawing.Point(11, 51);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(56, 13);
            this.descricaoLabel.TabIndex = 18;
            this.descricaoLabel.Text = "Descrição : ";
            // 
            // FormRegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 194);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.stockValue);
            this.Controls.Add(this.cadastroButton);
            this.Controls.Add(this.descriptionValue);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.valueValue);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.descricaoLabel);
            this.MaximumSize = new System.Drawing.Size(545, 233);
            this.MinimumSize = new System.Drawing.Size(545, 233);
            this.Name = "FormRegisterProduct";
            this.Text = "FormRegisterProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nameValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit nameValue;
        public DevExpress.XtraEditors.TextEdit stockValue;
        private DevExpress.XtraEditors.SimpleButton cadastroButton;
        private DevExpress.XtraEditors.TextEdit descriptionValue;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit valueValue;
        private DevExpress.XtraEditors.LabelControl nameLabel;
        private DevExpress.XtraEditors.LabelControl valorLabel;
        private DevExpress.XtraEditors.LabelControl descricaoLabel;
    }
}