namespace Vista
{
    partial class frmAppLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppLogin));
            txtUser = new CustomControls.RJControls.RJTextBox();
            txtPassword = new CustomControls.RJControls.RJTextBox();
            btnLogin = new CustomControls.RJControls.RJButton();
            lblErrorLogin = new Label();
            lblTitle = new Label();
            btnExit = new PictureBox();
            btnMinus = new PictureBox();
            lblForgot = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.MidnightBlue;
            txtUser.BorderColor = Color.White;
            txtUser.BorderFocusColor = Color.White;
            txtUser.BorderRadius = 0;
            txtUser.BorderSize = 2;
            txtUser.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(414, 134);
            txtUser.Margin = new Padding(4);
            txtUser.Multiline = false;
            txtUser.Name = "txtUser";
            txtUser.Padding = new Padding(10, 7, 10, 7);
            txtUser.PasswordChar = false;
            txtUser.PlaceholderColor = Color.DarkGray;
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(250, 33);
            txtUser.TabIndex = 10;
            txtUser.Texts = "";
            txtUser.UnderlinedStyle = true;
            txtUser._TextChanged += txtUser__TextChanged;
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.MidnightBlue;
            txtPassword.BorderColor = Color.GhostWhite;
            txtPassword.BorderFocusColor = Color.White;
            txtPassword.BorderRadius = 0;
            txtPassword.BorderSize = 2;
            txtPassword.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(414, 184);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(10, 7, 10, 7);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(250, 33);
            txtPassword.TabIndex = 11;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = true;
            txtPassword._TextChanged += txtPassword__TextChanged;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MidnightBlue;
            btnLogin.BackgroundColor = Color.MidnightBlue;
            btnLogin.BorderColor = Color.GhostWhite;
            btnLogin.BorderRadius = 18;
            btnLogin.BorderSize = 1;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(414, 276);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 35);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorLogin
            // 
            lblErrorLogin.AutoSize = true;
            lblErrorLogin.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorLogin.ForeColor = Color.FromArgb(255, 128, 128);
            lblErrorLogin.Location = new Point(414, 233);
            lblErrorLogin.Name = "lblErrorLogin";
            lblErrorLogin.Size = new Size(183, 15);
            lblErrorLogin.TabIndex = 14;
            lblErrorLogin.Text = "*Usuario o Contraseña Incorrecto";
            lblErrorLogin.Visible = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(448, 68);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(189, 30);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Inicio de Sesión";
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.Close;
            btnExit.Location = new Point(681, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(20, 20);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 18;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // btnMinus
            // 
            btnMinus.Image = Properties.Resources.Minimizar;
            btnMinus.Location = new Point(655, 0);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(20, 20);
            btnMinus.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinus.TabIndex = 19;
            btnMinus.TabStop = false;
            btnMinus.Click += btnMinus_Click;
            btnMinus.MouseEnter += btnMinus_MouseEnter;
            btnMinus.MouseLeave += btnMinus_MouseLeave;
            // 
            // lblForgot
            // 
            lblForgot.AutoSize = true;
            lblForgot.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblForgot.ForeColor = Color.CornflowerBlue;
            lblForgot.Location = new Point(448, 324);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(191, 20);
            lblForgot.TabIndex = 20;
            lblForgot.Text = "¿Olvidaste tu Contraseña?";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.MidnightBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.Location = new Point(375, 134);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 21;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.MidnightBlue;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox2.Location = new Point(375, 185);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 22;
            iconPictureBox2.TabStop = false;
            // 
            // frmAppLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(700, 449);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(lblForgot);
            Controls.Add(btnMinus);
            Controls.Add(btnExit);
            Controls.Add(lblTitle);
            Controls.Add(lblErrorLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAppLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppLogin";
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinus).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.RJControls.RJTextBox txtUser;
        private CustomControls.RJControls.RJTextBox txtPassword;
        private CustomControls.RJControls.RJButton btnLogin;
        private Label lblErrorLogin;
        private Label lblTitle;
        private PictureBox btnExit;
        private PictureBox btnMinus;
        private Label lblForgot;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}