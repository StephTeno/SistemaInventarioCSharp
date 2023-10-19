namespace Vista.Vistas.Hijos
{
    partial class frmCatalogo
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
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnSearch = new CustomControls.RJControls.RJButton();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvProductos = new DataGridView();
            panel2 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            txtpre = new CustomControls.RJControls.RJTextBox();
            txtPro = new CustomControls.RJControls.RJTextBox();
            txtCodigo = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            plTitle.SuspendLayout();
            plTitles.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
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
            plTitles.Size = new Size(166, 57);
            plTitles.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(143, 33);
            label1.TabIndex = 0;
            label1.Text = "Catálogo";
            // 
            // panel1
            // 
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(rjTextBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 50);
            panel1.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.CornflowerBlue;
            iconPictureBox1.Enabled = false;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(790, 14);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.BackgroundColor = Color.CornflowerBlue;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 15;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(776, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(50, 30);
            btnSearch.TabIndex = 4;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.CornflowerBlue;
            rjTextBox1.BorderColor = Color.White;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 15;
            rjTextBox1.BorderSize = 1;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.White;
            rjTextBox1.Location = new Point(211, 10);
            rjTextBox1.Margin = new Padding(0);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.White;
            rjTextBox1.PlaceholderText = "Buscar...";
            rjTextBox1.Size = new Size(562, 31);
            rjTextBox1.TabIndex = 0;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvProductos, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 107);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1000, 517);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(3, 3);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(494, 511);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox2);
            panel2.Controls.Add(txtpre);
            panel2.Controls.Add(txtPro);
            panel2.Controls.Add(txtCodigo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(503, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 511);
            panel2.TabIndex = 1;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.RoyalBlue;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Panorama;
            iconPictureBox2.IconColor = Color.RoyalBlue;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 100;
            iconPictureBox2.Location = new Point(199, 51);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(100, 100);
            iconPictureBox2.TabIndex = 8;
            iconPictureBox2.TabStop = false;
            // 
            // txtpre
            // 
            txtpre.BackColor = SystemColors.Window;
            txtpre.BorderColor = Color.CornflowerBlue;
            txtpre.BorderFocusColor = Color.HotPink;
            txtpre.BorderRadius = 0;
            txtpre.BorderSize = 2;
            txtpre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtpre.ForeColor = Color.FromArgb(64, 64, 64);
            txtpre.Location = new Point(178, 329);
            txtpre.Margin = new Padding(4);
            txtpre.Multiline = false;
            txtpre.Name = "txtpre";
            txtpre.Padding = new Padding(10, 7, 10, 7);
            txtpre.PasswordChar = false;
            txtpre.PlaceholderColor = Color.DarkGray;
            txtpre.PlaceholderText = "";
            txtpre.Size = new Size(250, 31);
            txtpre.TabIndex = 6;
            txtpre.Texts = "";
            txtpre.UnderlinedStyle = true;
            // 
            // txtPro
            // 
            txtPro.BackColor = SystemColors.Window;
            txtPro.BorderColor = Color.CornflowerBlue;
            txtPro.BorderFocusColor = Color.HotPink;
            txtPro.BorderRadius = 0;
            txtPro.BorderSize = 2;
            txtPro.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPro.ForeColor = Color.FromArgb(64, 64, 64);
            txtPro.Location = new Point(178, 263);
            txtPro.Margin = new Padding(4);
            txtPro.Multiline = false;
            txtPro.Name = "txtPro";
            txtPro.Padding = new Padding(10, 7, 10, 7);
            txtPro.PasswordChar = false;
            txtPro.PlaceholderColor = Color.DarkGray;
            txtPro.PlaceholderText = "";
            txtPro.Size = new Size(250, 31);
            txtPro.TabIndex = 5;
            txtPro.Texts = "";
            txtPro.UnderlinedStyle = true;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Window;
            txtCodigo.BorderColor = Color.CornflowerBlue;
            txtCodigo.BorderFocusColor = Color.HotPink;
            txtCodigo.BorderRadius = 0;
            txtCodigo.BorderSize = 2;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCodigo.Location = new Point(178, 197);
            txtCodigo.Margin = new Padding(4);
            txtCodigo.Multiline = false;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Padding = new Padding(10, 7, 10, 7);
            txtCodigo.PasswordChar = false;
            txtCodigo.PlaceholderColor = Color.DarkGray;
            txtCodigo.PlaceholderText = "";
            txtCodigo.Size = new Size(250, 31);
            txtCodigo.TabIndex = 4;
            txtCodigo.Texts = "";
            txtCodigo.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 334);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 2;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 268);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 1;
            label3.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 202);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 0;
            label2.Text = "Codigo";
            // 
            // frmCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 624);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(plTitle);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCatalogo";
            Text = "frmCatalogo";
            Load += frmCatalogo_Load;
            plTitle.ResumeLayout(false);
            plTitles.ResumeLayout(false);
            plTitles.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plTitle;
        private Panel plTitles;
        private Label label1;
        private Panel panel1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CustomControls.RJControls.RJButton btnSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvProductos;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private CustomControls.RJControls.RJTextBox txtpre;
        private CustomControls.RJControls.RJTextBox txtPro;
        private CustomControls.RJControls.RJTextBox txtCodigo;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}