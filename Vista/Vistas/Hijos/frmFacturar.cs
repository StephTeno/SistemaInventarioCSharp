using CONTROLLER;
using CustomControls.RJControls;
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

namespace Vista.Vistas.Hijos
{
    public partial class frmFacturar : Form
    {
        Factura f = new Factura();
        Producto pd = new Producto();
        DetalleFactura d = new DetalleFactura();
        ControllerInv inv = new ControllerInv();
        decimal sub, iva, total;
        int cant;
        ControllerCliente c = new ControllerCliente();
        ControllerProd p = new ControllerProd();
        ControllerFactura cf = new ControllerFactura();
        List<DetalleFactura> df = new List<DetalleFactura>();
        Usuario u = new Usuario();
        int ti;
        public frmFacturar(Usuario us)
        {
            InitializeComponent();
            u = us;
        }
        public void AgregarNumero(object sender, EventArgs e)
        {
            var b = ((RJButton)sender);

            if (txtCantidad.Texts == "0")
                txtCantidad.Texts = "";

            txtCantidad.Texts += b.Text;
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
            List<Cliente> lst = c.RellenarCombobox();

            if (lst.Count > 0)
            {
                cb.DisplayMember = "Pnomb";
                cb.ValueMember = "IdCliente";
                cb.DataSource = lst;
            }
        }
        private void cmbClientes_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ti = 1 + cmbClientes.SelectedIndex;
            lblConfi.Text = ti.ToString();
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {
            f.IdFactura = cf.EncontrarUltima();
            int id = Convert.ToInt32(f.IdFactura);
            if (f.IdFactura == null)
            {
                f.IdFactura = "1";
            }
            else
            {
                id += 1;
                f.IdFactura = id.ToString();
            }
            Combo(cmbClientes);
            txtCodBarra.Focus();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            f.Fecha = DateTime.Now;
            f.IdCliente = ti;
            f.IdEmpleado = u.Username;
            f.CantTotal = cant;
            f.Iva = Convert.ToDecimal(txtIVA.Texts);
            f.SubTotal = Convert.ToDecimal(txtSubTotal.Texts);
            f.Total = Convert.ToDecimal(txtTotal.Texts);
            cf.AgregarDatos(f);
            cf.AgregarDetalles(df);

        }

        private void txtCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCantidad.Focus();
                pd = p.Encontrar(txtCodBarra.Texts);
                lblPrecio.Text = (pd.PreVenta * (decimal)(1.15)).ToString();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnEnter.Focus();
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            d.IdFactura = f.IdFactura;
            d.IdProd = txtCodBarra.Texts;
            d.Cantidad = Convert.ToInt32(txtCantidad.Texts);
            cant += d.Cantidad;
            d.SubTotal = Convert.ToInt32(txtCantidad.Texts) * pd.PreVenta;
            iva += d.SubTotal * (decimal)(0.15);
            sub += d.SubTotal;
            total += sub + iva;
            txtIVA.Texts = iva.ToString();
            txtSubTotal.Texts = sub.ToString();
            txtTotal.Texts = total.ToString();
            inv.SacarProducto(txtCodBarra.Texts, Convert.ToInt32(txtCantidad.Texts));
            df.Add(d);
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = df;
        }
    }
}
