namespace Vista.Vistas.Hijos
{
    partial class frmAccountAdmin
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
            plTitle = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            plOptions = new Panel();
            btnProveedores = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnAllUser = new FontAwesome.Sharp.IconButton();
            plContenedor = new Panel();
            plTitle.SuspendLayout();
            panel1.SuspendLayout();
            plOptions.SuspendLayout();
            SuspendLayout();
            // 
            // plTitle
            // 
            plTitle.Controls.Add(panel1);
            plTitle.Dock = DockStyle.Top;
            plTitle.Location = new Point(0, 0);
            plTitle.Name = "plTitle";
            plTitle.Size = new Size(1000, 57);
            plTitle.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 57);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(226, 33);
            label1.TabIndex = 0;
            label1.Text = "Administradores";
            // 
            // plOptions
            // 
            plOptions.Controls.Add(btnProveedores);
            plOptions.Controls.Add(btnClientes);
            plOptions.Controls.Add(btnAllUser);
            plOptions.Dock = DockStyle.Top;
            plOptions.Location = new Point(0, 57);
            plOptions.Name = "plOptions";
            plOptions.Size = new Size(1000, 57);
            plOptions.TabIndex = 1;
            // 
            // btnProveedores
            // 
            btnProveedores.Dock = DockStyle.Left;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.DimGray;
            btnProveedores.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            btnProveedores.IconColor = Color.DimGray;
            btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnProveedores.IconSize = 25;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(300, 0);
            btnProveedores.Margin = new Padding(5, 6, 5, 6);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(5, 0, 15, 0);
            btnProveedores.Size = new Size(150, 57);
            btnProveedores.TabIndex = 6;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleRight;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Left;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.DimGray;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnClientes.IconColor = Color.DimGray;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnClientes.IconSize = 25;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(150, 0);
            btnClientes.Margin = new Padding(5, 6, 5, 6);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(5, 0, 35, 0);
            btnClientes.Size = new Size(150, 57);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnAllUser
            // 
            btnAllUser.Dock = DockStyle.Left;
            btnAllUser.FlatAppearance.BorderSize = 0;
            btnAllUser.FlatStyle = FlatStyle.Flat;
            btnAllUser.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllUser.ForeColor = Color.DimGray;
            btnAllUser.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnAllUser.IconColor = Color.DimGray;
            btnAllUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAllUser.IconSize = 25;
            btnAllUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAllUser.Location = new Point(0, 0);
            btnAllUser.Margin = new Padding(5, 6, 5, 6);
            btnAllUser.Name = "btnAllUser";
            btnAllUser.Padding = new Padding(5, 0, 10, 0);
            btnAllUser.Size = new Size(150, 57);
            btnAllUser.TabIndex = 0;
            btnAllUser.Text = "Usuarios Admin";
            btnAllUser.TextAlign = ContentAlignment.MiddleRight;
            btnAllUser.UseVisualStyleBackColor = true;
            btnAllUser.Click += btnAllUser_Click;
            // 
            // plContenedor
            // 
            plContenedor.Dock = DockStyle.Fill;
            plContenedor.Location = new Point(0, 114);
            plContenedor.Name = "plContenedor";
            plContenedor.Size = new Size(1000, 510);
            plContenedor.TabIndex = 2;
            // 
            // frmAccountAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 624);
            Controls.Add(plContenedor);
            Controls.Add(plOptions);
            Controls.Add(plTitle);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAccountAdmin";
            Text = "frmAccountAdmin";
            plTitle.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            plOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel plTitle;
        private Panel plOptions;
        private FontAwesome.Sharp.IconButton btnAllUser;
        private Panel panel1;
        private Label label1;
        private Panel plContenedor;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnProveedores;
    }
}