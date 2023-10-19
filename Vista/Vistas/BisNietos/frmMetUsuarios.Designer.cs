namespace Vista.Vistas.BisNietos
{
    partial class frmMetUsuarios
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
            txtUser = new CustomControls.RJControls.RJTextBox();
            txtContrasena = new CustomControls.RJControls.RJTextBox();
            cbCargo = new Controles_personalizados.RJComboBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            btnDelete = new CustomControls.RJControls.RJButton();
            btnAdd = new CustomControls.RJControls.RJButton();
            btnEdit = new CustomControls.RJControls.RJButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.Window;
            txtUser.BorderColor = Color.CornflowerBlue;
            txtUser.BorderFocusColor = Color.HotPink;
            txtUser.BorderRadius = 0;
            txtUser.BorderSize = 2;
            txtUser.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.FromArgb(64, 64, 64);
            txtUser.Location = new Point(28, 125);
            txtUser.Margin = new Padding(4);
            txtUser.Multiline = false;
            txtUser.Name = "txtUser";
            txtUser.Padding = new Padding(10, 7, 10, 7);
            txtUser.PasswordChar = false;
            txtUser.PlaceholderColor = Color.DarkGray;
            txtUser.PlaceholderText = "Username";
            txtUser.Size = new Size(250, 31);
            txtUser.TabIndex = 0;
            txtUser.Texts = "";
            txtUser.UnderlinedStyle = true;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = SystemColors.Window;
            txtContrasena.BorderColor = Color.CornflowerBlue;
            txtContrasena.BorderFocusColor = Color.HotPink;
            txtContrasena.BorderRadius = 0;
            txtContrasena.BorderSize = 2;
            txtContrasena.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            txtContrasena.Location = new Point(321, 125);
            txtContrasena.Margin = new Padding(4);
            txtContrasena.Multiline = false;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(10, 7, 10, 7);
            txtContrasena.PasswordChar = false;
            txtContrasena.PlaceholderColor = Color.DarkGray;
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.Size = new Size(250, 31);
            txtContrasena.TabIndex = 1;
            txtContrasena.Texts = "";
            txtContrasena.UnderlinedStyle = true;
            // 
            // cbCargo
            // 
            cbCargo.BackColor = Color.White;
            cbCargo.BorderColor = Color.RoyalBlue;
            cbCargo.BorderSize = 1;
            cbCargo.DropDownStyle = ComboBoxStyle.DropDown;
            cbCargo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCargo.ForeColor = Color.Black;
            cbCargo.IconColor = Color.RoyalBlue;
            cbCargo.ListBackColor = Color.White;
            cbCargo.ListTextColor = Color.DimGray;
            cbCargo.Location = new Point(28, 180);
            cbCargo.MinimumSize = new Size(200, 30);
            cbCargo.Name = "cbCargo";
            cbCargo.Padding = new Padding(1);
            cbCargo.Size = new Size(250, 30);
            cbCargo.TabIndex = 2;
            cbCargo.Texts = "Cargo";
            cbCargo.OnSelectedIndexChanged += cbCargo_OnSelectedIndexChanged;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.MidnightBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = Color.MidnightBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 100;
            iconPictureBox1.Location = new Point(243, 21);
            iconPictureBox1.Margin = new Padding(0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(100, 100);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnEdit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 60);
            panel2.TabIndex = 6;
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
            btnDelete.Location = new Point(497, 18);
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
            btnAdd.Location = new Point(243, 18);
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
            btnEdit.Location = new Point(394, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 30);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Editar";
            btnEdit.TextColor = Color.White;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 193);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // frmMetUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 300);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(iconPictureBox1);
            Controls.Add(cbCargo);
            Controls.Add(txtContrasena);
            Controls.Add(txtUser);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMetUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MetUsuarios";
            Load += MetUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtUser;
        private CustomControls.RJControls.RJTextBox txtContrasena;
        private Controles_personalizados.RJComboBox cbCargo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private CustomControls.RJControls.RJButton btnAdd;
        private CustomControls.RJControls.RJButton btnEdit;
        private CustomControls.RJControls.RJButton btnDelete;
        private Label label1;
    }
}