namespace Vista.Vistas.Hijos
{
    partial class frmFacturar
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
            plTitles = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvVentas = new DataGridView();
            panel1 = new Panel();
            btnFacturar = new CustomControls.RJControls.RJButton();
            label4 = new Label();
            txtCantidad = new CustomControls.RJControls.RJTextBox();
            cmbClientes = new Controles_personalizados.RJComboBox();
            label3 = new Label();
            label2 = new Label();
            txtCodBarra = new CustomControls.RJControls.RJTextBox();
            panel2 = new Panel();
            label7 = new Label();
            txtTotal = new CustomControls.RJControls.RJTextBox();
            label6 = new Label();
            txtIVA = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            txtSubTotal = new CustomControls.RJControls.RJTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn0 = new CustomControls.RJControls.RJButton();
            btn9 = new CustomControls.RJControls.RJButton();
            btn8 = new CustomControls.RJControls.RJButton();
            btn7 = new CustomControls.RJControls.RJButton();
            btn6 = new CustomControls.RJControls.RJButton();
            btn5 = new CustomControls.RJControls.RJButton();
            btn4 = new CustomControls.RJControls.RJButton();
            btn3 = new CustomControls.RJControls.RJButton();
            btn2 = new CustomControls.RJControls.RJButton();
            btn1 = new CustomControls.RJControls.RJButton();
            plTitle.SuspendLayout();
            plTitles.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // plTitle
            // 
            plTitle.Controls.Add(plTitles);
            plTitle.Dock = DockStyle.Top;
            plTitle.Location = new Point(0, 0);
            plTitle.Name = "plTitle";
            plTitle.Size = new Size(1000, 57);
            plTitle.TabIndex = 1;
            // 
            // plTitles
            // 
            plTitles.Controls.Add(label1);
            plTitles.Dock = DockStyle.Left;
            plTitles.Location = new Point(0, 0);
            plTitles.Name = "plTitles";
            plTitles.Size = new Size(192, 57);
            plTitles.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(172, 33);
            label1.TabIndex = 0;
            label1.Text = "Facturación";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.5F));
            tableLayoutPanel1.Controls.Add(dgvVentas, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 57);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.9823627F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70.01764F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1000, 567);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvVentas
            // 
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(3, 173);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.Size = new Size(649, 391);
            dgvVentas.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFacturar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(cmbClientes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCodBarra);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 164);
            panel1.TabIndex = 1;
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.CornflowerBlue;
            btnFacturar.BackgroundColor = Color.CornflowerBlue;
            btnFacturar.BorderColor = Color.PaleVioletRed;
            btnFacturar.BorderRadius = 20;
            btnFacturar.BorderSize = 0;
            btnFacturar.FlatAppearance.BorderSize = 0;
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFacturar.ForeColor = Color.White;
            btnFacturar.Location = new Point(463, 100);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(150, 40);
            btnFacturar.TabIndex = 9;
            btnFacturar.Text = "Facturar";
            btnFacturar.TextColor = Color.White;
            btnFacturar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 100);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 8;
            label4.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.Window;
            txtCantidad.BorderColor = Color.RoyalBlue;
            txtCantidad.BorderFocusColor = Color.HotPink;
            txtCantidad.BorderRadius = 0;
            txtCantidad.BorderSize = 2;
            txtCantidad.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.ForeColor = Color.FromArgb(64, 64, 64);
            txtCantidad.Location = new Point(103, 94);
            txtCantidad.Margin = new Padding(4);
            txtCantidad.Multiline = false;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Padding = new Padding(10, 7, 10, 7);
            txtCantidad.PasswordChar = false;
            txtCantidad.PlaceholderColor = Color.DarkGray;
            txtCantidad.PlaceholderText = "";
            txtCantidad.Size = new Size(150, 31);
            txtCantidad.TabIndex = 7;
            txtCantidad.Texts = "";
            txtCantidad.UnderlinedStyle = true;
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = Color.White;
            cmbClientes.BorderColor = Color.RoyalBlue;
            cmbClientes.BorderSize = 1;
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDown;
            cmbClientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbClientes.ForeColor = Color.DimGray;
            cmbClientes.IconColor = Color.RoyalBlue;
            cmbClientes.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbClientes.ListTextColor = Color.DimGray;
            cmbClientes.Location = new Point(399, 17);
            cmbClientes.MinimumSize = new Size(200, 30);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Padding = new Padding(1);
            cmbClientes.Size = new Size(200, 30);
            cmbClientes.TabIndex = 4;
            cmbClientes.Texts = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(335, 23);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 3;
            label3.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 23);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // txtCodBarra
            // 
            txtCodBarra.BackColor = SystemColors.Window;
            txtCodBarra.BorderColor = Color.RoyalBlue;
            txtCodBarra.BorderFocusColor = Color.HotPink;
            txtCodBarra.BorderRadius = 0;
            txtCodBarra.BorderSize = 2;
            txtCodBarra.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodBarra.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodBarra.Location = new Point(86, 17);
            txtCodBarra.Margin = new Padding(4);
            txtCodBarra.Multiline = false;
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.Padding = new Padding(10, 7, 10, 7);
            txtCodBarra.PasswordChar = false;
            txtCodBarra.PlaceholderColor = Color.DarkGray;
            txtCodBarra.PlaceholderText = "";
            txtCodBarra.Size = new Size(167, 31);
            txtCodBarra.TabIndex = 0;
            txtCodBarra.Texts = "";
            txtCodBarra.UnderlinedStyle = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtIVA);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtSubTotal);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(658, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 164);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(85, 103);
            label7.Name = "label7";
            label7.Size = new Size(41, 19);
            label7.TabIndex = 12;
            label7.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Window;
            txtTotal.BorderColor = Color.RoyalBlue;
            txtTotal.BorderFocusColor = Color.HotPink;
            txtTotal.BorderRadius = 0;
            txtTotal.BorderSize = 2;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.FromArgb(64, 64, 64);
            txtTotal.Location = new Point(158, 97);
            txtTotal.Margin = new Padding(4);
            txtTotal.Multiline = false;
            txtTotal.Name = "txtTotal";
            txtTotal.Padding = new Padding(10, 7, 10, 7);
            txtTotal.PasswordChar = false;
            txtTotal.PlaceholderColor = Color.DarkGray;
            txtTotal.PlaceholderText = "";
            txtTotal.Size = new Size(101, 31);
            txtTotal.TabIndex = 11;
            txtTotal.Texts = "";
            txtTotal.UnderlinedStyle = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(85, 66);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 10;
            label6.Text = "I.V.A.";
            // 
            // txtIVA
            // 
            txtIVA.BackColor = SystemColors.Window;
            txtIVA.BorderColor = Color.RoyalBlue;
            txtIVA.BorderFocusColor = Color.HotPink;
            txtIVA.BorderRadius = 0;
            txtIVA.BorderSize = 2;
            txtIVA.Enabled = false;
            txtIVA.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtIVA.ForeColor = Color.FromArgb(64, 64, 64);
            txtIVA.Location = new Point(159, 60);
            txtIVA.Margin = new Padding(4);
            txtIVA.Multiline = false;
            txtIVA.Name = "txtIVA";
            txtIVA.Padding = new Padding(10, 7, 10, 7);
            txtIVA.PasswordChar = false;
            txtIVA.PlaceholderColor = Color.DarkGray;
            txtIVA.PlaceholderText = "";
            txtIVA.Size = new Size(100, 31);
            txtIVA.TabIndex = 9;
            txtIVA.Texts = "";
            txtIVA.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(74, 29);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 8;
            label5.Text = "SubTotal";
            label5.Click += label5_Click;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = SystemColors.Window;
            txtSubTotal.BorderColor = Color.RoyalBlue;
            txtSubTotal.BorderFocusColor = Color.HotPink;
            txtSubTotal.BorderRadius = 0;
            txtSubTotal.BorderSize = 2;
            txtSubTotal.Enabled = false;
            txtSubTotal.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubTotal.ForeColor = Color.FromArgb(64, 64, 64);
            txtSubTotal.Location = new Point(158, 23);
            txtSubTotal.Margin = new Padding(4);
            txtSubTotal.Multiline = false;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Padding = new Padding(10, 7, 10, 7);
            txtSubTotal.PasswordChar = false;
            txtSubTotal.PlaceholderColor = Color.DarkGray;
            txtSubTotal.PlaceholderText = "";
            txtSubTotal.Size = new Size(100, 31);
            txtSubTotal.TabIndex = 7;
            txtSubTotal.Texts = "";
            txtSubTotal.UnderlinedStyle = true;
            txtSubTotal._TextChanged += rjTextBox2__TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btn0, 1, 3);
            tableLayoutPanel2.Controls.Add(btn9, 2, 2);
            tableLayoutPanel2.Controls.Add(btn8, 1, 2);
            tableLayoutPanel2.Controls.Add(btn7, 0, 2);
            tableLayoutPanel2.Controls.Add(btn6, 2, 1);
            tableLayoutPanel2.Controls.Add(btn5, 1, 1);
            tableLayoutPanel2.Controls.Add(btn4, 0, 1);
            tableLayoutPanel2.Controls.Add(btn3, 2, 0);
            tableLayoutPanel2.Controls.Add(btn2, 1, 0);
            tableLayoutPanel2.Controls.Add(btn1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(658, 173);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(339, 391);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btn0
            // 
            btn0.BackColor = Color.RoyalBlue;
            btn0.BackgroundColor = Color.RoyalBlue;
            btn0.BorderColor = Color.PaleVioletRed;
            btn0.BorderRadius = 10;
            btn0.BorderSize = 0;
            btn0.Dock = DockStyle.Fill;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(116, 294);
            btn0.Name = "btn0";
            btn0.Size = new Size(107, 94);
            btn0.TabIndex = 21;
            btn0.Text = "0";
            btn0.TextColor = Color.White;
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += AgregarNumero;
            // 
            // btn9
            // 
            btn9.BackColor = Color.RoyalBlue;
            btn9.BackgroundColor = Color.RoyalBlue;
            btn9.BorderColor = Color.PaleVioletRed;
            btn9.BorderRadius = 10;
            btn9.BorderSize = 0;
            btn9.Dock = DockStyle.Fill;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(229, 197);
            btn9.Name = "btn9";
            btn9.Size = new Size(107, 91);
            btn9.TabIndex = 19;
            btn9.Text = "9";
            btn9.TextColor = Color.White;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += AgregarNumero;
            // 
            // btn8
            // 
            btn8.BackColor = Color.RoyalBlue;
            btn8.BackgroundColor = Color.RoyalBlue;
            btn8.BorderColor = Color.PaleVioletRed;
            btn8.BorderRadius = 10;
            btn8.BorderSize = 0;
            btn8.Dock = DockStyle.Fill;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(116, 197);
            btn8.Name = "btn8";
            btn8.Size = new Size(107, 91);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.TextColor = Color.White;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += AgregarNumero;
            // 
            // btn7
            // 
            btn7.BackColor = Color.RoyalBlue;
            btn7.BackgroundColor = Color.RoyalBlue;
            btn7.BorderColor = Color.PaleVioletRed;
            btn7.BorderRadius = 10;
            btn7.BorderSize = 0;
            btn7.Dock = DockStyle.Fill;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(3, 197);
            btn7.Name = "btn7";
            btn7.Size = new Size(107, 91);
            btn7.TabIndex = 17;
            btn7.Text = "7";
            btn7.TextColor = Color.White;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += AgregarNumero;
            // 
            // btn6
            // 
            btn6.BackColor = Color.RoyalBlue;
            btn6.BackgroundColor = Color.RoyalBlue;
            btn6.BorderColor = Color.PaleVioletRed;
            btn6.BorderRadius = 10;
            btn6.BorderSize = 0;
            btn6.Dock = DockStyle.Fill;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(229, 100);
            btn6.Name = "btn6";
            btn6.Size = new Size(107, 91);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.TextColor = Color.White;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += AgregarNumero;
            // 
            // btn5
            // 
            btn5.BackColor = Color.RoyalBlue;
            btn5.BackgroundColor = Color.RoyalBlue;
            btn5.BorderColor = Color.PaleVioletRed;
            btn5.BorderRadius = 10;
            btn5.BorderSize = 0;
            btn5.Dock = DockStyle.Fill;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(116, 100);
            btn5.Name = "btn5";
            btn5.Size = new Size(107, 91);
            btn5.TabIndex = 15;
            btn5.Text = "5";
            btn5.TextColor = Color.White;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += AgregarNumero;
            // 
            // btn4
            // 
            btn4.BackColor = Color.RoyalBlue;
            btn4.BackgroundColor = Color.RoyalBlue;
            btn4.BorderColor = Color.PaleVioletRed;
            btn4.BorderRadius = 10;
            btn4.BorderSize = 0;
            btn4.Dock = DockStyle.Fill;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(3, 100);
            btn4.Name = "btn4";
            btn4.Size = new Size(107, 91);
            btn4.TabIndex = 14;
            btn4.Text = "4";
            btn4.TextColor = Color.White;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += AgregarNumero;
            // 
            // btn3
            // 
            btn3.BackColor = Color.RoyalBlue;
            btn3.BackgroundColor = Color.RoyalBlue;
            btn3.BorderColor = Color.PaleVioletRed;
            btn3.BorderRadius = 10;
            btn3.BorderSize = 0;
            btn3.Dock = DockStyle.Fill;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(229, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(107, 91);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.TextColor = Color.White;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += AgregarNumero;
            // 
            // btn2
            // 
            btn2.BackColor = Color.RoyalBlue;
            btn2.BackgroundColor = Color.RoyalBlue;
            btn2.BorderColor = Color.PaleVioletRed;
            btn2.BorderRadius = 10;
            btn2.BorderSize = 0;
            btn2.Dock = DockStyle.Fill;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(116, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(107, 91);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.TextColor = Color.White;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += AgregarNumero;
            // 
            // btn1
            // 
            btn1.BackColor = Color.RoyalBlue;
            btn1.BackgroundColor = Color.RoyalBlue;
            btn1.BorderColor = Color.PaleVioletRed;
            btn1.BorderRadius = 10;
            btn1.BorderSize = 0;
            btn1.Dock = DockStyle.Fill;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(107, 91);
            btn1.TabIndex = 11;
            btn1.Text = "1";
            btn1.TextColor = Color.White;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += AgregarNumero;
            // 
            // frmFacturar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 624);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(plTitle);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFacturar";
            RightToLeftLayout = true;
            Text = "frmFacturar";
            plTitle.ResumeLayout(false);
            plTitles.ResumeLayout(false);
            plTitles.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel plTitle;
        private Panel plTitles;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvVentas;
        private Panel panel1;
        private Controles_personalizados.RJComboBox cmbClientes;
        private Label label3;
        private Label label2;
        private CustomControls.RJControls.RJTextBox txtCodBarra;
        private CustomControls.RJControls.RJButton rjButton11;
        private CustomControls.RJControls.RJButton rjButton10;
        private CustomControls.RJControls.RJButton rjButton9;
        private CustomControls.RJControls.RJButton rjButton8;
        private CustomControls.RJControls.RJButton rjButton7;
        private CustomControls.RJControls.RJButton rjButton6;
        private CustomControls.RJControls.RJButton rjButton5;
        private CustomControls.RJControls.RJButton rjButton2;
        private Label label4;
        private CustomControls.RJControls.RJTextBox txtCantidad;
        private Panel panel2;
        private Label label5;
        private CustomControls.RJControls.RJTextBox txtSubTotal;
        private Label label6;
        private CustomControls.RJControls.RJTextBox txtIVA;
        private Label label7;
        private CustomControls.RJControls.RJTextBox txtTotal;
        private CustomControls.RJControls.RJButton btnFacturar;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomControls.RJControls.RJButton btn0;
        private CustomControls.RJControls.RJButton btn9;
        private CustomControls.RJControls.RJButton btn8;
        private CustomControls.RJControls.RJButton btn7;
        private CustomControls.RJControls.RJButton btn6;
        private CustomControls.RJControls.RJButton btn5;
        private CustomControls.RJControls.RJButton btn4;
        private CustomControls.RJControls.RJButton btn3;
        private CustomControls.RJControls.RJButton btn2;
        private CustomControls.RJControls.RJButton btn1;
    }
}