using CONTROLLER;
using CONTROLLER.Repositorios;
using MODELO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Vistas.BisNietos;

namespace Vista.Vistas.Nietos.Admin
{
    public partial class frmProveedores : Form
    {
        ControllerProveedor p = new ControllerProveedor();
        Proveedore pr = new Proveedore();
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            p.RellenarData(dgvProv);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMetProveedores m = new frmMetProveedores(btnAdd.Text);
            m.ShowDialog();
            p.RellenarData(dgvProv);
        }

        private void dgvProv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProv.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    string id = row.Cells[0].Value.ToString();
                    pr = p.Encontrar(id);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMetProveedores m = new frmMetProveedores(btnDelete.Text);
            m.pr = pr;
            m.ShowDialog();
            p.RellenarData(dgvProv);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmMetProveedores m = new frmMetProveedores(btnEdit.Text);
            m.pr = pr;
            m.ShowDialog();
            p.RellenarData(dgvProv);
        }
    }
}
