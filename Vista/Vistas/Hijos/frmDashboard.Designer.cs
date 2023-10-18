namespace Vista.Vistas.Hijos
{
    partial class frmDashboard
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnSig = new FontAwesome.Sharp.IconButton();
            dgvJustRegistered = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            crdEntradas = new MaterialSkin.Controls.MaterialCard();
            pbEntrada = new PictureBox();
            lblEntrada = new Label();
            lblCordEnt = new Label();
            lblCantEnt = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblCantSal = new Label();
            lblCordSal = new Label();
            lblSalida = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJustRegistered).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            crdEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEntrada).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(dgvJustRegistered);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 64);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1000, 560);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(materialCard1, 1, 0);
            tableLayoutPanel1.Controls.Add(crdEntradas, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(50, 30);
            tableLayoutPanel1.Margin = new Padding(50, 30, 50, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(900, 150);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(btnSig);
            panel3.Location = new Point(0, 210);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 50);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(264, 33);
            label2.TabIndex = 6;
            label2.Text = "Recién Registrados";
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButton1.IconColor = Color.RoyalBlue;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(865, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(50, 50);
            iconButton1.TabIndex = 5;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnSig
            // 
            btnSig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSig.FlatAppearance.BorderSize = 0;
            btnSig.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btnSig.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnSig.FlatStyle = FlatStyle.Flat;
            btnSig.ForeColor = Color.White;
            btnSig.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            btnSig.IconColor = Color.RoyalBlue;
            btnSig.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSig.IconSize = 25;
            btnSig.Location = new Point(950, 0);
            btnSig.Name = "btnSig";
            btnSig.Size = new Size(50, 50);
            btnSig.TabIndex = 4;
            btnSig.UseVisualStyleBackColor = true;
            // 
            // dgvJustRegistered
            // 
            dgvJustRegistered.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvJustRegistered.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvJustRegistered.BackgroundColor = Color.White;
            dgvJustRegistered.BorderStyle = BorderStyle.None;
            dgvJustRegistered.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJustRegistered.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJustRegistered.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJustRegistered.Dock = DockStyle.Bottom;
            dgvJustRegistered.EnableHeadersVisualStyles = false;
            dgvJustRegistered.GridColor = Color.CornflowerBlue;
            dgvJustRegistered.Location = new Point(0, 260);
            dgvJustRegistered.Margin = new Padding(0);
            dgvJustRegistered.Name = "dgvJustRegistered";
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvJustRegistered.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvJustRegistered.RowTemplate.Height = 25;
            dgvJustRegistered.Size = new Size(1000, 280);
            dgvJustRegistered.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1000, 64);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 58);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(160, 33);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // crdEntradas
            // 
            crdEntradas.BackColor = Color.FromArgb(255, 255, 255);
            crdEntradas.Controls.Add(lblCantEnt);
            crdEntradas.Controls.Add(lblCordEnt);
            crdEntradas.Controls.Add(lblEntrada);
            crdEntradas.Controls.Add(pbEntrada);
            crdEntradas.Depth = 0;
            crdEntradas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            crdEntradas.Location = new Point(19, 19);
            crdEntradas.Margin = new Padding(14);
            crdEntradas.MouseState = MaterialSkin.MouseState.HOVER;
            crdEntradas.Name = "crdEntradas";
            crdEntradas.Padding = new Padding(14);
            crdEntradas.Size = new Size(417, 112);
            crdEntradas.TabIndex = 0;
            // 
            // pbEntrada
            // 
            pbEntrada.Image = Properties.Resources.Compra;
            pbEntrada.Location = new Point(17, 17);
            pbEntrada.Name = "pbEntrada";
            pbEntrada.Size = new Size(75, 75);
            pbEntrada.SizeMode = PictureBoxSizeMode.Zoom;
            pbEntrada.TabIndex = 0;
            pbEntrada.TabStop = false;
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEntrada.Location = new Point(113, 17);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(118, 25);
            lblEntrada.TabIndex = 1;
            lblEntrada.Text = "ENTRADAS";
            // 
            // lblCordEnt
            // 
            lblCordEnt.AutoSize = true;
            lblCordEnt.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCordEnt.Location = new Point(113, 67);
            lblCordEnt.Name = "lblCordEnt";
            lblCordEnt.Size = new Size(40, 25);
            lblCordEnt.TabIndex = 2;
            lblCordEnt.Text = "C$";
            // 
            // lblCantEnt
            // 
            lblCantEnt.AutoSize = true;
            lblCantEnt.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantEnt.Location = new Point(159, 67);
            lblCantEnt.Name = "lblCantEnt";
            lblCantEnt.Size = new Size(66, 25);
            lblCantEnt.TabIndex = 3;
            lblCantEnt.Text = "00.00";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblCantSal);
            materialCard1.Controls.Add(lblCordSal);
            materialCard1.Controls.Add(lblSalida);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(464, 19);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(417, 112);
            materialCard1.TabIndex = 1;
            // 
            // lblCantSal
            // 
            lblCantSal.AutoSize = true;
            lblCantSal.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantSal.Location = new Point(159, 67);
            lblCantSal.Name = "lblCantSal";
            lblCantSal.Size = new Size(66, 25);
            lblCantSal.TabIndex = 3;
            lblCantSal.Text = "00.00";
            // 
            // lblCordSal
            // 
            lblCordSal.AutoSize = true;
            lblCordSal.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCordSal.Location = new Point(113, 67);
            lblCordSal.Name = "lblCordSal";
            lblCordSal.Size = new Size(40, 25);
            lblCordSal.TabIndex = 2;
            lblCordSal.Text = "C$";
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalida.Location = new Point(113, 17);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(118, 25);
            lblSalida.TabIndex = 1;
            lblSalida.Text = "ENTRADAS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Salida;
            pictureBox1.Location = new Point(17, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1000, 624);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            Text = "frmConfiguration";
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJustRegistered).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            crdEntradas.ResumeLayout(false);
            crdEntradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEntrada).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvJustRegistered;
        private FontAwesome.Sharp.IconButton btnSig;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private MaterialSkin.Controls.MaterialCard crdEntradas;
        private PictureBox pbEntrada;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblCantSal;
        private Label lblCordSal;
        private Label lblSalida;
        private PictureBox pictureBox1;
        private Label lblCantEnt;
        private Label lblCordEnt;
        private Label lblEntrada;
    }
}