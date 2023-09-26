using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoContabilidadDeCosto.Opciones.Productos;

namespace ProyectoContabilidadDeCosto.Intermidiarios
{
    public partial class IProductos : Form
    {
        public Form FormularioVista { get; set; }
        public IProductos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            FormularioVista = new Productos();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
