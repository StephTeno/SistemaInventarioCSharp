namespace Vista.Vistas.Hijos
{
    partial class frmInventario
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
            plOptions = new Panel();
            btnRegSalidas = new FontAwesome.Sharp.IconButton();
            btnRegEntrada = new FontAwesome.Sharp.IconButton();
            plTitle = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            plContenedor = new Panel();
            plOptions.SuspendLayout();
            plTitle.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // plOptions
            // 
            plOptions.Controls.Add(btnRegSalidas);
            plOptions.Controls.Add(btnRegEntrada);
            plOptions.Dock = DockStyle.Top;
            plOptions.Location = new Point(0, 57);
            plOptions.Name = "plOptions";
            plOptions.Size = new Size(1000, 57);
            plOptions.TabIndex = 3;
            // 
            // btnRegSalidas
            // 
            btnRegSalidas.Dock = DockStyle.Left;
            btnRegSalidas.FlatAppearance.BorderSize = 0;
            btnRegSalidas.FlatStyle = FlatStyle.Flat;
            btnRegSalidas.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegSalidas.ForeColor = Color.DimGray;
            btnRegSalidas.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            btnRegSalidas.IconColor = Color.DimGray;
            btnRegSalidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegSalidas.IconSize = 25;
            btnRegSalidas.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegSalidas.Location = new Point(150, 0);
            btnRegSalidas.Margin = new Padding(5, 6, 5, 6);
            btnRegSalidas.Name = "btnRegSalidas";
            btnRegSalidas.Padding = new Padding(5, 0, 40, 0);
            btnRegSalidas.Size = new Size(150, 57);
            btnRegSalidas.TabIndex = 2;
            btnRegSalidas.Text = "Salidas";
            btnRegSalidas.TextAlign = ContentAlignment.MiddleRight;
            btnRegSalidas.UseVisualStyleBackColor = true;
            btnRegSalidas.Click += btnRegSalidas_Click;
            // 
            // btnRegEntrada
            // 
            btnRegEntrada.Dock = DockStyle.Left;
            btnRegEntrada.FlatAppearance.BorderSize = 0;
            btnRegEntrada.FlatStyle = FlatStyle.Flat;
            btnRegEntrada.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegEntrada.ForeColor = Color.DimGray;
            btnRegEntrada.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            btnRegEntrada.IconColor = Color.DimGray;
            btnRegEntrada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegEntrada.IconSize = 25;
            btnRegEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegEntrada.Location = new Point(0, 0);
            btnRegEntrada.Margin = new Padding(5, 6, 5, 6);
            btnRegEntrada.Name = "btnRegEntrada";
            btnRegEntrada.Padding = new Padding(5, 0, 30, 0);
            btnRegEntrada.Size = new Size(150, 57);
            btnRegEntrada.TabIndex = 0;
            btnRegEntrada.Text = "Entradas";
            btnRegEntrada.TextAlign = ContentAlignment.MiddleRight;
            btnRegEntrada.UseVisualStyleBackColor = true;
            btnRegEntrada.Click += btnRegEntrada_Click;
            // 
            // plTitle
            // 
            plTitle.Controls.Add(panel1);
            plTitle.Dock = DockStyle.Top;
            plTitle.Location = new Point(0, 0);
            plTitle.Name = "plTitle";
            plTitle.Size = new Size(1000, 57);
            plTitle.TabIndex = 2;
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
            label1.Size = new Size(148, 33);
            label1.TabIndex = 0;
            label1.Text = "Inventario";
            // 
            // plContenedor
            // 
            plContenedor.Dock = DockStyle.Fill;
            plContenedor.Location = new Point(0, 114);
            plContenedor.Name = "plContenedor";
            plContenedor.Size = new Size(1000, 510);
            plContenedor.TabIndex = 4;
            // 
            // frmInventario
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
            Name = "frmInventario";
            Text = "Inventario";
            Load += frmInventario_Load;
            plOptions.ResumeLayout(false);
            plTitle.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plOptions;
        private FontAwesome.Sharp.IconButton btnRegSalidas;
        private FontAwesome.Sharp.IconButton btnRegEntrada;
        private Panel plTitle;
        private Panel panel1;
        private Label label1;
        private Panel plContenedor;
    }
}