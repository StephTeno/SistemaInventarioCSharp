namespace ProyectoContabilidadDeCosto.Opciones.Entrada
{
    partial class Entrada
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            panel1 = new Panel();
            btnRegresar = new Button();
            label1 = new Label();
            dgvEntrada = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            nupCant = new NumericUpDown();
            dtRegistro = new DateTimePicker();
            label3 = new Label();
            txtProveedor = new TextBox();
            label5 = new Label();
            txtPrecioCompra = new TextBox();
            txtCodProducto = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            txtDocProveedor = new TextBox();
            label4 = new Label();
            txtNumDoumento = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            lblTotal = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntrada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupCant).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 43, 73);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 40);
            panel1.TabIndex = 2;
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
            label1.Size = new Size(112, 28);
            label1.TabIndex = 0;
            label1.Text = "Entradas";
            // 
            // dgvEntrada
            // 
            dgvEntrada.BackgroundColor = Color.White;
            dgvEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntrada.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, PrecioCompra, Cantidad, SubTotal });
            dgvEntrada.Location = new Point(26, 210);
            dgvEntrada.Name = "dgvEntrada";
            dgvEntrada.RowHeadersWidth = 51;
            dgvEntrada.RowTemplate.Height = 25;
            dgvEntrada.Size = new Size(695, 222);
            dgvEntrada.TabIndex = 29;
            // 
            // Codigo
            // 
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Codigo.DefaultCellStyle = dataGridViewCellStyle1;
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 125;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            Descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 250;
            // 
            // PrecioCompra
            // 
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            PrecioCompra.DefaultCellStyle = dataGridViewCellStyle3;
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 125;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            SubTotal.DefaultCellStyle = dataGridViewCellStyle5;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 125;
            // 
            // nupCant
            // 
            nupCant.Location = new Point(351, 166);
            nupCant.Name = "nupCant";
            nupCant.Size = new Size(115, 26);
            nupCant.TabIndex = 28;
            nupCant.KeyPress += nupCant_KeyPress;
            // 
            // dtRegistro
            // 
            dtRegistro.Format = DateTimePickerFormat.Short;
            dtRegistro.Location = new Point(722, 53);
            dtRegistro.Name = "dtRegistro";
            dtRegistro.Size = new Size(117, 26);
            dtRegistro.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(575, 55);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 26;
            label3.Text = "Fecha de Registro";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(238, 110);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(246, 26);
            txtProveedor.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 90);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 13;
            label5.Text = "Proveedor";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(221, 166);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(121, 26);
            txtPrecioCompra.TabIndex = 22;
            txtPrecioCompra.TextChanged += txtPrecioCompra_TextChanged;
            txtPrecioCompra.KeyPress += txtPrecioCompra_KeyPress;
            // 
            // txtCodProducto
            // 
            txtCodProducto.Location = new Point(27, 166);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(184, 26);
            txtCodProducto.TabIndex = 23;
            txtCodProducto.TextChanged += txtCodProducto_TextChanged;
            txtCodProducto.KeyPress += txtCodProducto_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(351, 146);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 17;
            label9.Text = "Cantidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(220, 146);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 16;
            label8.Text = "Precio Compra";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 146);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 15;
            label6.Text = "Código del Producto";
            // 
            // txtDocProveedor
            // 
            txtDocProveedor.Location = new Point(27, 110);
            txtDocProveedor.Name = "txtDocProveedor";
            txtDocProveedor.Size = new Size(184, 26);
            txtDocProveedor.TabIndex = 24;
            txtDocProveedor.KeyPress += txtDocProveedor_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 90);
            label4.Name = "label4";
            label4.Size = new Size(206, 20);
            label4.TabIndex = 14;
            label4.Text = "Documento del Proveedor";
            // 
            // txtNumDoumento
            // 
            txtNumDoumento.Location = new Point(177, 52);
            txtNumDoumento.Name = "txtNumDoumento";
            txtNumDoumento.Size = new Size(122, 26);
            txtNumDoumento.TabIndex = 21;
            txtNumDoumento.TextChanged += txtNumDoumento_TextChanged;
            txtNumDoumento.KeyPress += txtNumDoumento_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 55);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 19;
            label2.Text = "No de Documento";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Image = VISTA.Properties.Resources.Guardar;
            btnGuardar.Location = new Point(671, 154);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 45);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(815, 366);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 19);
            lblTotal.TabIndex = 34;
            lblTotal.Text = "0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(753, 366);
            label10.Name = "label10";
            label10.Size = new Size(79, 19);
            label10.TabIndex = 33;
            label10.Text = "Total: C$";
            // 
            // Entrada
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(874, 450);
            Controls.Add(lblTotal);
            Controls.Add(label10);
            Controls.Add(btnGuardar);
            Controls.Add(dgvEntrada);
            Controls.Add(nupCant);
            Controls.Add(dtRegistro);
            Controls.Add(label3);
            Controls.Add(txtProveedor);
            Controls.Add(label5);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtCodProducto);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtDocProveedor);
            Controls.Add(label4);
            Controls.Add(txtNumDoumento);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Entrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntrada).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupCant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnRegresar;
        private Label label1;
        private DataGridView dgvEntrada;
        private NumericUpDown nupCant;
        private DateTimePicker dtRegistro;
        private Label label3;
        private TextBox txtProveedor;
        private Label label5;
        private TextBox txtPrecioCompra;
        private TextBox txtCodProducto;
        private Label label9;
        private Label label8;
        private Label label6;
        private TextBox txtDocProveedor;
        private Label label4;
        private TextBox txtNumDoumento;
        private Label label2;
        private Button btnGuardar;
        private Label lblTotal;
        private Label label10;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}