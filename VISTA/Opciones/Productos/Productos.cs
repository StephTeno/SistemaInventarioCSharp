using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoContabilidadDeCosto.Opciones.Productos
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }
        public void ActualizarDGV()
        {
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void txtCodProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
