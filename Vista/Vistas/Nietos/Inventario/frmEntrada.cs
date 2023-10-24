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
    public partial class frmEntrada : Form
    {
        ControllerEntrada i = new ControllerEntrada();
        public frmEntrada()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMetEntrada m = new frmMetEntrada();
            m.ShowDialog();
            i.RellenarData(dgvEntradas);
        }
    }
}
