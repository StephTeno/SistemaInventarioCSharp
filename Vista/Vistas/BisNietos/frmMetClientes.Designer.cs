using MaterialSkin.Controls;

namespace Vista.Vistas.BisNietos
{
    partial class frmMetClientes
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
            btnDelete = new CustomControls.RJControls.RJButton();
            btnAdd = new CustomControls.RJControls.RJButton();
            btnEdit = new CustomControls.RJControls.RJButton();
            materialCard2 = new MaterialCard();
            lblECo = new Label();
            lblECe = new Label();
            label7 = new Label();
            label6 = new Label();
            txtCelular = new CustomControls.RJControls.RJTextBox();
            txtCorreo = new CustomControls.RJControls.RJTextBox();
            materialCard1 = new MaterialCard();
            txtSAp = new CustomControls.RJControls.RJTextBox();
            txtPAp = new CustomControls.RJControls.RJTextBox();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            txtSNom = new CustomControls.RJControls.RJTextBox();
            txtPNom = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            txtCedula = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            label2 = new Label();
            cmbLocalidad = new Controles_personalizados.RJComboBox();
            label1 = new Label();
            label8 = new Label();
            panel2.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
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
            panel2.TabIndex = 17;
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
            materialCard2.Location = new Point(23, 319);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(764, 100);
            materialCard2.TabIndex = 16;
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
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(txtSAp);
            materialCard1.Controls.Add(txtPAp);
            materialCard1.Controls.Add(label10);
            materialCard1.Controls.Add(label11);
            materialCard1.Controls.Add(label9);
            materialCard1.Controls.Add(txtSNom);
            materialCard1.Controls.Add(txtPNom);
            materialCard1.Controls.Add(label4);
            materialCard1.Controls.Add(txtCedula);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(cmbLocalidad);
            materialCard1.Controls.Add(label1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(23, 76);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(764, 200);
            materialCard1.TabIndex = 15;
            // 
            // txtSAp
            // 
            txtSAp.BackColor = SystemColors.Window;
            txtSAp.BorderColor = Color.CornflowerBlue;
            txtSAp.BorderFocusColor = Color.HotPink;
            txtSAp.BorderRadius = 0;
            txtSAp.BorderSize = 2;
            txtSAp.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSAp.ForeColor = Color.FromArgb(64, 64, 64);
            txtSAp.Location = new Point(529, 71);
            txtSAp.Margin = new Padding(4);
            txtSAp.Multiline = false;
            txtSAp.Name = "txtSAp";
            txtSAp.Padding = new Padding(10, 7, 10, 7);
            txtSAp.PasswordChar = false;
            txtSAp.PlaceholderColor = Color.DarkGray;
            txtSAp.PlaceholderText = "";
            txtSAp.Size = new Size(200, 32);
            txtSAp.TabIndex = 14;
            txtSAp.Texts = "";
            txtSAp.UnderlinedStyle = false;
            // 
            // txtPAp
            // 
            txtPAp.BackColor = SystemColors.Window;
            txtPAp.BorderColor = Color.CornflowerBlue;
            txtPAp.BorderFocusColor = Color.HotPink;
            txtPAp.BorderRadius = 0;
            txtPAp.BorderSize = 2;
            txtPAp.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPAp.ForeColor = Color.FromArgb(64, 64, 64);
            txtPAp.Location = new Point(529, 21);
            txtPAp.Margin = new Padding(4);
            txtPAp.Multiline = false;
            txtPAp.Name = "txtPAp";
            txtPAp.Padding = new Padding(10, 7, 10, 7);
            txtPAp.PasswordChar = false;
            txtPAp.PlaceholderColor = Color.DarkGray;
            txtPAp.PlaceholderText = "";
            txtPAp.Size = new Size(200, 32);
            txtPAp.TabIndex = 13;
            txtPAp.Texts = "";
            txtPAp.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(381, 77);
            label10.Name = "label10";
            label10.Size = new Size(141, 20);
            label10.TabIndex = 16;
            label10.Text = "Segundo Nombre:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(401, 27);
            label11.Name = "label11";
            label11.Size = new Size(121, 20);
            label11.TabIndex = 15;
            label11.Text = "Primer Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(613, 154);
            label9.Name = "label9";
            label9.Size = new Size(45, 17);
            label9.TabIndex = 12;
            label9.Text = "label9";
            // 
            // txtSNom
            // 
            txtSNom.BackColor = SystemColors.Window;
            txtSNom.BorderColor = Color.CornflowerBlue;
            txtSNom.BorderFocusColor = Color.HotPink;
            txtSNom.BorderRadius = 0;
            txtSNom.BorderSize = 2;
            txtSNom.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSNom.ForeColor = Color.FromArgb(64, 64, 64);
            txtSNom.Location = new Point(152, 71);
            txtSNom.Margin = new Padding(4);
            txtSNom.Multiline = false;
            txtSNom.Name = "txtSNom";
            txtSNom.Padding = new Padding(10, 7, 10, 7);
            txtSNom.PasswordChar = false;
            txtSNom.PlaceholderColor = Color.DarkGray;
            txtSNom.PlaceholderText = "";
            txtSNom.Size = new Size(200, 32);
            txtSNom.TabIndex = 1;
            txtSNom.Texts = "";
            txtSNom.UnderlinedStyle = false;
            // 
            // txtPNom
            // 
            txtPNom.BackColor = SystemColors.Window;
            txtPNom.BorderColor = Color.CornflowerBlue;
            txtPNom.BorderFocusColor = Color.HotPink;
            txtPNom.BorderRadius = 0;
            txtPNom.BorderSize = 2;
            txtPNom.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPNom.ForeColor = Color.FromArgb(64, 64, 64);
            txtPNom.Location = new Point(152, 21);
            txtPNom.Margin = new Padding(4);
            txtPNom.Multiline = false;
            txtPNom.Name = "txtPNom";
            txtPNom.Padding = new Padding(10, 7, 10, 7);
            txtPNom.PasswordChar = false;
            txtPNom.PlaceholderColor = Color.DarkGray;
            txtPNom.PlaceholderText = "";
            txtPNom.Size = new Size(200, 32);
            txtPNom.TabIndex = 0;
            txtPNom.Texts = "";
            txtPNom.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(420, 127);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 10;
            label4.Text = "Ubicación:";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = SystemColors.Window;
            txtCedula.BorderColor = Color.CornflowerBlue;
            txtCedula.BorderFocusColor = Color.HotPink;
            txtCedula.BorderRadius = 0;
            txtCedula.BorderSize = 2;
            txtCedula.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCedula.ForeColor = Color.FromArgb(64, 64, 64);
            txtCedula.Location = new Point(102, 122);
            txtCedula.Margin = new Padding(4);
            txtCedula.Multiline = false;
            txtCedula.Name = "txtCedula";
            txtCedula.Padding = new Padding(10, 7, 10, 7);
            txtCedula.PasswordChar = false;
            txtCedula.PlaceholderColor = Color.DarkGray;
            txtCedula.PlaceholderText = "";
            txtCedula.Size = new Size(250, 32);
            txtCedula.TabIndex = 2;
            txtCedula.Texts = "";
            txtCedula.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 128);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 9;
            label3.Text = "Cedula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 77);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 8;
            label2.Text = "Segundo Nombre:";
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
            cmbLocalidad.Location = new Point(531, 122);
            cmbLocalidad.MinimumSize = new Size(200, 30);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Padding = new Padding(1);
            cmbLocalidad.Size = new Size(200, 30);
            cmbLocalidad.TabIndex = 4;
            cmbLocalidad.Texts = "";
            cmbLocalidad.OnSelectedIndexChanged += cmbLocalidad_OnSelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 7;
            label1.Text = "Primer Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(325, 17);
            label8.Name = "label8";
            label8.Size = new Size(128, 32);
            label8.TabIndex = 18;
            label8.Text = "CLIENTES";
            // 
            // frmMetClientes
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
            Name = "frmMetClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMetClientes_Load;
            panel2.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton btnAdd;
        private CustomControls.RJControls.RJButton btnEdit;
        private MaterialCard materialCard2;
        private Label lblECo;
        private Label lblECe;
        private Label label7;
        private Label label6;
        private CustomControls.RJControls.RJTextBox txtCelular;
        private CustomControls.RJControls.RJTextBox txtCorreo;
        private MaterialCard materialCard1;
        private Label label9;
        private CustomControls.RJControls.RJTextBox txtSNom;
        private Label label5;
        private CustomControls.RJControls.RJTextBox txtPNom;
        private Label label4;
        private CustomControls.RJControls.RJTextBox txtCedula;
        private Label label3;
        private Label label2;
        private Controles_personalizados.RJComboBox cmbLocalidad;
        private Label label1;
        private Label label8;
        private CustomControls.RJControls.RJTextBox txtSAp;
        private CustomControls.RJControls.RJTextBox txtPAp;
        private Label label10;
        private Label label11;
        private Controles_personalizados.RJComboBox cmbActive;
        private Label label12;
    }
}