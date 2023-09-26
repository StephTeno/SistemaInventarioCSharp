namespace ProyectoContabilidadDeCosto
{
    partial class frmPrincipalMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalMenu));
            plMenu = new Panel();
            btnMSalir = new Button();
            btnMInventario = new Button();
            btnMSalida = new Button();
            btnMProductos = new Button();
            btnMEntrada = new Button();
            pictureBox1 = new PictureBox();
            btnEntrada = new Button();
            btnSalida = new Button();
            btnProductos = new Button();
            btnInventario = new Button();
            plMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // plMenu
            // 
            plMenu.BackColor = Color.FromArgb(22, 43, 73);
            plMenu.Controls.Add(btnMSalir);
            plMenu.Controls.Add(btnMInventario);
            plMenu.Controls.Add(btnMSalida);
            plMenu.Controls.Add(btnMProductos);
            plMenu.Controls.Add(btnMEntrada);
            plMenu.Controls.Add(pictureBox1);
            plMenu.Location = new Point(0, 0);
            plMenu.Margin = new Padding(3, 4, 3, 4);
            plMenu.Name = "plMenu";
            plMenu.Size = new Size(221, 733);
            plMenu.TabIndex = 0;
            // 
            // btnMSalir
            // 
            btnMSalir.FlatAppearance.BorderSize = 0;
            btnMSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnMSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnMSalir.FlatStyle = FlatStyle.Flat;
            btnMSalir.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMSalir.ForeColor = Color.White;
            btnMSalir.Image = VISTA.Properties.Resources.Salir;
            btnMSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnMSalir.Location = new Point(-1, 586);
            btnMSalir.Margin = new Padding(3, 4, 3, 4);
            btnMSalir.Name = "btnMSalir";
            btnMSalir.Size = new Size(219, 76);
            btnMSalir.TabIndex = 5;
            btnMSalir.Text = "Salir";
            btnMSalir.UseVisualStyleBackColor = true;
            btnMSalir.Click += btnMSalir_Click;
            // 
            // btnMInventario
            // 
            btnMInventario.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMInventario.FlatAppearance.BorderSize = 0;
            btnMInventario.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnMInventario.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnMInventario.FlatStyle = FlatStyle.Flat;
            btnMInventario.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMInventario.ForeColor = Color.White;
            btnMInventario.Image = VISTA.Properties.Resources.Almacenados;
            btnMInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnMInventario.Location = new Point(1, 479);
            btnMInventario.Margin = new Padding(3, 4, 3, 4);
            btnMInventario.Name = "btnMInventario";
            btnMInventario.Size = new Size(219, 76);
            btnMInventario.TabIndex = 5;
            btnMInventario.Text = "Inventario";
            btnMInventario.UseVisualStyleBackColor = true;
            // 
            // btnMSalida
            // 
            btnMSalida.FlatAppearance.BorderSize = 0;
            btnMSalida.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnMSalida.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnMSalida.FlatStyle = FlatStyle.Flat;
            btnMSalida.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMSalida.ForeColor = Color.White;
            btnMSalida.Image = VISTA.Properties.Resources.Subir;
            btnMSalida.ImageAlign = ContentAlignment.MiddleLeft;
            btnMSalida.Location = new Point(1, 319);
            btnMSalida.Margin = new Padding(3, 4, 3, 4);
            btnMSalida.Name = "btnMSalida";
            btnMSalida.Size = new Size(219, 76);
            btnMSalida.TabIndex = 5;
            btnMSalida.Text = "Salida";
            btnMSalida.UseVisualStyleBackColor = true;
            // 
            // btnMProductos
            // 
            btnMProductos.FlatAppearance.BorderSize = 0;
            btnMProductos.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnMProductos.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnMProductos.FlatStyle = FlatStyle.Flat;
            btnMProductos.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMProductos.ForeColor = Color.White;
            btnMProductos.Image = VISTA.Properties.Resources.Productos;
            btnMProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMProductos.Location = new Point(1, 400);
            btnMProductos.Margin = new Padding(3, 4, 3, 4);
            btnMProductos.Name = "btnMProductos";
            btnMProductos.Size = new Size(219, 76);
            btnMProductos.TabIndex = 5;
            btnMProductos.Text = "Productos";
            btnMProductos.UseVisualStyleBackColor = true;
            // 
            // btnMEntrada
            // 
            btnMEntrada.FlatAppearance.BorderSize = 0;
            btnMEntrada.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnMEntrada.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnMEntrada.FlatStyle = FlatStyle.Flat;
            btnMEntrada.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMEntrada.ForeColor = Color.White;
            btnMEntrada.Image = VISTA.Properties.Resources.Descargar;
            btnMEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnMEntrada.Location = new Point(1, 240);
            btnMEntrada.Margin = new Padding(3, 4, 3, 4);
            btnMEntrada.Name = "btnMEntrada";
            btnMEntrada.Size = new Size(219, 76);
            btnMEntrada.TabIndex = 5;
            btnMEntrada.Text = "Entrada";
            btnMEntrada.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = VISTA.Properties.Resources.Logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnEntrada
            // 
            btnEntrada.FlatAppearance.BorderSize = 2;
            btnEntrada.FlatStyle = FlatStyle.Flat;
            btnEntrada.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrada.ForeColor = Color.White;
            btnEntrada.Image = VISTA.Properties.Resources.Descargar;
            btnEntrada.Location = new Point(324, 400);
            btnEntrada.Margin = new Padding(3, 4, 3, 4);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(155, 107);
            btnEntrada.TabIndex = 1;
            btnEntrada.Text = "ENTRADA";
            btnEntrada.TextAlign = ContentAlignment.BottomCenter;
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSalida
            // 
            btnSalida.FlatAppearance.BorderSize = 2;
            btnSalida.FlatStyle = FlatStyle.Flat;
            btnSalida.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalida.ForeColor = Color.White;
            btnSalida.Image = VISTA.Properties.Resources.Subir;
            btnSalida.Location = new Point(504, 400);
            btnSalida.Margin = new Padding(3, 4, 3, 4);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(155, 107);
            btnSalida.TabIndex = 2;
            btnSalida.Text = "SALIDA";
            btnSalida.TextAlign = ContentAlignment.BottomCenter;
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 2;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = VISTA.Properties.Resources.Productos;
            btnProductos.Location = new Point(685, 400);
            btnProductos.Margin = new Padding(3, 4, 3, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(155, 107);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.TextAlign = ContentAlignment.BottomCenter;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnInventario
            // 
            btnInventario.FlatAppearance.BorderSize = 2;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventario.ForeColor = Color.White;
            btnInventario.Image = VISTA.Properties.Resources.Almacenados;
            btnInventario.Location = new Point(864, 400);
            btnInventario.Margin = new Padding(3, 4, 3, 4);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(155, 107);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "INVENTARIO";
            btnInventario.TextAlign = ContentAlignment.BottomCenter;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // frmPrincipalMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1083, 665);
            Controls.Add(plMenu);
            Controls.Add(btnInventario);
            Controls.Add(btnEntrada);
            Controls.Add(btnProductos);
            Controls.Add(btnSalida);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipalMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += frmPrincipalMenu_Load;
            plMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plMenu;
        private Button btnEntrada;
        private Button btnSalida;
        private Button btnProductos;
        private Button btnInventario;
        private PictureBox pictureBox1;
        private Button btnMEntrada;
        private Button btnMInventario;
        private Button btnMSalida;
        private Button btnMProductos;
        private Button btnMSalir;
    }
}