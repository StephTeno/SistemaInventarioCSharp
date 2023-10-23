using FontAwesome.Sharp;

namespace Vista.Vistas.BisNietos
{
    partial class frmMetProveedores
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
            txtRUC = new CustomControls.RJControls.RJTextBox();
            txtEmpresa = new CustomControls.RJControls.RJTextBox();
            txtRepresentante = new CustomControls.RJControls.RJTextBox();
            txtCargo = new CustomControls.RJControls.RJTextBox();
            cmbLocalidad = new Controles_personalizados.RJComboBox();
            txtCorreo = new CustomControls.RJControls.RJTextBox();
            txtCelular = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label9 = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            lblECo = new Label();
            lblECe = new Label();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            btnDelete = new CustomControls.RJControls.RJButton();
            btnAdd = new CustomControls.RJControls.RJButton();
            btnEdit = new CustomControls.RJControls.RJButton();
            label8 = new Label();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtRUC
            // 
            txtRUC.BackColor = SystemColors.Window;
            txtRUC.BorderColor = Color.CornflowerBlue;
            txtRUC.BorderFocusColor = Color.HotPink;
            txtRUC.BorderRadius = 0;
            txtRUC.BorderSize = 2;
            txtRUC.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRUC.ForeColor = Color.FromArgb(64, 64, 64);
            txtRUC.Location = new Point(105, 21);
            txtRUC.Margin = new Padding(4);
            txtRUC.Multiline = false;
            txtRUC.Name = "txtRUC";
            txtRUC.Padding = new Padding(10, 7, 10, 7);
            txtRUC.PasswordChar = false;
            txtRUC.PlaceholderColor = Color.DarkGray;
            txtRUC.PlaceholderText = "";
            txtRUC.Size = new Size(250, 32);
            txtRUC.TabIndex = 0;
            txtRUC.Texts = "";
            txtRUC.UnderlinedStyle = false;
            // 
            // txtEmpresa
            // 
            txtEmpresa.BackColor = SystemColors.Window;
            txtEmpresa.BorderColor = Color.CornflowerBlue;
            txtEmpresa.BorderFocusColor = Color.HotPink;
            txtEmpresa.BorderRadius = 0;
            txtEmpresa.BorderSize = 2;
            txtEmpresa.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpresa.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmpresa.Location = new Point(496, 21);
            txtEmpresa.Margin = new Padding(4);
            txtEmpresa.Multiline = false;
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Padding = new Padding(10, 7, 10, 7);
            txtEmpresa.PasswordChar = false;
            txtEmpresa.PlaceholderColor = Color.DarkGray;
            txtEmpresa.PlaceholderText = "";
            txtEmpresa.Size = new Size(250, 32);
            txtEmpresa.TabIndex = 1;
            txtEmpresa.Texts = "";
            txtEmpresa.UnderlinedStyle = false;
            // 
            // txtRepresentante
            // 
            txtRepresentante.BackColor = SystemColors.Window;
            txtRepresentante.BorderColor = Color.CornflowerBlue;
            txtRepresentante.BorderFocusColor = Color.HotPink;
            txtRepresentante.BorderRadius = 0;
            txtRepresentante.BorderSize = 2;
            txtRepresentante.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepresentante.ForeColor = Color.FromArgb(64, 64, 64);
            txtRepresentante.Location = new Point(152, 92);
            txtRepresentante.Margin = new Padding(4);
            txtRepresentante.Multiline = false;
            txtRepresentante.Name = "txtRepresentante";
            txtRepresentante.Padding = new Padding(10, 7, 10, 7);
            txtRepresentante.PasswordChar = false;
            txtRepresentante.PlaceholderColor = Color.DarkGray;
            txtRepresentante.PlaceholderText = "";
            txtRepresentante.Size = new Size(250, 32);
            txtRepresentante.TabIndex = 2;
            txtRepresentante.Texts = "";
            txtRepresentante.UnderlinedStyle = false;
            // 
            // txtCargo
            // 
            txtCargo.BackColor = SystemColors.Window;
            txtCargo.BorderColor = Color.CornflowerBlue;
            txtCargo.BorderFocusColor = Color.HotPink;
            txtCargo.BorderRadius = 0;
            txtCargo.BorderSize = 2;
            txtCargo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCargo.Location = new Point(203, 161);
            txtCargo.Margin = new Padding(4);
            txtCargo.Multiline = false;
            txtCargo.Name = "txtCargo";
            txtCargo.Padding = new Padding(10, 7, 10, 7);
            txtCargo.PasswordChar = false;
            txtCargo.PlaceholderColor = Color.DarkGray;
            txtCargo.PlaceholderText = "";
            txtCargo.Size = new Size(250, 32);
            txtCargo.TabIndex = 3;
            txtCargo.Texts = "";
            txtCargo.UnderlinedStyle = false;
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.BackColor = Color.WhiteSmoke;
            cmbLocalidad.BorderColor = Color.CornflowerBlue;
            cmbLocalidad.BorderSize = 1;
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDown;
            cmbLocalidad.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbLocalidad.ForeColor = Color.DimGray;
            cmbLocalidad.IconColor = Color.CornflowerBlue;
            cmbLocalidad.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbLocalidad.ListTextColor = Color.DimGray;
            cmbLocalidad.Location = new Point(546, 94);
            cmbLocalidad.MinimumSize = new Size(200, 30);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Padding = new Padding(1);
            cmbLocalidad.Size = new Size(200, 30);
            cmbLocalidad.TabIndex = 4;
            cmbLocalidad.Texts = "";
            cmbLocalidad.OnSelectedIndexChanged += cmbLocalidad_OnSelectedIndexChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.Window;
            txtCorreo.BorderColor = Color.CornflowerBlue;
            txtCorreo.BorderFocusColor = Color.HotPink;
            txtCorreo.BorderRadius = 0;
            txtCorreo.BorderSize = 2;
            txtCorreo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCorreo.Location = new Point(435, 50);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(10, 7, 10, 7);
            txtCorreo.PasswordChar = false;
            txtCorreo.PlaceholderColor = Color.DarkGray;
            txtCorreo.PlaceholderText = "";
            txtCorreo.Size = new Size(250, 32);
            txtCorreo.TabIndex = 5;
            txtCorreo.Texts = "";
            txtCorreo.UnderlinedStyle = false;
            // 
            // txtCelular
            // 
            txtCelular.BackColor = SystemColors.Window;
            txtCelular.BorderColor = Color.CornflowerBlue;
            txtCelular.BorderFocusColor = Color.HotPink;
            txtCelular.BorderRadius = 0;
            txtCelular.BorderSize = 2;
            txtCelular.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.ForeColor = Color.FromArgb(64, 64, 64);
            txtCelular.Location = new Point(51, 50);
            txtCelular.Margin = new Padding(4);
            txtCelular.Multiline = false;
            txtCelular.Name = "txtCelular";
            txtCelular.Padding = new Padding(10, 7, 10, 7);
            txtCelular.PasswordChar = false;
            txtCelular.PlaceholderColor = Color.DarkGray;
            txtCelular.PlaceholderText = "";
            txtCelular.Size = new Size(250, 32);
            txtCelular.TabIndex = 6;
            txtCelular.Texts = "";
            txtCelular.UnderlinedStyle = false;
            txtCelular._TextChanged += txtCelular__TextChanged;
            txtCelular.KeyPress += txtCelular_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 7;
            label1.Text = "RUC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(403, 27);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 98);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 9;
            label3.Text = "Representante:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(435, 99);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 10;
            label4.Text = "Ubicación:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 167);
            label5.Name = "label5";
            label5.Size = new Size(172, 20);
            label5.TabIndex = 11;
            label5.Text = "Cargo Representante:";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label9);
            materialCard1.Controls.Add(txtEmpresa);
            materialCard1.Controls.Add(label5);
            materialCard1.Controls.Add(txtRUC);
            materialCard1.Controls.Add(label4);
            materialCard1.Controls.Add(txtRepresentante);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(txtCargo);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(cmbLocalidad);
            materialCard1.Controls.Add(label1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(23, 74);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(764, 214);
            materialCard1.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(589, 147);
            label9.Name = "label9";
            label9.Size = new Size(45, 17);
            label9.TabIndex = 12;
            label9.Text = "label9";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lblECo);
            materialCard2.Controls.Add(lblECe);
            materialCard2.Controls.Add(label7);
            materialCard2.Controls.Add(label6);
            materialCard2.Controls.Add(txtCelular);
            materialCard2.Controls.Add(txtCorreo);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(23, 329);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(764, 100);
            materialCard2.TabIndex = 13;
            // 
            // lblECo
            // 
            lblECo.AutoSize = true;
            lblECo.ForeColor = Color.Red;
            lblECo.Location = new Point(687, 60);
            lblECo.Name = "lblECo";
            lblECo.Size = new Size(73, 17);
            lblECo.TabIndex = 11;
            lblECo.Text = "*No Valido";
            lblECo.Visible = false;
            // 
            // lblECe
            // 
            lblECe.AutoSize = true;
            lblECe.ForeColor = Color.Red;
            lblECe.Location = new Point(302, 60);
            lblECe.Name = "lblECe";
            lblECe.Size = new Size(88, 17);
            lblECe.TabIndex = 10;
            lblECe.Text = "*Usa 8 digitos";
            lblECe.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(486, 17);
            label7.Name = "label7";
            label7.Size = new Size(148, 20);
            label7.TabIndex = 9;
            label7.Text = "Correo Electrónico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(133, 17);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 8;
            label6.Text = "No Celular";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnEdit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 460);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 60);
            panel2.TabIndex = 14;
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
            btnDelete.Location = new Point(698, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Eliminar";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
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
            btnAdd.Location = new Point(376, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
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
            btnEdit.Location = new Point(595, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 30);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Editar";
            btnEdit.TextColor = Color.White;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(299, 19);
            label8.Name = "label8";
            label8.Size = new Size(201, 32);
            label8.TabIndex = 15;
            label8.Text = "PROVEEDORES";
            // 
            // frmMetProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(810, 520);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMetProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMetProveedores";
            Load += frmMetProveedores_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtRUC;
        private CustomControls.RJControls.RJTextBox txtEmpresa;
        private CustomControls.RJControls.RJTextBox txtRepresentante;
        private CustomControls.RJControls.RJTextBox txtCargo;
        private Controles_personalizados.RJComboBox cmbLocalidad;
        private CustomControls.RJControls.RJTextBox txtCorreo;
        private CustomControls.RJControls.RJTextBox txtCelular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label label7;
        private Label label6;
        private Panel panel2;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton btnAdd;
        private CustomControls.RJControls.RJButton btnEdit;
        private Label label8;
        private Label lblECe;
        private Label lblECo;
        private Label label9;
    }
}