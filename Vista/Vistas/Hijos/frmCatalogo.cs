using CONTROLLER;
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

namespace Vista.Vistas.Hijos
{
    public partial class frmCatalogo : Form
    {
        Producto p = new Producto();
        string id;
        ControllerProd c = new ControllerProd();
        public frmCatalogo()
        {
            InitializeComponent();
        }

        public void LlenarTextBox()
        {
            txtCodigo.Texts = p.IdProd;
            txtpre.Texts = p.PreVenta.ToString();
            txtPro.Texts = p.NombreProd;
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            c.RellenarData(dgvProductos);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = row.Cells[0].Value.ToString();
                    p = c.Encontrar(id);
                }
            }
            LlenarTextBox();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            p = c.Encontrar(rjTextBox1.Texts);
            LlenarTextBox();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            p = c.Encontrar(rjTextBox1.Texts);
            LlenarTextBox();
        }
    }
}
