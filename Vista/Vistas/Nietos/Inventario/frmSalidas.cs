using CONTROLLER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Vistas.BisNietos;

namespace Vista.Vistas.Nietos.Inventario
{
    public partial class frmSalidas : Form
    {
        ControllerSalida s = new ControllerSalida();
        public frmSalidas()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMetSalidas m = new frmMetSalidas();
            m.ShowDialog();
            s.RellenarData(dgvSalidas);
        }
    }
}
