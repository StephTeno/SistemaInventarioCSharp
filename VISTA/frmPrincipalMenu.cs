using ProyectoContabilidadDeCosto.Intermidiarios;
using ProyectoContabilidadDeCosto.Opciones.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoContabilidadDeCosto
{
    public partial class frmPrincipalMenu : Form
    {
        int validarEntrada = 0;
        int validarEntrada2 = 0;
        public frmPrincipalMenu()
        {
            InitializeComponent();
        }

        private void frmPrincipalMenu_Load(object sender, EventArgs e) { }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (validarEntrada2 == 0)
            {
                MessageBox.Show("Ingrese un producto");
            }
            else
            {
                using (var Iform = new ISalidas())
                {
                    var result = Iform.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Form FormularioVista = Iform.FormularioVista;
                        this.Hide();
                        FormularioVista.Show();
                        FormularioVista.FormClosing += Frm_Closing;
                    }
                }
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario FormularioVista = new Inventario();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosing += Frm_Closing;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            validarEntrada = 1;
            validarEntrada2 = 1;
            using (var Iform = new IProductos())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Form FormularioVista = Iform.FormularioVista;
                    this.Hide();
                    FormularioVista.Show();
                    FormularioVista.FormClosing += Frm_Closing;
                }
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (validarEntrada == 0)
            {
                MessageBox.Show("Ingrese un producto");
            }
            else
            {
                using (var Iform = new IEntradas())
                {
                    var result = Iform.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Form FormularioVista = Iform.FormularioVista;
                        this.Hide();
                        FormularioVista.Show();
                        FormularioVista.FormClosing += Frm_Closing;
                    }
                }
            }
        }
        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnMSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de salir?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
