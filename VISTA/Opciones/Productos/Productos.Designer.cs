namespace ProyectoContabilidadDeCosto.Opciones.Productos
{
    partial class Productos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            panel1 = new Panel();
            btnRegresar = new Button();
            label1 = new Label();
            txtProducto = new TextBox();
            label7 = new Label();
            txtCodProducto = new TextBox();
            label6 = new Label();
            label2 = new Label();
            cbCategorias = new ComboBox();
            plContenedor = new Panel();
            button1 = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            dgvProductos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            plContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 43, 73);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(874, 40);
            panel1.TabIndex = 3;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnRegresar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Image = VISTA.Properties.Resources.Atras;
            btnRegresar.Location = new Point(791, 0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(82, 40);
            btnRegresar.TabIndex = 1;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(21, 105);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(185, 22);
            txtProducto.TabIndex = 8;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 85);
            label7.Name = "label7";
            label7.Size = new Size(63, 17);
            label7.TabIndex = 6;
            label7.Text = "Producto";
            // 
            // txtCodProducto
            // 
            txtCodProducto.Location = new Point(22, 46);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(184, 22);
            txtCodProducto.TabIndex = 9;
            txtCodProducto.TextChanged += txtCodProducto_TextChanged;
            txtCodProducto.KeyPress += txtCodProducto_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 26);
            label6.Name = "label6";
            label6.Size = new Size(132, 17);
            label6.TabIndex = 7;
            label6.Text = "Código del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 144);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 6;
            label2.Text = "Categoria";
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Items.AddRange(new object[] { "Consolas", "Accesorios", "VideoJuegos" });
            cbCategorias.Location = new Point(22, 164);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(184, 25);
            cbCategorias.TabIndex = 10;
            // 
            // plContenedor
            // 
            plContenedor.BackColor = Color.SlateGray;
            plContenedor.Controls.Add(button1);
            plContenedor.Controls.Add(btnEliminar);
            plContenedor.Controls.Add(btnGuardar);
            plContenedor.Controls.Add(label6);
            plContenedor.Controls.Add(cbCategorias);
            plContenedor.Controls.Add(txtCodProducto);
            plContenedor.Controls.Add(label2);
            plContenedor.Controls.Add(label7);
            plContenedor.Controls.Add(txtProducto);
            plContenedor.Location = new Point(0, 39);
            plContenedor.Name = "plContenedor";
            plContenedor.Size = new Size(227, 412);
            plContenedor.TabIndex = 11;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = VISTA.Properties.Resources.Borrador;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(22, 323);
            button1.Name = "button1";
            button1.Size = new Size(184, 39);
            button1.TabIndex = 12;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = VISTA.Properties.Resources.Bote_De_Basura;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(22, 278);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 39);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = VISTA.Properties.Resources.Guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(22, 233);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(184, 39);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Producto, Categoria });
            dgvProductos.Location = new Point(243, 94);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(619, 294);
            dgvProductos.TabIndex = 12;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // Codigo
            // 
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Codigo.DefaultCellStyle = dataGridViewCellStyle1;
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            Producto.DefaultCellStyle = dataGridViewCellStyle2;
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 250;
            // 
            // Categoria
            // 
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            Categoria.DefaultCellStyle = dataGridViewCellStyle3;
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 225;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(874, 450);
            Controls.Add(dgvProductos);
            Controls.Add(plContenedor);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            plContenedor.ResumeLayout(false);
            plContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegresar;
        private Label label1;
        private TextBox txtProducto;
        private Label label7;
        private TextBox txtCodProducto;
        private Label label6;
        private Label label2;
        private ComboBox cbCategorias;
        private Panel plContenedor;
        private Button button1;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoria;
    }
}