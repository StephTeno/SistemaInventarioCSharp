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
            panel2 = new Panel();
            btnAdd = new CustomControls.RJControls.RJButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvCompras = new DataGridView();
            panel1 = new Panel();
            txtCant = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            label1 = new Label();
            txtCodBarra = new CustomControls.RJControls.RJTextBox();
            cmbProveedor = new Controles_personalizados.RJComboBox();
            label3 = new Label();
            label5 = new Label();
            txtRecibo = new CustomControls.RJControls.RJTextBox();
            panel3 = new Panel();
            btnAddProducto = new CustomControls.RJControls.RJButton();
            txtTotal = new CustomControls.RJControls.RJTextBox();
            label7 = new Label();
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
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 501);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 60);
            panel2.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumAquamarine;
            btnAdd.BackgroundColor = Color.MediumAquamarine;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 10;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(382, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 50);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar Salida";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.Controls.Add(dgvCompras, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.9823627F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70.01764F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(977, 501);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // dgvCompras
            // 
            dgvCompras.BackgroundColor = Color.White;
            dgvCompras.BorderStyle = BorderStyle.None;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Dock = DockStyle.Fill;
            dgvCompras.Location = new Point(3, 153);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowTemplate.Height = 25;
            dgvCompras.Size = new Size(604, 345);
            dgvCompras.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCant);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCodBarra);
            panel1.Controls.Add(cmbProveedor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtRecibo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 144);
            panel1.TabIndex = 1;
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
            txtCant.Location = new Point(360, 81);
            txtCant.Margin = new Padding(4);
            txtCant.Multiline = false;
            txtCant.Name = "txtCant";
            txtCant.Padding = new Padding(10, 7, 10, 7);
            txtCant.PasswordChar = false;
            txtCant.PlaceholderColor = Color.DarkGray;
            txtCant.PlaceholderText = "";
            txtCant.Size = new Size(140, 31);
            txtCant.TabIndex = 14;
            txtCant.Texts = "";
            txtCant.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(278, 87);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 13;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(319, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 10;
            label1.Text = "No de Recibo";
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
            txtCodBarra.Location = new Point(92, 81);
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
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.White;
            cmbProveedor.BorderColor = Color.RoyalBlue;
            cmbProveedor.BorderSize = 1;
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDown;
            cmbProveedor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProveedor.ForeColor = Color.DimGray;
            cmbProveedor.IconColor = Color.RoyalBlue;
            cmbProveedor.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbProveedor.ListTextColor = Color.DimGray;
            cmbProveedor.Location = new Point(102, 27);
            cmbProveedor.MinimumSize = new Size(200, 30);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Padding = new Padding(1);
            cmbProveedor.Size = new Size(200, 30);
            cmbProveedor.TabIndex = 4;
            cmbProveedor.Texts = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 33);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 3;
            label3.Text = "Proveedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 87);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 1;
            label5.Text = "Código";
            // 
            // txtRecibo
            // 
            txtRecibo.BackColor = SystemColors.Window;
            txtRecibo.BorderColor = Color.RoyalBlue;
            txtRecibo.BorderFocusColor = Color.HotPink;
            txtRecibo.BorderRadius = 0;
            txtRecibo.BorderSize = 2;
            txtRecibo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecibo.ForeColor = Color.FromArgb(64, 64, 64);
            txtRecibo.Location = new Point(428, 27);
            txtRecibo.Margin = new Padding(4);
            txtRecibo.Multiline = false;
            txtRecibo.Name = "txtRecibo";
            txtRecibo.Padding = new Padding(10, 7, 10, 7);
            txtRecibo.PasswordChar = false;
            txtRecibo.PlaceholderColor = Color.DarkGray;
            txtRecibo.PlaceholderText = "";
            txtRecibo.Size = new Size(167, 31);
            txtRecibo.TabIndex = 0;
            txtRecibo.Texts = "";
            txtRecibo.UnderlinedStyle = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAddProducto);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(613, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 144);
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
            btnAddProducto.Location = new Point(103, 81);
            btnAddProducto.Name = "btnAddProducto";
            btnAddProducto.Size = new Size(175, 40);
            btnAddProducto.TabIndex = 9;
            btnAddProducto.Text = "Agregar Producto";
            btnAddProducto.TextColor = Color.White;
            btnAddProducto.UseVisualStyleBackColor = false;
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
            txtTotal.Location = new Point(151, 27);
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
            label7.Location = new Point(78, 33);
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
            tableLayoutPanel2.Location = new Point(613, 153);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(361, 345);
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
            btn0.Location = new Point(123, 261);
            btn0.Name = "btn0";
            btn0.Size = new Size(114, 81);
            btn0.TabIndex = 21;
            btn0.Text = "0";
            btn0.TextColor = Color.White;
            btn0.UseVisualStyleBackColor = false;
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
            btn9.Location = new Point(243, 175);
            btn9.Name = "btn9";
            btn9.Size = new Size(115, 80);
            btn9.TabIndex = 19;
            btn9.Text = "9";
            btn9.TextColor = Color.White;
            btn9.UseVisualStyleBackColor = false;
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
            btn8.Location = new Point(123, 175);
            btn8.Name = "btn8";
            btn8.Size = new Size(114, 80);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.TextColor = Color.White;
            btn8.UseVisualStyleBackColor = false;
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
            btn7.Location = new Point(3, 175);
            btn7.Name = "btn7";
            btn7.Size = new Size(114, 80);
            btn7.TabIndex = 17;
            btn7.Text = "7";
            btn7.TextColor = Color.White;
            btn7.UseVisualStyleBackColor = false;
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
            btn6.Location = new Point(243, 89);
            btn6.Name = "btn6";
            btn6.Size = new Size(115, 80);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.TextColor = Color.White;
            btn6.UseVisualStyleBackColor = false;
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
            btn5.Location = new Point(123, 89);
            btn5.Name = "btn5";
            btn5.Size = new Size(114, 80);
            btn5.TabIndex = 15;
            btn5.Text = "5";
            btn5.TextColor = Color.White;
            btn5.UseVisualStyleBackColor = false;
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
            btn4.Location = new Point(3, 89);
            btn4.Name = "btn4";
            btn4.Size = new Size(114, 80);
            btn4.TabIndex = 14;
            btn4.Text = "4";
            btn4.TextColor = Color.White;
            btn4.UseVisualStyleBackColor = false;
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
            btn3.Size = new Size(115, 80);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.TextColor = Color.White;
            btn3.UseVisualStyleBackColor = false;
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
            btn2.Size = new Size(114, 80);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.TextColor = Color.White;
            btn2.UseVisualStyleBackColor = false;
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
            btn1.Size = new Size(114, 80);
            btn1.TabIndex = 11;
            btn1.Text = "1";
            btn1.TextColor = Color.White;
            btn1.UseVisualStyleBackColor = false;
            // 
            // frmMetSalidas
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 561);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMetSalidas";
            Text = "frmMetSalidas";
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private CustomControls.RJControls.RJButton btnAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvCompras;
        private Panel panel1;
        private CustomControls.RJControls.RJTextBox txtCant;
        private Label label2;
        private Label label1;
        private CustomControls.RJControls.RJTextBox txtCodBarra;
        private Controles_personalizados.RJComboBox cmbProveedor;
        private Label label3;
        private Label label5;
        private CustomControls.RJControls.RJTextBox txtRecibo;
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
    }
}