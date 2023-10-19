using CONTROLLER;
using CONTROLLER.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Vistas.Nietos.Admin
{
    public partial class frmProveedores : Form
    {
        ControllerProveedor p = new ControllerProveedor();
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            p.RellenarData(dgvProv);
        }
    }
}
