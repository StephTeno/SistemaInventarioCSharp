namespace Vista.HOME
{
    partial class frmHome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnProfile = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMinus = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            flpSidebar = new FlowLayoutPanel();
            SeparadorPrincipal = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            btnCatalogue = new FontAwesome.Sharp.IconButton();
            btnInvoice = new FontAwesome.Sharp.IconButton();
            btnInventory = new FontAwesome.Sharp.IconButton();
            plContenedor = new Panel();
            ddmInventory = new CustomControls.RJControls.RJDropdownMenu(components);
            entradasToolStripMenuItem = new ToolStripMenuItem();
            salidasToolStripMenuItem = new ToolStripMenuItem();
            ddmProfile = new CustomControls.RJControls.RJDropdownMenu(components);
            ItemProfile = new ToolStripMenuItem();
            ItemConfiguration = new ToolStripMenuItem();
            ItemHelp = new ToolStripMenuItem();
            ItemLogOut = new ToolStripMenuItem();
            ItemExit = new ToolStripMenuItem();
            SeparadorAjustes = new FontAwesome.Sharp.IconButton();
            btnAdmin = new FontAwesome.Sharp.IconButton();
            btnHistorial = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            flpSidebar.SuspendLayout();
            ddmInventory.SuspendLayout();
            ddmProfile.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 86, 160);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnMinus);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 50);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.FromArgb(40, 86, 160);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(692, 8);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 26;
            iconPictureBox1.TabStop = false;
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.Right;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.White;
            btnProfile.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            btnProfile.IconColor = Color.White;
            btnProfile.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnProfile.IconSize = 15;
            btnProfile.ImageAlign = ContentAlignment.MiddleRight;
            btnProfile.Location = new Point(750, 10);
            btnProfile.Margin = new Padding(3, 3, 30, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(5, 0, 10, 0);
            btnProfile.Size = new Size(140, 30);
            btnProfile.TabIndex = 25;
            btnProfile.Text = "Administrador";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            btnProfile.MouseEnter += btnProfile_MouseEnter;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.White;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 25;
            btnExit.Location = new Point(968, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 24;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // btnMinus
            // 
            btnMinus.Anchor = AnchorStyles.Right;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMinus.IconColor = Color.White;
            btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinus.IconSize = 25;
            btnMinus.Location = new Point(927, 2);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(30, 30);
            btnMinus.TabIndex = 23;
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            btnMinus.MouseEnter += btnMinus_MouseEnter;
            btnMinus.MouseLeave += btnMinus_MouseLeave;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Left;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnHome.IconColor = Color.White;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnHome.IconSize = 30;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(5, 0, 5, 0);
            btnHome.Size = new Size(200, 50);
            btnHome.TabIndex = 22;
            btnHome.Text = "Gestión de Inventario";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += iconButton1_Click;
            // 
            // flpSidebar
            // 
            flpSidebar.BackColor = Color.FromArgb(235, 239, 241);
            flpSidebar.Controls.Add(SeparadorPrincipal);
            flpSidebar.Controls.Add(btnInicio);
            flpSidebar.Controls.Add(btnCatalogue);
            flpSidebar.Controls.Add(btnInvoice);
            flpSidebar.Controls.Add(btnInventory);
            flpSidebar.Controls.Add(SeparadorAjustes);
            flpSidebar.Controls.Add(btnAdmin);
            flpSidebar.Controls.Add(btnHistorial);
            flpSidebar.Dock = DockStyle.Left;
            flpSidebar.Location = new Point(0, 50);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(200, 600);
            flpSidebar.TabIndex = 1;
            // 
            // SeparadorPrincipal
            // 
            SeparadorPrincipal.BackColor = Color.FromArgb(235, 239, 241);
            SeparadorPrincipal.Dock = DockStyle.Top;
            SeparadorPrincipal.Enabled = false;
            SeparadorPrincipal.FlatAppearance.BorderSize = 0;
            SeparadorPrincipal.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            SeparadorPrincipal.FlatStyle = FlatStyle.Flat;
            SeparadorPrincipal.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SeparadorPrincipal.ForeColor = Color.Silver;
            SeparadorPrincipal.IconChar = FontAwesome.Sharp.IconChar.None;
            SeparadorPrincipal.IconColor = Color.Gray;
            SeparadorPrincipal.IconFont = FontAwesome.Sharp.IconFont.Regular;
            SeparadorPrincipal.IconSize = 30;
            SeparadorPrincipal.ImageAlign = ContentAlignment.MiddleLeft;
            SeparadorPrincipal.Location = new Point(0, 0);
            SeparadorPrincipal.Margin = new Padding(0, 0, 0, 10);
            SeparadorPrincipal.Name = "SeparadorPrincipal";
            SeparadorPrincipal.Size = new Size(200, 50);
            SeparadorPrincipal.TabIndex = 8;
            SeparadorPrincipal.Text = "PRINCIPAL";
            SeparadorPrincipal.TextAlign = ContentAlignment.BottomLeft;
            SeparadorPrincipal.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(235, 239, 241);
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.Gray;
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnInicio.IconColor = Color.Gray;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnInicio.IconSize = 25;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 60);
            btnInicio.Margin = new Padding(0, 0, 0, 10);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(15, 0, 70, 0);
            btnInicio.Size = new Size(200, 50);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleRight;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnCatalogue
            // 
            btnCatalogue.BackColor = Color.FromArgb(235, 239, 241);
            btnCatalogue.Dock = DockStyle.Top;
            btnCatalogue.FlatAppearance.BorderSize = 0;
            btnCatalogue.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnCatalogue.FlatStyle = FlatStyle.Flat;
            btnCatalogue.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatalogue.ForeColor = Color.Gray;
            btnCatalogue.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            btnCatalogue.IconColor = Color.Gray;
            btnCatalogue.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCatalogue.IconSize = 25;
            btnCatalogue.ImageAlign = ContentAlignment.MiddleLeft;
            btnCatalogue.Location = new Point(0, 120);
            btnCatalogue.Margin = new Padding(0, 0, 0, 10);
            btnCatalogue.Name = "btnCatalogue";
            btnCatalogue.Padding = new Padding(15, 0, 60, 0);
            btnCatalogue.Size = new Size(200, 50);
            btnCatalogue.TabIndex = 3;
            btnCatalogue.Text = "Catálogo";
            btnCatalogue.TextAlign = ContentAlignment.MiddleRight;
            btnCatalogue.UseVisualStyleBackColor = false;
            // 
            // btnInvoice
            // 
            btnInvoice.BackColor = Color.FromArgb(235, 239, 241);
            btnInvoice.Dock = DockStyle.Top;
            btnInvoice.FlatAppearance.BorderSize = 0;
            btnInvoice.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnInvoice.FlatStyle = FlatStyle.Flat;
            btnInvoice.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInvoice.ForeColor = Color.Gray;
            btnInvoice.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnInvoice.IconColor = Color.Gray;
            btnInvoice.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnInvoice.IconSize = 25;
            btnInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            btnInvoice.Location = new Point(0, 180);
            btnInvoice.Margin = new Padding(0, 0, 0, 10);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Padding = new Padding(15, 0, 60, 0);
            btnInvoice.Size = new Size(200, 50);
            btnInvoice.TabIndex = 4;
            btnInvoice.Text = "Facturar";
            btnInvoice.TextAlign = ContentAlignment.MiddleRight;
            btnInvoice.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(235, 239, 241);
            btnInventory.Dock = DockStyle.Top;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventory.ForeColor = Color.Gray;
            btnInventory.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnInventory.IconColor = Color.Gray;
            btnInventory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnInventory.IconSize = 25;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 240);
            btnInventory.Margin = new Padding(0, 0, 0, 10);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(15, 0, 48, 0);
            btnInventory.Size = new Size(200, 50);
            btnInventory.TabIndex = 5;
            btnInventory.Text = "Inventario";
            btnInventory.TextAlign = ContentAlignment.MiddleRight;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // plContenedor
            // 
            plContenedor.BackColor = Color.White;
            plContenedor.Dock = DockStyle.Fill;
            plContenedor.Location = new Point(200, 50);
            plContenedor.Name = "plContenedor";
            plContenedor.Size = new Size(800, 600);
            plContenedor.TabIndex = 2;
            // 
            // ddmInventory
            // 
            ddmInventory.IsMainMenu = false;
            ddmInventory.Items.AddRange(new ToolStripItem[] { entradasToolStripMenuItem, salidasToolStripMenuItem });
            ddmInventory.ItemSelection = Color.Empty;
            ddmInventory.LeftColumnColor = Color.Empty;
            ddmInventory.MenuItemHeight = 25;
            ddmInventory.MenuItemSelectTextColor = Color.Empty;
            ddmInventory.MenuItemTextColor = Color.Empty;
            ddmInventory.Name = "ddmInventory";
            ddmInventory.PrimaryColor = Color.Empty;
            ddmInventory.Size = new Size(120, 48);
            // 
            // entradasToolStripMenuItem
            // 
            entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            entradasToolStripMenuItem.Size = new Size(119, 22);
            entradasToolStripMenuItem.Text = "Entradas";
            // 
            // salidasToolStripMenuItem
            // 
            salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            salidasToolStripMenuItem.Size = new Size(119, 22);
            salidasToolStripMenuItem.Text = "Salidas";
            // 
            // ddmProfile
            // 
            ddmProfile.BackColor = Color.RoyalBlue;
            ddmProfile.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ddmProfile.IsMainMenu = false;
            ddmProfile.Items.AddRange(new ToolStripItem[] { ItemProfile, ItemConfiguration, ItemHelp, ItemLogOut, ItemExit });
            ddmProfile.ItemSelection = Color.White;
            ddmProfile.LeftColumnColor = Color.RoyalBlue;
            ddmProfile.MenuItemHeight = 25;
            ddmProfile.MenuItemSelectTextColor = Color.RoyalBlue;
            ddmProfile.MenuItemTextColor = Color.White;
            ddmProfile.Name = "ddmProfile";
            ddmProfile.PrimaryColor = Color.RoyalBlue;
            ddmProfile.Size = new Size(161, 114);
            // 
            // ItemProfile
            // 
            ItemProfile.ForeColor = Color.White;
            ItemProfile.Image = Properties.Resources.User;
            ItemProfile.Name = "ItemProfile";
            ItemProfile.Size = new Size(160, 22);
            ItemProfile.Text = "Mi Perfil";
            ItemProfile.Click += editarToolStripMenuItem_Click;
            // 
            // ItemConfiguration
            // 
            ItemConfiguration.ForeColor = Color.White;
            ItemConfiguration.Name = "ItemConfiguration";
            ItemConfiguration.Size = new Size(160, 22);
            ItemConfiguration.Text = "Configuración";
            // 
            // ItemHelp
            // 
            ItemHelp.ForeColor = Color.White;
            ItemHelp.Name = "ItemHelp";
            ItemHelp.Size = new Size(160, 22);
            ItemHelp.Text = "Ayuda";
            // 
            // ItemLogOut
            // 
            ItemLogOut.ForeColor = Color.White;
            ItemLogOut.Name = "ItemLogOut";
            ItemLogOut.Size = new Size(160, 22);
            ItemLogOut.Text = "Cerrar Sesión";
            ItemLogOut.Click += ItemLogOut_Click;
            // 
            // ItemExit
            // 
            ItemExit.ForeColor = Color.White;
            ItemExit.Name = "ItemExit";
            ItemExit.Size = new Size(160, 22);
            ItemExit.Text = "Salir";
            ItemExit.Click += ItemExit_Click;
            // 
            // SeparadorAjustes
            // 
            SeparadorAjustes.BackColor = Color.FromArgb(235, 239, 241);
            SeparadorAjustes.Dock = DockStyle.Top;
            SeparadorAjustes.Enabled = false;
            SeparadorAjustes.FlatAppearance.BorderSize = 0;
            SeparadorAjustes.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            SeparadorAjustes.FlatStyle = FlatStyle.Flat;
            SeparadorAjustes.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SeparadorAjustes.ForeColor = Color.Silver;
            SeparadorAjustes.IconChar = FontAwesome.Sharp.IconChar.None;
            SeparadorAjustes.IconColor = Color.Gray;
            SeparadorAjustes.IconFont = FontAwesome.Sharp.IconFont.Regular;
            SeparadorAjustes.IconSize = 30;
            SeparadorAjustes.ImageAlign = ContentAlignment.MiddleLeft;
            SeparadorAjustes.Location = new Point(0, 300);
            SeparadorAjustes.Margin = new Padding(0, 0, 0, 10);
            SeparadorAjustes.Name = "SeparadorAjustes";
            SeparadorAjustes.Size = new Size(200, 50);
            SeparadorAjustes.TabIndex = 9;
            SeparadorAjustes.Text = "AJUSTES";
            SeparadorAjustes.TextAlign = ContentAlignment.BottomLeft;
            SeparadorAjustes.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(235, 239, 241);
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.Gray;
            btnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnAdmin.IconColor = Color.Gray;
            btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAdmin.IconSize = 25;
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 360);
            btnAdmin.Margin = new Padding(0, 0, 0, 10);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new Padding(15, 0, 30, 0);
            btnAdmin.Size = new Size(200, 50);
            btnAdmin.TabIndex = 10;
            btnAdmin.Text = "Administración";
            btnAdmin.TextAlign = ContentAlignment.MiddleRight;
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(235, 239, 241);
            btnHistorial.Dock = DockStyle.Top;
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.Gray;
            btnHistorial.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            btnHistorial.IconColor = Color.Gray;
            btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnHistorial.IconSize = 25;
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorial.Location = new Point(0, 420);
            btnHistorial.Margin = new Padding(0, 0, 0, 10);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Padding = new Padding(15, 0, 55, 0);
            btnHistorial.Size = new Size(200, 50);
            btnHistorial.TabIndex = 11;
            btnHistorial.Text = "Historial";
            btnHistorial.TextAlign = ContentAlignment.MiddleRight;
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 650);
            Controls.Add(plContenedor);
            Controls.Add(flpSidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHome";
            Load += frmHome_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            flpSidebar.ResumeLayout(false);
            ddmInventory.ResumeLayout(false);
            ddmProfile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FlowLayoutPanel flpSidebar;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnCatalogue;
        private FontAwesome.Sharp.IconButton btnInvoice;
        private FontAwesome.Sharp.IconButton btnInventory;
        private FontAwesome.Sharp.IconButton btnManageAdmin;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton SeparadorPrincipal;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinus;
        private FontAwesome.Sharp.IconButton btnProfile;
        private Panel plContenedor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CustomControls.RJControls.RJDropdownMenu ddmInventory;
        private ToolStripMenuItem entradasToolStripMenuItem;
        private ToolStripMenuItem salidasToolStripMenuItem;
        private CustomControls.RJControls.RJDropdownMenu ddmProfile;
        private ToolStripMenuItem ItemProfile;
        private ToolStripMenuItem ItemConfiguration;
        private ToolStripMenuItem ItemHelp;
        private ToolStripMenuItem ItemLogOut;
        private ToolStripMenuItem ItemExit;
        private FontAwesome.Sharp.IconButton SeparadorAjustes;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnHistorial;
    }
}