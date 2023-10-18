namespace Vista.Vistas.Hijos
{
    partial class frmHistory
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
            plBotones = new Panel();
            dgvHistory = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnSig = new FontAwesome.Sharp.IconButton();
            btnBack = new FontAwesome.Sharp.IconButton();
            plTitle.SuspendLayout();
            plTitles.SuspendLayout();
            plBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // plTitle
            // 
            plTitle.Controls.Add(plTitles);
            plTitle.Dock = DockStyle.Top;
            plTitle.Location = new Point(0, 0);
            plTitle.Name = "plTitle";
            plTitle.Size = new Size(1000, 57);
            plTitle.TabIndex = 0;
            // 
            // plTitles
            // 
            plTitles.Controls.Add(label1);
            plTitles.Dock = DockStyle.Left;
            plTitles.Location = new Point(0, 0);
            plTitles.Name = "plTitles";
            plTitles.Size = new Size(338, 57);
            plTitles.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(325, 33);
            label1.TabIndex = 0;
            label1.Text = "Historial de Actividades";
            // 
            // plBotones
            // 
            plBotones.Controls.Add(btnBack);
            plBotones.Controls.Add(iconButton1);
            plBotones.Controls.Add(btnSig);
            plBotones.Dock = DockStyle.Top;
            plBotones.Location = new Point(0, 57);
            plBotones.Name = "plBotones";
            plBotones.Size = new Size(1000, 35);
            plBotones.TabIndex = 1;
            // 
            // dgvHistory
            // 
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(0, 92);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowTemplate.Height = 25;
            dgvHistory.Size = new Size(1000, 532);
            dgvHistory.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.RoyalBlue;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(930, 0);
            iconButton1.Margin = new Padding(3, 3, 10, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(35, 35);
            iconButton1.TabIndex = 7;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Visible = false;
            // 
            // btnSig
            // 
            btnSig.Dock = DockStyle.Right;
            btnSig.FlatAppearance.BorderSize = 0;
            btnSig.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btnSig.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnSig.FlatStyle = FlatStyle.Flat;
            btnSig.ForeColor = Color.White;
            btnSig.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            btnSig.IconColor = Color.RoyalBlue;
            btnSig.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSig.IconSize = 25;
            btnSig.Location = new Point(965, 0);
            btnSig.Margin = new Padding(10, 3, 3, 3);
            btnSig.Name = "btnSig";
            btnSig.Size = new Size(35, 35);
            btnSig.TabIndex = 6;
            btnSig.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Right;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btnBack.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnBack.IconColor = Color.RoyalBlue;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnBack.IconSize = 25;
            btnBack.Location = new Point(895, 0);
            btnBack.Margin = new Padding(3, 3, 10, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(35, 35);
            btnBack.TabIndex = 8;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // frmHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 624);
            Controls.Add(dgvHistory);
            Controls.Add(plBotones);
            Controls.Add(plTitle);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistory";
            Text = "frmHistory";
            plTitle.ResumeLayout(false);
            plTitles.ResumeLayout(false);
            plTitles.PerformLayout();
            plBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel plTitle;
        private Panel plTitles;
        private Label label1;
        private Panel plBotones;
        private DataGridView dgvHistory;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnSig;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}