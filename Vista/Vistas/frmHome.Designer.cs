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
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnProfile = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnMinus = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            flpSidebar = new FlowLayoutPanel();
            Separador1 = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            btnUser = new FontAwesome.Sharp.IconButton();
            btnShop = new FontAwesome.Sharp.IconButton();
            btnReport = new FontAwesome.Sharp.IconButton();
            Separador2 = new FontAwesome.Sharp.IconButton();
            btnManageAdmin = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnCloseSesion = new FontAwesome.Sharp.IconButton();
            plContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            flpSidebar.SuspendLayout();
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
            btnHome.IconSize = 35;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(15, 0, 10, 0);
            btnHome.Size = new Size(200, 50);
            btnHome.TabIndex = 22;
            btnHome.Text = "Mercadito Cultural";
            btnHome.TextAlign = ContentAlignment.MiddleRight;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += iconButton1_Click;
            // 
            // flpSidebar
            // 
            flpSidebar.BackColor = Color.FromArgb(235, 239, 241);
            flpSidebar.Controls.Add(Separador1);
            flpSidebar.Controls.Add(btnInicio);
            flpSidebar.Controls.Add(btnUser);
            flpSidebar.Controls.Add(btnShop);
            flpSidebar.Controls.Add(btnReport);
            flpSidebar.Controls.Add(Separador2);
            flpSidebar.Controls.Add(btnManageAdmin);
            flpSidebar.Controls.Add(iconButton1);
            flpSidebar.Controls.Add(btnCloseSesion);
            flpSidebar.Dock = DockStyle.Left;
            flpSidebar.Location = new Point(0, 50);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(200, 600);
            flpSidebar.TabIndex = 1;
            // 
            // Separador1
            // 
            Separador1.BackColor = Color.FromArgb(235, 239, 241);
            Separador1.Dock = DockStyle.Top;
            Separador1.Enabled = false;
            Separador1.FlatAppearance.BorderSize = 0;
            Separador1.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            Separador1.FlatStyle = FlatStyle.Flat;
            Separador1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Separador1.ForeColor = Color.Silver;
            Separador1.IconChar = FontAwesome.Sharp.IconChar.None;
            Separador1.IconColor = Color.Gray;
            Separador1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            Separador1.IconSize = 30;
            Separador1.ImageAlign = ContentAlignment.MiddleLeft;
            Separador1.Location = new Point(0, 0);
            Separador1.Margin = new Padding(0, 0, 0, 10);
            Separador1.Name = "Separador1";
            Separador1.Size = new Size(200, 50);
            Separador1.TabIndex = 8;
            Separador1.Text = "REGISTROS";
            Separador1.TextAlign = ContentAlignment.BottomLeft;
            Separador1.UseVisualStyleBackColor = false;
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
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(235, 239, 241);
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = Color.Gray;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUser.IconColor = Color.Gray;
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnUser.IconSize = 25;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 120);
            btnUser.Margin = new Padding(0, 0, 0, 10);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(15, 0, 60, 0);
            btnUser.Size = new Size(200, 50);
            btnUser.TabIndex = 3;
            btnUser.Text = "Usuario";
            btnUser.TextAlign = ContentAlignment.MiddleRight;
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnShop
            // 
            btnShop.BackColor = Color.FromArgb(235, 239, 241);
            btnShop.Dock = DockStyle.Top;
            btnShop.FlatAppearance.BorderSize = 0;
            btnShop.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnShop.FlatStyle = FlatStyle.Flat;
            btnShop.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnShop.ForeColor = Color.Gray;
            btnShop.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnShop.IconColor = Color.Gray;
            btnShop.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnShop.IconSize = 25;
            btnShop.ImageAlign = ContentAlignment.MiddleLeft;
            btnShop.Location = new Point(0, 180);
            btnShop.Margin = new Padding(0, 0, 0, 10);
            btnShop.Name = "btnShop";
            btnShop.Padding = new Padding(15, 0, 60, 0);
            btnShop.Size = new Size(200, 50);
            btnShop.TabIndex = 4;
            btnShop.Text = "Tiendas";
            btnShop.TextAlign = ContentAlignment.MiddleRight;
            btnShop.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(235, 239, 241);
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.Gray;
            btnReport.IconChar = FontAwesome.Sharp.IconChar.Bell;
            btnReport.IconColor = Color.Gray;
            btnReport.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnReport.IconSize = 25;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 240);
            btnReport.Margin = new Padding(0, 0, 0, 10);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(15, 0, 60, 0);
            btnReport.Size = new Size(200, 50);
            btnReport.TabIndex = 5;
            btnReport.Text = "Reportes";
            btnReport.TextAlign = ContentAlignment.MiddleRight;
            btnReport.UseVisualStyleBackColor = false;
            // 
            // Separador2
            // 
            Separador2.BackColor = Color.FromArgb(235, 239, 241);
            Separador2.Dock = DockStyle.Top;
            Separador2.Enabled = false;
            Separador2.FlatAppearance.BorderSize = 0;
            Separador2.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            Separador2.FlatStyle = FlatStyle.Flat;
            Separador2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Separador2.ForeColor = Color.Silver;
            Separador2.IconChar = FontAwesome.Sharp.IconChar.None;
            Separador2.IconColor = Color.Gray;
            Separador2.IconFont = FontAwesome.Sharp.IconFont.Regular;
            Separador2.IconSize = 30;
            Separador2.ImageAlign = ContentAlignment.MiddleLeft;
            Separador2.Location = new Point(0, 300);
            Separador2.Margin = new Padding(0, 0, 0, 10);
            Separador2.Name = "Separador2";
            Separador2.Size = new Size(200, 50);
            Separador2.TabIndex = 9;
            Separador2.Text = "AJUSTES";
            Separador2.TextAlign = ContentAlignment.BottomLeft;
            Separador2.UseVisualStyleBackColor = false;
            // 
            // btnManageAdmin
            // 
            btnManageAdmin.BackColor = Color.FromArgb(235, 239, 241);
            btnManageAdmin.Dock = DockStyle.Top;
            btnManageAdmin.FlatAppearance.BorderSize = 0;
            btnManageAdmin.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnManageAdmin.FlatStyle = FlatStyle.Flat;
            btnManageAdmin.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnManageAdmin.ForeColor = Color.Gray;
            btnManageAdmin.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnManageAdmin.IconColor = Color.Gray;
            btnManageAdmin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnManageAdmin.IconSize = 25;
            btnManageAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageAdmin.Location = new Point(0, 360);
            btnManageAdmin.Margin = new Padding(0, 0, 0, 10);
            btnManageAdmin.Name = "btnManageAdmin";
            btnManageAdmin.Padding = new Padding(15, 0, 20, 0);
            btnManageAdmin.Size = new Size(200, 50);
            btnManageAdmin.TabIndex = 6;
            btnManageAdmin.Text = "Administración";
            btnManageAdmin.TextAlign = ContentAlignment.MiddleRight;
            btnManageAdmin.UseVisualStyleBackColor = false;
            btnManageAdmin.Click += btnManageAdmin_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(235, 239, 241);
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.Gray;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconButton1.IconColor = Color.Gray;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 25;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 420);
            iconButton1.Margin = new Padding(0, 0, 0, 10);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(15, 0, 20, 0);
            iconButton1.Size = new Size(200, 50);
            iconButton1.TabIndex = 10;
            iconButton1.Text = "Administración";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnCloseSesion
            // 
            btnCloseSesion.BackColor = Color.FromArgb(235, 239, 241);
            btnCloseSesion.FlatAppearance.BorderSize = 0;
            btnCloseSesion.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnCloseSesion.FlatStyle = FlatStyle.Flat;
            btnCloseSesion.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseSesion.ForeColor = Color.Gray;
            btnCloseSesion.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnCloseSesion.IconColor = Color.Gray;
            btnCloseSesion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCloseSesion.IconSize = 25;
            btnCloseSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseSesion.Location = new Point(0, 480);
            btnCloseSesion.Margin = new Padding(0, 0, 0, 10);
            btnCloseSesion.Name = "btnCloseSesion";
            btnCloseSesion.Padding = new Padding(15, 0, 35, 0);
            btnCloseSesion.Size = new Size(200, 50);
            btnCloseSesion.TabIndex = 7;
            btnCloseSesion.Text = "Cerrar Sesión";
            btnCloseSesion.TextAlign = ContentAlignment.MiddleRight;
            btnCloseSesion.UseVisualStyleBackColor = false;
            btnCloseSesion.Click += btnCloseSesion_Click;
            // 
            // plContenedor
            // 
            plContenedor.Dock = DockStyle.Fill;
            plContenedor.Location = new Point(200, 50);
            plContenedor.Name = "plContenedor";
            plContenedor.Size = new Size(800, 600);
            plContenedor.TabIndex = 2;
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
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHome";
            Load += frmHome_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            flpSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FlowLayoutPanel flpSidebar;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnShop;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnManageAdmin;
        private FontAwesome.Sharp.IconButton btnCloseSesion;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton Separador1;
        private FontAwesome.Sharp.IconButton Separador2;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinus;
        private FontAwesome.Sharp.IconButton btnProfile;
        private Panel plContenedor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}