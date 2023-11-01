
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsitarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.produtosToolStripMenuItem1,
            this.vendasToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarUsuáriosToolStripMenuItem,
            this.cadastroDeUsuáriosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cadastrosToolStripMenuItem.Text = "Usuários";
            // 
            // listarUsuáriosToolStripMenuItem
            // 
            this.listarUsuáriosToolStripMenuItem.Name = "listarUsuáriosToolStripMenuItem";
            this.listarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listarUsuáriosToolStripMenuItem.Text = "&Listar Usuários";
            this.listarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.listarUsuáriosToolStripMenuItem_Click);
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            this.cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            this.cadastroDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cadastroDeUsuáriosToolStripMenuItem.Text = "&Cadastro de Usuários";
            this.cadastroDeUsuáriosToolStripMenuItem.ToolTipText = "C";
            this.cadastroDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.RegisterUserToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeProdutosToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem1});
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            // 
            // listaDeProdutosToolStripMenuItem
            // 
            this.listaDeProdutosToolStripMenuItem.Name = "listaDeProdutosToolStripMenuItem";
            this.listaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.listaDeProdutosToolStripMenuItem.Text = "Listar Produtos";
            this.listaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.ListProductsToolStripMenuItem_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem1
            // 
            this.cadastroDeProdutosToolStripMenuItem1.Name = "cadastroDeProdutosToolStripMenuItem1";
            this.cadastroDeProdutosToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeProdutosToolStripMenuItem1.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem1.Click += new System.EventHandler(this.RegisterProductsToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lsitarPedidosToolStripMenuItem,
            this.cadastroDePedidosToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.vendasToolStripMenuItem.Text = "Pedidos";
            // 
            // lsitarPedidosToolStripMenuItem
            // 
            this.lsitarPedidosToolStripMenuItem.Name = "lsitarPedidosToolStripMenuItem";
            this.lsitarPedidosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.lsitarPedidosToolStripMenuItem.Text = "&Listar Pedidos";
            this.lsitarPedidosToolStripMenuItem.Click += new System.EventHandler(this.ListOrdersToolStripMenuItem_Click);
            // 
            // cadastroDePedidosToolStripMenuItem
            // 
            this.cadastroDePedidosToolStripMenuItem.Name = "cadastroDePedidosToolStripMenuItem";
            this.cadastroDePedidosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cadastroDePedidosToolStripMenuItem.Text = "&Realizar Pedidos";
            this.cadastroDePedidosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePedidosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.Text = "Savio\'s Vendas";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelFormSelected;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lsitarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}