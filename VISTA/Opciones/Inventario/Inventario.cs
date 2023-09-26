using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoContabilidadDeCosto.Opciones.Inventario
{
    public partial class Inventario : Form
    {
        Controlador.Controller Control = new Controlador.Controller();
        public Form FormularioVista { get; set; }
        public Inventario()
        {
            InitializeComponent();
            if(Datos.Pros.Count > 0 && Datos.Salidas.Count > 0 && Datos.Entradas.Count > 0 
                && Datos.Inventory.Count > 0)
            {
                Control.RepararInventario(Datos.Inventory, Datos.Entradas, Datos.Salidas);
                Control.RellenarInventario(Datos.Inventory, dgvInventario);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
