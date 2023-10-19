using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLLER;

namespace Vista.Vistas.Nietos
{
    public partial class frmClientes : Form
    {
        ControllerCliente cliente = new ControllerCliente();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cliente.RellenarData(dgvClient);
        }
    }
}
