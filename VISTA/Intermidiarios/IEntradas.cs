using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoContabilidadDeCosto.Opciones.Entrada;

namespace ProyectoContabilidadDeCosto.Intermidiarios
{
    public partial class IEntradas : Form
    {
        public Form FormularioVista { get; set; }
        public IEntradas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            FormularioVista = new Entrada();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
