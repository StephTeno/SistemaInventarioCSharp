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
        int Pos;
        Controlador.Controller Control = new Controlador.Controller();
        public Productos()
        {
            InitializeComponent();
            ActualizarDGV();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbCategorias.Text != "" && txtCodProducto.Text != "" && txtProducto.Text != "")
            {
                ActualizarDGV();
                Datos.Pro = new MODELO.Producto(txtCodProducto.Text, txtProducto.Text, cbCategorias.Text, 0, 0);
                Datos.Pros.Add(Datos.Pro);
                dgvProductos = Control.RellenarProductos(dgvProductos, Datos.Pro);
                MessageBox.Show("Producto Agregado :D");
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
        }
        //Método pequeñito que actualiza el datagridview sin que explote T_T (2 horas :D)
        public void ActualizarDGV()
        {
            if (Datos.Pros.Count > 0)
            {
                dgvProductos.Rows.Clear();
                dgvProductos = Control.ActualizarProductos(dgvProductos, Datos.Pros);
            }
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pos = dgvProductos.CurrentRow.Index;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Control.EliminarProducto(Pos, Datos.Pros, dgvProductos);
            ActualizarDGV();
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
