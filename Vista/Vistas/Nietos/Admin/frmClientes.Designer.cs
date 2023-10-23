namespace Vista.Vistas.Nietos
{
    partial class frmClientes
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
            btnDelete = new CustomControls.RJControls.RJButton();
            btnEdit = new CustomControls.RJControls.RJButton();
            panel1 = new Panel();
            label1 = new Label();
            dgvClient = new DataGridView();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClient).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 464);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 60);
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
            btnAdd.Location = new Point(237, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.BackgroundColor = Color.IndianRed;
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 10;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(435, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.RoyalBlue;
            btnEdit.BackgroundColor = Color.RoyalBlue;
            btnEdit.BorderColor = Color.PaleVioletRed;
            btnEdit.BorderRadius = 10;
            btnEdit.BorderSize = 0;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(633, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 30);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Editar";
            btnEdit.TextColor = Color.White;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 60);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 0;
            label1.Text = "Clientes Registrados";
            // 
            // dgvClient
            // 
            dgvClient.BackgroundColor = Color.White;
            dgvClient.BorderStyle = BorderStyle.None;
            dgvClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClient.Dock = DockStyle.Fill;
            dgvClient.Location = new Point(0, 0);
            dgvClient.Name = "dgvClient";
            dgvClient.RowTemplate.Height = 25;
            dgvClient.Size = new Size(1000, 404);
            dgvClient.TabIndex = 6;
            dgvClient.CellClick += dgvClient_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvClient);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 404);
            panel3.TabIndex = 9;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 524);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClientes";
            Text = "frmUbiAlmacenes";
            Load += frmClientes_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClient).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private CustomControls.RJControls.RJButton btnAdd;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton btnEdit;
        private Panel panel1;
        private Label label1;
        private DataGridView dgvClient;
        private Panel panel3;
    }
}