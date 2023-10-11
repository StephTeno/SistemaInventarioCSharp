namespace Vista.Vistas.Hijos
{
    partial class frmAccountAdmin
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
            plOptions = new Panel();
            btnDeleteUser = new FontAwesome.Sharp.IconButton();
            btnEditUser = new FontAwesome.Sharp.IconButton();
            btnAddUser = new FontAwesome.Sharp.IconButton();
            btnAllUser = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            plTitle.SuspendLayout();
            plOptions.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // plTitle
            // 
            plTitle.Controls.Add(panel1);
            plTitle.Dock = DockStyle.Top;
            plTitle.Location = new Point(0, 0);
            plTitle.Name = "plTitle";
            plTitle.Size = new Size(1000, 50);
            plTitle.TabIndex = 0;
            // 
            // plOptions
            // 
            plOptions.Controls.Add(btnDeleteUser);
            plOptions.Controls.Add(btnEditUser);
            plOptions.Controls.Add(btnAddUser);
            plOptions.Controls.Add(btnAllUser);
            plOptions.Dock = DockStyle.Top;
            plOptions.Location = new Point(0, 50);
            plOptions.Name = "plOptions";
            plOptions.Size = new Size(1000, 50);
            plOptions.TabIndex = 1;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Dock = DockStyle.Left;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteUser.ForeColor = Color.DimGray;
            btnDeleteUser.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            btnDeleteUser.IconColor = Color.DimGray;
            btnDeleteUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteUser.IconSize = 25;
            btnDeleteUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteUser.Location = new Point(450, 0);
            btnDeleteUser.Margin = new Padding(5);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Padding = new Padding(5, 0, 10, 0);
            btnDeleteUser.Size = new Size(150, 50);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Eliminar Usuario";
            btnDeleteUser.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Dock = DockStyle.Left;
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditUser.ForeColor = Color.DimGray;
            btnEditUser.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnEditUser.IconColor = Color.DimGray;
            btnEditUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditUser.IconSize = 25;
            btnEditUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditUser.Location = new Point(300, 0);
            btnEditUser.Margin = new Padding(5);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Padding = new Padding(5, 0, 10, 0);
            btnEditUser.Size = new Size(150, 50);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "Editar Usuario";
            btnEditUser.TextAlign = ContentAlignment.MiddleRight;
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Dock = DockStyle.Left;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUser.ForeColor = Color.DimGray;
            btnAddUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnAddUser.IconColor = Color.DimGray;
            btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddUser.IconSize = 25;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(150, 0);
            btnAddUser.Margin = new Padding(5);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Padding = new Padding(5, 0, 10, 0);
            btnAddUser.Size = new Size(150, 50);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Agregar Usuario";
            btnAddUser.TextAlign = ContentAlignment.MiddleRight;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnAllUser
            // 
            btnAllUser.Dock = DockStyle.Left;
            btnAllUser.FlatAppearance.BorderSize = 0;
            btnAllUser.FlatStyle = FlatStyle.Flat;
            btnAllUser.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllUser.ForeColor = Color.DimGray;
            btnAllUser.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnAllUser.IconColor = Color.DimGray;
            btnAllUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAllUser.IconSize = 25;
            btnAllUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAllUser.Location = new Point(0, 0);
            btnAllUser.Margin = new Padding(5);
            btnAllUser.Name = "btnAllUser";
            btnAllUser.Padding = new Padding(5, 0, 10, 0);
            btnAllUser.Size = new Size(150, 50);
            btnAllUser.TabIndex = 0;
            btnAllUser.Text = "Usuarios Admin";
            btnAllUser.TextAlign = ContentAlignment.MiddleRight;
            btnAllUser.UseVisualStyleBackColor = true;
            btnAllUser.Click += btnAllUser_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 50);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(226, 33);
            label1.TabIndex = 0;
            label1.Text = "Administradores";
            // 
            // frmAccountAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 624);
            Controls.Add(plOptions);
            Controls.Add(plTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAccountAdmin";
            Text = "frmAccountAdmin";
            plTitle.ResumeLayout(false);
            plOptions.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel plTitle;
        private Panel plOptions;
        private FontAwesome.Sharp.IconButton btnEditUser;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private FontAwesome.Sharp.IconButton btnAllUser;
        private FontAwesome.Sharp.IconButton btnDeleteUser;
        private Panel panel1;
        private Label label1;
    }
}