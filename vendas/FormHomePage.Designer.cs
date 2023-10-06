
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
            this.headerMenu = new System.Windows.Forms.Panel();
            this.btnRegisterOrders = new DevExpress.XtraEditors.SimpleButton();
            this.btnOrdersMenu = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegisterProductMenu = new DevExpress.XtraEditors.SimpleButton();
            this.btnProductMenu = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegisterUsersMenu = new DevExpress.XtraEditors.SimpleButton();
            this.btnUsersMenu = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnHome = new DevExpress.XtraEditors.SimpleButton();
            this.menu = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.ola = new System.Windows.Forms.Label();
            this.pictureBoxPerfile = new System.Windows.Forms.PictureBox();
            this.panelFormSelected = new System.Windows.Forms.Panel();
            this.headerMenu.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfile)).BeginInit();
            this.SuspendLayout();
            // 
            // headerMenu
            // 
            this.headerMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.headerMenu.Controls.Add(this.btnRegisterOrders);
            this.headerMenu.Controls.Add(this.btnOrdersMenu);
            this.headerMenu.Controls.Add(this.btnRegisterProductMenu);
            this.headerMenu.Controls.Add(this.btnProductMenu);
            this.headerMenu.Controls.Add(this.btnRegisterUsersMenu);
            this.headerMenu.Controls.Add(this.btnUsersMenu);
            this.headerMenu.Controls.Add(this.btnExit);
            this.headerMenu.Controls.Add(this.btnHome);
            this.headerMenu.Controls.Add(this.menu);
            this.headerMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerMenu.Location = new System.Drawing.Point(0, 0);
            this.headerMenu.Name = "headerMenu";
            this.headerMenu.Size = new System.Drawing.Size(185, 588);
            this.headerMenu.TabIndex = 0;
            // 
            // btnRegisterOrders
            // 
            this.btnRegisterOrders.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegisterOrders.Appearance.Options.UseBackColor = true;
            this.btnRegisterOrders.Appearance.Options.UseTextOptions = true;
            this.btnRegisterOrders.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnRegisterOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterOrders.Location = new System.Drawing.Point(0, 238);
            this.btnRegisterOrders.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegisterOrders.Name = "btnRegisterOrders";
            this.btnRegisterOrders.Padding = new System.Windows.Forms.Padding(5);
            this.btnRegisterOrders.Size = new System.Drawing.Size(185, 31);
            this.btnRegisterOrders.TabIndex = 9;
            this.btnRegisterOrders.Text = "Realizar Pedidos";
            this.btnRegisterOrders.Click += new System.EventHandler(this.btnRegisterPurchases_Click);
            // 
            // btnOrdersMenu
            // 
            this.btnOrdersMenu.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOrdersMenu.Appearance.Options.UseBackColor = true;
            this.btnOrdersMenu.Appearance.Options.UseTextOptions = true;
            this.btnOrdersMenu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnOrdersMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdersMenu.Location = new System.Drawing.Point(0, 207);
            this.btnOrdersMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrdersMenu.Name = "btnOrdersMenu";
            this.btnOrdersMenu.Padding = new System.Windows.Forms.Padding(5);
            this.btnOrdersMenu.Size = new System.Drawing.Size(185, 31);
            this.btnOrdersMenu.TabIndex = 8;
            this.btnOrdersMenu.Text = "Pedidos";
            this.btnOrdersMenu.Click += new System.EventHandler(this.btnPurchasesSalesMenu_Click);
            // 
            // btnRegisterProductMenu
            // 
            this.btnRegisterProductMenu.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegisterProductMenu.Appearance.Options.UseBackColor = true;
            this.btnRegisterProductMenu.Appearance.Options.UseTextOptions = true;
            this.btnRegisterProductMenu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnRegisterProductMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterProductMenu.Location = new System.Drawing.Point(0, 176);
            this.btnRegisterProductMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegisterProductMenu.Name = "btnRegisterProductMenu";
            this.btnRegisterProductMenu.Padding = new System.Windows.Forms.Padding(5);
            this.btnRegisterProductMenu.Size = new System.Drawing.Size(185, 31);
            this.btnRegisterProductMenu.TabIndex = 4;
            this.btnRegisterProductMenu.Text = "Cadastro de Produtos";
            this.btnRegisterProductMenu.Click += new System.EventHandler(this.btnRegisterProductMenu_Click);
            // 
            // btnProductMenu
            // 
            this.btnProductMenu.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnProductMenu.Appearance.Options.UseBackColor = true;
            this.btnProductMenu.Appearance.Options.UseTextOptions = true;
            this.btnProductMenu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnProductMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductMenu.Location = new System.Drawing.Point(0, 145);
            this.btnProductMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductMenu.Name = "btnProductMenu";
            this.btnProductMenu.Padding = new System.Windows.Forms.Padding(5);
            this.btnProductMenu.Size = new System.Drawing.Size(185, 31);
            this.btnProductMenu.TabIndex = 3;
            this.btnProductMenu.Text = "Produtos";
            this.btnProductMenu.Click += new System.EventHandler(this.btnProductMenu_Click);
            // 
            // btnRegisterUsersMenu
            // 
            this.btnRegisterUsersMenu.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegisterUsersMenu.Appearance.Options.UseBackColor = true;
            this.btnRegisterUsersMenu.Appearance.Options.UseTextOptions = true;
            this.btnRegisterUsersMenu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnRegisterUsersMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterUsersMenu.Location = new System.Drawing.Point(0, 114);
            this.btnRegisterUsersMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegisterUsersMenu.Name = "btnRegisterUsersMenu";
            this.btnRegisterUsersMenu.Padding = new System.Windows.Forms.Padding(5);
            this.btnRegisterUsersMenu.Size = new System.Drawing.Size(185, 31);
            this.btnRegisterUsersMenu.TabIndex = 2;
            this.btnRegisterUsersMenu.Text = "Cadastro de Usuários";
            this.btnRegisterUsersMenu.Click += new System.EventHandler(this.bntRegisterUsersMenu_Click);
            // 
            // btnUsersMenu
            // 
            this.btnUsersMenu.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUsersMenu.Appearance.Options.UseBackColor = true;
            this.btnUsersMenu.Appearance.Options.UseTextOptions = true;
            this.btnUsersMenu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnUsersMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsersMenu.Location = new System.Drawing.Point(0, 83);
            this.btnUsersMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsersMenu.Name = "btnUsersMenu";
            this.btnUsersMenu.Padding = new System.Windows.Forms.Padding(5);
            this.btnUsersMenu.Size = new System.Drawing.Size(185, 31);
            this.btnUsersMenu.TabIndex = 1;
            this.btnUsersMenu.Text = "Usuários";
            this.btnUsersMenu.Click += new System.EventHandler(this.btnUsersMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseTextOptions = true;
            this.btnExit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Location = new System.Drawing.Point(0, 557);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5);
            this.btnExit.Size = new System.Drawing.Size(185, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Sair";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.Appearance.Options.UseBackColor = true;
            this.btnHome.Appearance.Options.UseTextOptions = true;
            this.btnHome.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Location = new System.Drawing.Point(0, 52);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(5);
            this.btnHome.Size = new System.Drawing.Size(185, 31);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnRegisterUserMenu_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.Controls.Add(this.labelUserName);
            this.menu.Controls.Add(this.ola);
            this.menu.Controls.Add(this.pictureBoxPerfile);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(185, 52);
            this.menu.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(53, 24);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(137, 29);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "UserName";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ola
            // 
            this.ola.AutoSize = true;
            this.ola.Dock = System.Windows.Forms.DockStyle.Top;
            this.ola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ola.Location = new System.Drawing.Point(53, 0);
            this.ola.Name = "ola";
            this.ola.Size = new System.Drawing.Size(44, 24);
            this.ola.TabIndex = 1;
            this.ola.Text = "Olá,";
            // 
            // pictureBoxPerfile
            // 
            this.pictureBoxPerfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPerfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPerfile.Image")));
            this.pictureBoxPerfile.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPerfile.Name = "pictureBoxPerfile";
            this.pictureBoxPerfile.Size = new System.Drawing.Size(53, 52);
            this.pictureBoxPerfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPerfile.TabIndex = 0;
            this.pictureBoxPerfile.TabStop = false;
            // 
            // panelFormSelected
            // 
            this.panelFormSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormSelected.Location = new System.Drawing.Point(185, 0);
            this.panelFormSelected.Name = "panelFormSelected";
            this.panelFormSelected.Size = new System.Drawing.Size(881, 588);
            this.panelFormSelected.TabIndex = 1;
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 588);
            this.Controls.Add(this.panelFormSelected);
            this.Controls.Add(this.headerMenu);
            this.Name = "FormHomePage";
            this.Text = "Tela Principal";
            this.headerMenu.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerMenu;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox pictureBoxPerfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label ola;
        private DevExpress.XtraEditors.SimpleButton btnHome;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnRegisterProductMenu;
        private DevExpress.XtraEditors.SimpleButton btnProductMenu;
        private DevExpress.XtraEditors.SimpleButton btnRegisterOrders;
        private DevExpress.XtraEditors.SimpleButton btnOrdersMenu;
        private DevExpress.XtraEditors.SimpleButton btnRegisterUsersMenu;
        private DevExpress.XtraEditors.SimpleButton btnUsersMenu;
        private System.Windows.Forms.Panel panelFormSelected;
    }
}