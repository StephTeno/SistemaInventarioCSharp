﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Vistas.Hijos;

namespace Vista.HOME
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.RoyalBlue;
        }

        private void btnMinus_MouseEnter(object sender, EventArgs e)
        {
            btnMinus.BackColor = Color.RoyalBlue;
        }

        private void btnMinus_MouseLeave(object sender, EventArgs e)
        {
            btnMinus.BackColor = Color.RoyalBlue;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.RoyalBlue;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            AbrirFormInPanel(new frmDashboard());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (flpSidebar.Width == 200)
            {
                flpSidebar.Width = 70;
                Separador1.Width = 70;
                Separador2.Width = 70;
            }
            else
            {
                flpSidebar.Width = 200;
                Separador1.Width = 200;
                Separador2.Width = 200;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
        }

        private void btnCloseSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AbrirFormInPanel(object FormHijo)
        {
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            Form fh = (Form)FormHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fh);
            this.plContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmDashboard());
        }

        private void btnManageAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmAccountAdmin());
        }
    }
}