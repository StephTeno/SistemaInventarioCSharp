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
            panel2 = new Panel();
            lblNumUserReport = new Label();
            lblUserReport = new Label();
            lblNumUser = new Label();
            lblUser = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            lblNumShopReport = new Label();
            lblShopReport = new Label();
            lblNumShop = new Label();
            lblShops = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnSig = new FontAwesome.Sharp.IconButton();
            dgvJustRegistered = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJustRegistered).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
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
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(lblNumUserReport);
            panel2.Controls.Add(lblUserReport);
            panel2.Controls.Add(lblNumUser);
            panel2.Controls.Add(lblUser);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(8, 8);
            panel2.Margin = new Padding(3, 3, 10, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 134);
            panel2.TabIndex = 0;
            // 
            // lblNumUserReport
            // 
            lblNumUserReport.AutoSize = true;
            lblNumUserReport.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumUserReport.ForeColor = Color.White;
            lblNumUserReport.Location = new Point(307, 62);
            lblNumUserReport.Name = "lblNumUserReport";
            lblNumUserReport.Size = new Size(48, 25);
            lblNumUserReport.TabIndex = 4;
            lblNumUserReport.Text = "100";
            // 
            // lblUserReport
            // 
            lblUserReport.AutoSize = true;
            lblUserReport.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserReport.ForeColor = Color.White;
            lblUserReport.Location = new Point(271, 22);
            lblUserReport.Name = "lblUserReport";
            lblUserReport.Size = new Size(120, 25);
            lblUserReport.TabIndex = 3;
            lblUserReport.Text = "Denuncias";
            // 
            // lblNumUser
            // 
            lblNumUser.AutoSize = true;
            lblNumUser.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumUser.ForeColor = Color.White;
            lblNumUser.Location = new Point(159, 62);
            lblNumUser.Name = "lblNumUser";
            lblNumUser.Size = new Size(66, 25);
            lblNumUser.TabIndex = 2;
            lblNumUser.Text = "1,000";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(145, 22);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(96, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "Usuarios";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.CornflowerBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 90;
            iconPictureBox1.Location = new Point(24, 22);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(90, 90);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(lblNumShopReport);
            panel4.Controls.Add(lblShopReport);
            panel4.Controls.Add(lblNumShop);
            panel4.Controls.Add(lblShops);
            panel4.Controls.Add(iconPictureBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(460, 8);
            panel4.Margin = new Padding(10, 3, 3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 134);
            panel4.TabIndex = 1;
            // 
            // lblNumShopReport
            // 
            lblNumShopReport.AutoSize = true;
            lblNumShopReport.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumShopReport.ForeColor = Color.White;
            lblNumShopReport.Location = new Point(307, 62);
            lblNumShopReport.Name = "lblNumShopReport";
            lblNumShopReport.Size = new Size(48, 25);
            lblNumShopReport.TabIndex = 8;
            lblNumShopReport.Text = "100";
            // 
            // lblShopReport
            // 
            lblShopReport.AutoSize = true;
            lblShopReport.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblShopReport.ForeColor = Color.White;
            lblShopReport.Location = new Point(271, 22);
            lblShopReport.Name = "lblShopReport";
            lblShopReport.Size = new Size(120, 25);
            lblShopReport.TabIndex = 7;
            lblShopReport.Text = "Denuncias";
            // 
            // lblNumShop
            // 
            lblNumShop.AutoSize = true;
            lblNumShop.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumShop.ForeColor = Color.White;
            lblNumShop.Location = new Point(159, 62);
            lblNumShop.Name = "lblNumShop";
            lblNumShop.Size = new Size(66, 25);
            lblNumShop.TabIndex = 6;
            lblNumShop.Text = "1,000";
            // 
            // lblShops
            // 
            lblShops.AutoSize = true;
            lblShops.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblShops.ForeColor = Color.White;
            lblShops.Location = new Point(145, 22);
            lblShops.Name = "lblShops";
            lblShops.Size = new Size(89, 25);
            lblShops.TabIndex = 5;
            lblShops.Text = "Tiendas";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.CornflowerBlue;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 90;
            iconPictureBox2.Location = new Point(28, 22);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(90, 90);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox2.TabIndex = 1;
            iconPictureBox2.TabStop = false;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJustRegistered).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblUser;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label lblNumUserReport;
        private Label lblUserReport;
        private Label lblNumUser;
        private Label lblNumShopReport;
        private Label lblShopReport;
        private Label lblNumShop;
        private Label lblShops;
        private DataGridView dgvJustRegistered;
        private FontAwesome.Sharp.IconButton btnSig;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
    }
}