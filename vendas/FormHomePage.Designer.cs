
namespace vendas
{
    partial class FormHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            this.panelFormSelected = new System.Windows.Forms.Panel();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadasroDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormSelected
            // 
            this.panelFormSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormSelected.Location = new System.Drawing.Point(0, 24);
            this.panelFormSelected.Name = "panelFormSelected";
            this.panelFormSelected.Size = new System.Drawing.Size(1008, 537);
            this.panelFormSelected.TabIndex = 1;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.AutoSize = false;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.cadasroDeUsuáriosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.realizarPedidosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            this.menuToolStripMenuItem.ToolTipText = "M";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.homeToolStripMenuItem.Text = "&Home";
            this.homeToolStripMenuItem.ToolTipText = "H";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.BtnRegisterUserMenu_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.usuáriosToolStripMenuItem.Text = "&Usuários";
            this.usuáriosToolStripMenuItem.ToolTipText = "U";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.BtnUsersMenu_Click);
            // 
            // cadasroDeUsuáriosToolStripMenuItem
            // 
            this.cadasroDeUsuáriosToolStripMenuItem.Name = "cadasroDeUsuáriosToolStripMenuItem";
            this.cadasroDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadasroDeUsuáriosToolStripMenuItem.Text = "&Cadastro de Usuários";
            this.cadasroDeUsuáriosToolStripMenuItem.ToolTipText = "C";
            this.cadasroDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.BntRegisterUsersMenu_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.produtosToolStripMenuItem.Text = "&Produtos";
            this.produtosToolStripMenuItem.ToolTipText = "P";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.BtnProductMenu_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "C&adastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.ToolTipText = "C";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.BtnRegisterProductMenu_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pedidosToolStripMenuItem.Text = "P&edidos";
            this.pedidosToolStripMenuItem.ToolTipText = "E";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.BtnPurchasesSalesMenu_Click);
            // 
            // realizarPedidosToolStripMenuItem
            // 
            this.realizarPedidosToolStripMenuItem.Name = "realizarPedidosToolStripMenuItem";
            this.realizarPedidosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.realizarPedidosToolStripMenuItem.Text = "&Realizar Pedidos";
            this.realizarPedidosToolStripMenuItem.ToolTipText = "R";
            this.realizarPedidosToolStripMenuItem.Click += new System.EventHandler(this.BtnRegisterPurchases_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.ToolTipText = "S";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelFormSelected);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "FormHomePage";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelFormSelected;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadasroDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}