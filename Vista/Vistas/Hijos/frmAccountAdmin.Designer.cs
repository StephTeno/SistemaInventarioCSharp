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
            btnNoti = new FontAwesome.Sharp.IconButton();
            btnUbicAlma = new FontAwesome.Sharp.IconButton();
            btnUmbStock = new FontAwesome.Sharp.IconButton();
            btnCatAndCal = new FontAwesome.Sharp.IconButton();
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
            plOptions.Controls.Add(btnNoti);
            plOptions.Controls.Add(btnUbicAlma);
            plOptions.Controls.Add(btnUmbStock);
            plOptions.Controls.Add(btnCatAndCal);
            plOptions.Controls.Add(btnAllUser);
            plOptions.Dock = DockStyle.Top;
            plOptions.Location = new Point(0, 57);
            plOptions.Name = "plOptions";
            plOptions.Size = new Size(1000, 57);
            plOptions.TabIndex = 1;
            // 
            // btnNoti
            // 
            btnNoti.Dock = DockStyle.Left;
            btnNoti.FlatAppearance.BorderSize = 0;
            btnNoti.FlatStyle = FlatStyle.Flat;
            btnNoti.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNoti.ForeColor = Color.DimGray;
            btnNoti.IconChar = FontAwesome.Sharp.IconChar.Bell;
            btnNoti.IconColor = Color.DimGray;
            btnNoti.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnNoti.IconSize = 25;
            btnNoti.ImageAlign = ContentAlignment.MiddleLeft;
            btnNoti.Location = new Point(600, 0);
            btnNoti.Margin = new Padding(5, 6, 5, 6);
            btnNoti.Name = "btnNoti";
            btnNoti.Padding = new Padding(5, 0, 15, 0);
            btnNoti.Size = new Size(150, 57);
            btnNoti.TabIndex = 4;
            btnNoti.Text = "Notificaciones";
            btnNoti.TextAlign = ContentAlignment.MiddleRight;
            btnNoti.UseVisualStyleBackColor = true;
            btnNoti.Click += btnNoti_Click;
            // 
            // btnUbicAlma
            // 
            btnUbicAlma.Dock = DockStyle.Left;
            btnUbicAlma.FlatAppearance.BorderSize = 0;
            btnUbicAlma.FlatStyle = FlatStyle.Flat;
            btnUbicAlma.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUbicAlma.ForeColor = Color.DimGray;
            btnUbicAlma.IconChar = FontAwesome.Sharp.IconChar.Bandcamp;
            btnUbicAlma.IconColor = Color.DimGray;
            btnUbicAlma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUbicAlma.IconSize = 25;
            btnUbicAlma.ImageAlign = ContentAlignment.MiddleLeft;
            btnUbicAlma.Location = new Point(450, 0);
            btnUbicAlma.Margin = new Padding(5, 6, 5, 6);
            btnUbicAlma.Name = "btnUbicAlma";
            btnUbicAlma.Padding = new Padding(5, 0, 0, 0);
            btnUbicAlma.Size = new Size(150, 57);
            btnUbicAlma.TabIndex = 3;
            btnUbicAlma.Text = "Ubicación Almacenes";
            btnUbicAlma.UseVisualStyleBackColor = true;
            btnUbicAlma.Click += btnUbicAlma_Click;
            // 
            // btnUmbStock
            // 
            btnUmbStock.Dock = DockStyle.Left;
            btnUmbStock.FlatAppearance.BorderSize = 0;
            btnUmbStock.FlatStyle = FlatStyle.Flat;
            btnUmbStock.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUmbStock.ForeColor = Color.DimGray;
            btnUmbStock.IconChar = FontAwesome.Sharp.IconChar.PlusMinus;
            btnUmbStock.IconColor = Color.DimGray;
            btnUmbStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUmbStock.IconSize = 25;
            btnUmbStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnUmbStock.Location = new Point(300, 0);
            btnUmbStock.Margin = new Padding(5, 6, 5, 6);
            btnUmbStock.Name = "btnUmbStock";
            btnUmbStock.Padding = new Padding(0, 0, 20, 0);
            btnUmbStock.Size = new Size(150, 57);
            btnUmbStock.TabIndex = 2;
            btnUmbStock.Text = "Umbral Stock";
            btnUmbStock.TextAlign = ContentAlignment.MiddleRight;
            btnUmbStock.UseVisualStyleBackColor = true;
            btnUmbStock.Click += btnUmbStock_Click;
            // 
            // btnCatAndCal
            // 
            btnCatAndCal.Dock = DockStyle.Left;
            btnCatAndCal.FlatAppearance.BorderSize = 0;
            btnCatAndCal.FlatStyle = FlatStyle.Flat;
            btnCatAndCal.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCatAndCal.ForeColor = Color.DimGray;
            btnCatAndCal.IconChar = FontAwesome.Sharp.IconChar.VoteYea;
            btnCatAndCal.IconColor = Color.DimGray;
            btnCatAndCal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCatAndCal.IconSize = 25;
            btnCatAndCal.ImageAlign = ContentAlignment.MiddleLeft;
            btnCatAndCal.Location = new Point(150, 0);
            btnCatAndCal.Margin = new Padding(5, 6, 5, 6);
            btnCatAndCal.Name = "btnCatAndCal";
            btnCatAndCal.Size = new Size(150, 57);
            btnCatAndCal.TabIndex = 1;
            btnCatAndCal.Text = "Organizador\r\nProductos";
            btnCatAndCal.UseVisualStyleBackColor = true;
            btnCatAndCal.Click += btnCatAndCal_Click;
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
        private FontAwesome.Sharp.IconButton btnUmbStock;
        private FontAwesome.Sharp.IconButton btnCatAndCal;
        private FontAwesome.Sharp.IconButton btnAllUser;
        private FontAwesome.Sharp.IconButton btnUbicAlma;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnNoti;
        private Panel plContenedor;
    }
}