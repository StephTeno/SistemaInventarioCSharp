using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Vistas.BisNietos
{
    public partial class frmMetEntrada : Form
    {
        public frmMetEntrada()
        {
            InitializeComponent();
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
            //Agregar y Salir
            this.Close();
        }
    }
}
