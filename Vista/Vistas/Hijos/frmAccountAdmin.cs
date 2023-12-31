﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Vistas.Nietos;
using Vista.Vistas.Nietos.Admin;

namespace Vista.Vistas.Hijos
{
    public partial class frmAccountAdmin : Form
    {
        private IconButton btnSelection;
        private Panel BordInf;

        private void Inicio()
        {
            ActiveButton(btnAllUser);
            AbrirFormInPanel(new frmUsers());
        }
        public frmAccountAdmin()
        {
            InitializeComponent();
            BordInf = new Panel();
            BordInf.Size = new Size(150, 5);
            plOptions.Controls.Add(BordInf);
            Inicio();
        }
        private void ActiveButton(object button)
        {
            if (button != null)
            {
                DesactiveButton();
                btnSelection = (IconButton)button;
                btnSelection.ForeColor = Color.CornflowerBlue;
                btnSelection.IconColor = Color.CornflowerBlue;
                BordInf.BackColor = Color.CornflowerBlue;
                BordInf.Location = new Point(btnSelection.Location.X, 49);
                BordInf.Visible = true;
                BordInf.BringToFront();
            }
        }
        private void DesactiveButton()
        {
            if (btnSelection != null)
            {
                btnSelection.ForeColor = Color.DimGray;
                btnSelection.IconColor = Color.DimGray;
            }
        }
        public void AbrirFormInPanel(object FormNieto)
        {
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            Form fh = (Form)FormNieto;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fh);
            this.plContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void btnAllUser_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActiveButton(btnClientes);
            AbrirFormInPanel(new frmClientes());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActiveButton(btnProveedores);
            AbrirFormInPanel(new frmProveedores());
        }
    }
}
