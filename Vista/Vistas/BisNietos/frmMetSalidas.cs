using CONTROLLER;
using CustomControls.RJControls;
using CustomMessageBox;
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
using Vista.Controles_personalizados;

namespace Vista.Vistas.BisNietos
{
    public partial class frmMetSalidas : Form
    {
        ControllerProd p = new ControllerProd();
        ControllerInv inv = new ControllerInv();
        ControllerSalida salida = new ControllerSalida();
        Producto pr = new Producto();
        Salida s = new Salida();
        List<Salida> sa = new List<Salida>();
        public frmMetSalidas()
        {
            InitializeComponent();
        }
        public bool VerificarProducto(string id)
        {
            if (p.Encontrar(id) != null)
                return true;
            else
            {
                return false;
            }
        }

        public bool TodosLosTextBoxLlenos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is RJTextBox)
                {
                    RJTextBox textBox = (RJTextBox)control;
                    if (string.IsNullOrWhiteSpace(textBox.Texts))
                    {
                        return false; // Devuelve false si un TextBox está vacío o contiene solo espacios en blanco
                    }
                }
            }
            return true; // Si no se encuentra ningún TextBox vacío, devuelve true
        }

        public void AgregarNumero(object sender, EventArgs e)
        {
            var b = ((RJButton)sender);

            if (txtCant.Texts == "0")
                txtCant.Texts = "";

            txtCant.Texts += b.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            salida.AgregarDatos(sa);
        }

        private void txtCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                pr = p.Encontrar(txtCodBarra.Text);
                txtNomProd.Texts = pr.NombreProd;
                btnAddProducto_Click(sender, e);
            }
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            if (VerificarProducto(txtCodBarra.Texts))
            {
                if (TodosLosTextBoxLlenos())
                {
                    s.Cantidad = Convert.ToInt32(txtCant.Texts);
                    s.IdProd = txtCodBarra.Text;
                    s.Total = Convert.ToInt32(txtCant.Texts) * Convert.ToInt32(txtCosto.Texts);
                    inv.SacarProducto(txtCodBarra.Texts, Convert.ToInt32(txtCant.Texts));
                    sa.Add(s);
                    dgvSalidas.DataSource = null;
                    dgvSalidas.DataSource = sa;
                }
                else
                {
                    RJMessageBox.Show("Ingrese todos los datos por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                RJMessageBox.Show("Ingrese el Codigo de Barra de un producto ya registrado por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
