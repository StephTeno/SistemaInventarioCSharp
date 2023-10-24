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
using static System.Net.Mime.MediaTypeNames;

namespace Vista.Vistas.BisNietos
{
    public partial class frmMetEntrada : Form
    {
        ControllerProveedor c = new ControllerProveedor();
        string ti = string.Empty;
        int cant, subtotal, total, ultima;
        Producto pr = new Producto();
        Entrada en = new Entrada();
        List<DetalleEntradum> de = new List<DetalleEntradum>();
        ControllerProd p = new ControllerProd();
        ControllerEntrada ed = new ControllerEntrada();
        ControllerInv iv = new ControllerInv();
        public frmMetEntrada()
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
        private void Combo(RJComboBox cb)
        {
            List<Proveedore> lst = c.RellenarCombobox();

            if (lst.Count > 0)
            {
                cb.DisplayMember = "Empresa";
                cb.ValueMember = "Ruc";
                cb.DataSource = lst;
            }
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
            if (TodosLosTextBoxLlenos())
            {
                Entrada a = new Entrada();
                a.TotalCompra = Convert.ToDecimal(txtTotal.Texts);
                a.FechaCompra = DateTime.Now;
                a.Proveedor = cmbProveedor.Texts;
                a.Recibo = txtRecibo.Text;
                this.Close();
            }
            else
            {
                RJMessageBox.Show("Llene todos los datos por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbProveedor_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ti = cmbProveedor.Texts;
            label6.Text = ti.ToString();
        }

        private void frmMetEntrada_Load(object sender, EventArgs e)
        {
            Combo(cmbProveedor);
            ultima = 1 + ed.EncontrarUltima();
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            if (VerificarProducto(txtCodBarra.Texts))
            {
                if (TodosLosTextBoxLlenos())
                {
                    DetalleEntradum me = new DetalleEntradum();
                    me.Cantidad = Convert.ToInt32(txtCant.Texts);
                    me.IdProd = txtCodBarra.Text;
                    me.SubTotal = Convert.ToInt32(txtCant.Texts) * Convert.ToDecimal(txtCosto.Texts);
                    me.PreCompra = Convert.ToDecimal(txtCosto.Texts);
                    me.IdEntrada = ultima;
                    iv.EntradaProducto(txtCodBarra.Texts, Convert.ToInt32(txtCant.Texts));
                    de.Add(me);
                    dgvCompras.DataSource = null;
                    dgvCompras.DataSource = de;
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

        private void txtCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAddProducto.Focus();
            }
        }
    }
}
