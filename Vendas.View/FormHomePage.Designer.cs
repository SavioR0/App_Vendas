
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
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMyProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterProductsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.MenuToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.UsersToolStripMenuItem,
            this.ProductsToolStripMenuItem1,
            this.SaleToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListUsersToolStripMenuItem,
            this.RegisterUsersToolStripMenuItem});
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.UsersToolStripMenuItem.Text = "Usuários";
            // 
            // ListUsersToolStripMenuItem
            // 
            this.ListUsersToolStripMenuItem.Name = "ListUsersToolStripMenuItem";
            this.ListUsersToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ListUsersToolStripMenuItem.Text = "&Listar Usuários";
            this.ListUsersToolStripMenuItem.Click += new System.EventHandler(this.ListUsersToolStripMenuItem_Click);
            // 
            // RegisterUsersToolStripMenuItem
            // 
            this.RegisterUsersToolStripMenuItem.Name = "RegisterUsersToolStripMenuItem";
            this.RegisterUsersToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.RegisterUsersToolStripMenuItem.Text = "&Cadastro de Usuários";
            this.RegisterUsersToolStripMenuItem.ToolTipText = "C";
            this.RegisterUsersToolStripMenuItem.Click += new System.EventHandler(this.RegisterUserToolStripMenuItem_Click);
            // 
            // ProductsToolStripMenuItem1
            // 
            this.ProductsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListMyProductsToolStripMenuItem,
            this.RegisterProductsToolStripMenuItem1});
            this.ProductsToolStripMenuItem1.Name = "ProductsToolStripMenuItem1";
            this.ProductsToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.ProductsToolStripMenuItem1.Text = "Produtos";
            // 
            // ListMyProductsToolStripMenuItem
            // 
            this.ListMyProductsToolStripMenuItem.Name = "ListMyProductsToolStripMenuItem";
            this.ListMyProductsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ListMyProductsToolStripMenuItem.Text = "Listar Produtos";
            this.ListMyProductsToolStripMenuItem.Click += new System.EventHandler(this.ListProductsToolStripMenuItem_Click);
            // 
            // RegisterProductsToolStripMenuItem1
            // 
            this.RegisterProductsToolStripMenuItem1.Name = "RegisterProductsToolStripMenuItem1";
            this.RegisterProductsToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.RegisterProductsToolStripMenuItem1.Text = "Cadastro de Produtos";
            this.RegisterProductsToolStripMenuItem1.Click += new System.EventHandler(this.RegisterProductsToolStripMenuItem1_Click);
            // 
            // SaleToolStripMenuItem
            // 
            this.SaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListSalesToolStripMenuItem,
            this.RegisterOrderToolStripMenuItem});
            this.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem";
            this.SaleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SaleToolStripMenuItem.Text = "Pedidos";
            // 
            // ListSalesToolStripMenuItem
            // 
            this.ListSalesToolStripMenuItem.Name = "ListSalesToolStripMenuItem";
            this.ListSalesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ListSalesToolStripMenuItem.Text = "&Listar Pedidos";
            this.ListSalesToolStripMenuItem.Click += new System.EventHandler(this.ListOrdersToolStripMenuItem_Click);
            // 
            // RegisterOrderToolStripMenuItem
            // 
            this.RegisterOrderToolStripMenuItem.Name = "RegisterOrderToolStripMenuItem";
            this.RegisterOrderToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.RegisterOrderToolStripMenuItem.Text = "&Realizar Pedidos";
            this.RegisterOrderToolStripMenuItem.Click += new System.EventHandler(this.RegisterOrdersToolStripMenuItem_Click);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegisterUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegisterOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListMyProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegisterProductsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}