namespace Vista.Vistas.BisNietos
{
    partial class frmMetSalidas
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvSalidas = new DataGridView();
            panel1 = new Panel();
            txtCosto = new CustomControls.RJControls.RJTextBox();
            label9 = new Label();
            txtNomProd = new CustomControls.RJControls.RJTextBox();
            label8 = new Label();
            txtCant = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            txtCodBarra = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            panel3 = new Panel();
            btnAddProducto = new CustomControls.RJControls.RJButton();
            txtTotal = new CustomControls.RJControls.RJTextBox();
            label7 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnEnter = new CustomControls.RJControls.RJButton();
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
            plTitle = new Panel();
            plTitles = new Panel();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            plTitle.SuspendLayout();
            plTitles.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.Controls.Add(dgvSalidas, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 57);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.63063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.36937F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(977, 608);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // dgvSalidas
            // 
            dgvSalidas.BackgroundColor = Color.White;
            dgvSalidas.BorderStyle = BorderStyle.None;
            dgvSalidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalidas.Dock = DockStyle.Fill;
            dgvSalidas.Location = new Point(3, 189);
            dgvSalidas.Name = "dgvSalidas";
            dgvSalidas.RowTemplate.Height = 25;
            dgvSalidas.Size = new Size(604, 416);
            dgvSalidas.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCosto);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtNomProd);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtCant);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCodBarra);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 180);
            panel1.TabIndex = 1;
            // 
            // txtCosto
            // 
            txtCosto.BackColor = SystemColors.Window;
            txtCosto.BorderColor = Color.RoyalBlue;
            txtCosto.BorderFocusColor = Color.HotPink;
            txtCosto.BorderRadius = 0;
            txtCosto.BorderSize = 2;
            txtCosto.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtCosto.ForeColor = Color.FromArgb(64, 64, 64);
            txtCosto.Location = new Point(456, 72);
            txtCosto.Margin = new Padding(4);
            txtCosto.Multiline = false;
            txtCosto.Name = "txtCosto";
            txtCosto.Padding = new Padding(10, 7, 10, 7);
            txtCosto.PasswordChar = false;
            txtCosto.PlaceholderColor = Color.DarkGray;
            txtCosto.PlaceholderText = "";
            txtCosto.Size = new Size(112, 31);
            txtCosto.TabIndex = 19;
            txtCosto.Texts = "";
            txtCosto.UnderlinedStyle = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(374, 78);
            label9.Name = "label9";
            label9.Size = new Size(48, 19);
            label9.TabIndex = 18;
            label9.Text = "Costo";
            // 
            // txtNomProd
            // 
            txtNomProd.BackColor = SystemColors.Window;
            txtNomProd.BorderColor = Color.RoyalBlue;
            txtNomProd.BorderFocusColor = Color.HotPink;
            txtNomProd.BorderRadius = 0;
            txtNomProd.BorderSize = 2;
            txtNomProd.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomProd.ForeColor = Color.FromArgb(64, 64, 64);
            txtNomProd.Location = new Point(88, 72);
            txtNomProd.Margin = new Padding(4);
            txtNomProd.Multiline = false;
            txtNomProd.Name = "txtNomProd";
            txtNomProd.Padding = new Padding(10, 7, 10, 7);
            txtNomProd.PasswordChar = false;
            txtNomProd.PlaceholderColor = Color.DarkGray;
            txtNomProd.PlaceholderText = "";
            txtNomProd.Size = new Size(243, 31);
            txtNomProd.TabIndex = 17;
            txtNomProd.Texts = "";
            txtNomProd.UnderlinedStyle = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 78);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 16;
            label8.Text = "Producto";
            // 
            // txtCant
            // 
            txtCant.BackColor = SystemColors.Window;
            txtCant.BorderColor = Color.RoyalBlue;
            txtCant.BorderFocusColor = Color.HotPink;
            txtCant.BorderRadius = 0;
            txtCant.BorderSize = 2;
            txtCant.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtCant.ForeColor = Color.FromArgb(64, 64, 64);
            txtCant.Location = new Point(356, 27);
            txtCant.Margin = new Padding(4);
            txtCant.Multiline = false;
            txtCant.Name = "txtCant";
            txtCant.Padding = new Padding(10, 7, 10, 7);
            txtCant.PasswordChar = false;
            txtCant.PlaceholderColor = Color.DarkGray;
            txtCant.PlaceholderText = "";
            txtCant.Size = new Size(112, 31);
            txtCant.TabIndex = 14;
            txtCant.Texts = "";
            txtCant.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(274, 33);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 13;
            label2.Text = "Cantidad";
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
            txtCodBarra.Location = new Point(88, 27);
            txtCodBarra.Margin = new Padding(4);
            txtCodBarra.Multiline = false;
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.Padding = new Padding(10, 7, 10, 7);
            txtCodBarra.PasswordChar = false;
            txtCodBarra.PlaceholderColor = Color.DarkGray;
            txtCodBarra.PlaceholderText = "";
            txtCodBarra.Size = new Size(140, 31);
            txtCodBarra.TabIndex = 7;
            txtCodBarra.Texts = "";
            txtCodBarra.UnderlinedStyle = true;
            txtCodBarra.KeyPress += txtCodBarra_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 33);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 1;
            label5.Text = "Código";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAddProducto);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(613, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 180);
            panel3.TabIndex = 3;
            // 
            // btnAddProducto
            // 
            btnAddProducto.BackColor = Color.CornflowerBlue;
            btnAddProducto.BackgroundColor = Color.CornflowerBlue;
            btnAddProducto.BorderColor = Color.PaleVioletRed;
            btnAddProducto.BorderRadius = 20;
            btnAddProducto.BorderSize = 0;
            btnAddProducto.FlatAppearance.BorderSize = 0;
            btnAddProducto.FlatStyle = FlatStyle.Flat;
            btnAddProducto.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddProducto.ForeColor = Color.White;
            btnAddProducto.Location = new Point(103, 68);
            btnAddProducto.Name = "btnAddProducto";
            btnAddProducto.Size = new Size(175, 40);
            btnAddProducto.TabIndex = 9;
            btnAddProducto.Text = "Agregar Producto";
            btnAddProducto.TextColor = Color.White;
            btnAddProducto.UseVisualStyleBackColor = false;
            btnAddProducto.Click += btnAddProducto_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Window;
            txtTotal.BorderColor = Color.RoyalBlue;
            txtTotal.BorderFocusColor = Color.HotPink;
            txtTotal.BorderRadius = 0;
            txtTotal.BorderSize = 2;
            txtTotal.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.FromArgb(64, 64, 64);
            txtTotal.Location = new Point(151, 17);
            txtTotal.Margin = new Padding(4);
            txtTotal.Multiline = false;
            txtTotal.Name = "txtTotal";
            txtTotal.Padding = new Padding(10, 7, 10, 7);
            txtTotal.PasswordChar = false;
            txtTotal.PlaceholderColor = Color.DarkGray;
            txtTotal.PlaceholderText = "";
            txtTotal.Size = new Size(140, 31);
            txtTotal.TabIndex = 11;
            txtTotal.Texts = "";
            txtTotal.UnderlinedStyle = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(78, 23);
            label7.Name = "label7";
            label7.Size = new Size(41, 19);
            label7.TabIndex = 12;
            label7.Text = "Total";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnEnter, 2, 3);
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
            tableLayoutPanel2.Location = new Point(613, 189);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(361, 416);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.MidnightBlue;
            btnEnter.BackgroundColor = Color.MidnightBlue;
            btnEnter.BorderColor = Color.PaleVioletRed;
            btnEnter.BorderRadius = 10;
            btnEnter.BorderSize = 0;
            btnEnter.Dock = DockStyle.Fill;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(243, 315);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(115, 98);
            btnEnter.TabIndex = 23;
            btnEnter.Text = "Agregar";
            btnEnter.TextColor = Color.White;
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnAdd_Click;
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
            btn0.Location = new Point(123, 315);
            btn0.Name = "btn0";
            btn0.Size = new Size(114, 98);
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
            btn9.Location = new Point(243, 211);
            btn9.Name = "btn9";
            btn9.Size = new Size(115, 98);
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
            btn8.Location = new Point(123, 211);
            btn8.Name = "btn8";
            btn8.Size = new Size(114, 98);
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
            btn7.Location = new Point(3, 211);
            btn7.Name = "btn7";
            btn7.Size = new Size(114, 98);
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
            btn6.Location = new Point(243, 107);
            btn6.Name = "btn6";
            btn6.Size = new Size(115, 98);
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
            btn5.Location = new Point(123, 107);
            btn5.Name = "btn5";
            btn5.Size = new Size(114, 98);
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
            btn4.Location = new Point(3, 107);
            btn4.Name = "btn4";
            btn4.Size = new Size(114, 98);
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
            btn3.Location = new Point(243, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(115, 98);
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
            btn2.Location = new Point(123, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(114, 98);
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
            btn1.Size = new Size(114, 98);
            btn1.TabIndex = 11;
            btn1.Text = "1";
            btn1.TextColor = Color.White;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += AgregarNumero;
            // 
            // plTitle
            // 
            plTitle.Controls.Add(plTitles);
            plTitle.Dock = DockStyle.Top;
            plTitle.Location = new Point(0, 0);
            plTitle.Name = "plTitle";
            plTitle.Size = new Size(977, 57);
            plTitle.TabIndex = 12;
            // 
            // plTitles
            // 
            plTitles.Controls.Add(label4);
            plTitles.Dock = DockStyle.Left;
            plTitles.Location = new Point(0, 0);
            plTitles.Name = "plTitles";
            plTitles.Size = new Size(305, 57);
            plTitles.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 7);
            label4.Name = "label4";
            label4.Size = new Size(268, 33);
            label4.TabIndex = 0;
            label4.Text = "Salida de Producto";
            // 
            // frmMetSalidas
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 665);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(plTitle);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMetSalidas";
            Load += frmMetSalidas_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSalidas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            plTitle.ResumeLayout(false);
            plTitles.ResumeLayout(false);
            plTitles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvSalidas;
        private Panel panel1;
        private CustomControls.RJControls.RJTextBox txtCosto;
        private Label label9;
        private CustomControls.RJControls.RJTextBox txtNomProd;
        private Label label8;
        private CustomControls.RJControls.RJTextBox txtCant;
        private Label label2;
        private CustomControls.RJControls.RJTextBox txtCodBarra;
        private Label label5;
        private Panel panel3;
        private CustomControls.RJControls.RJButton btnAddProducto;
        private CustomControls.RJControls.RJTextBox txtTotal;
        private Label label7;
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
        private Panel plTitle;
        private Panel plTitles;
        private Label label4;
        private Panel plContenedor;
        private CustomControls.RJControls.RJButton btnAdd;
        private CustomControls.RJControls.RJButton btnEnter;
    }
}