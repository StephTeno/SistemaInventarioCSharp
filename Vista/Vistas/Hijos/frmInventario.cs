using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Vistas.Nietos.Inventario;

namespace Vista.Vistas.Hijos
{
    public partial class frmInventario : Form
    {
        private IconButton btnSelection;
        private Panel BordInf;
        public frmInventario()
        {
            InitializeComponent();
            BordInf = new Panel();
            BordInf.Size = new Size(150, 5);
            plOptions.Controls.Add(BordInf);
        }
        private void ActiveButton(object button)
        {
            if (button != null)
            {
                DesactiveButton();
                btnSelection = (IconButton)button;
                btnSelection.ForeColor = Color.CornflowerBlue;
                btnSelection.IconColor = Color.CornflowerBlue;
                BordInf.BackColor = Color.CornflowerBlue;
                BordInf.Location = new Point(btnSelection.Location.X, 49);
                BordInf.Visible = true;
                BordInf.BringToFront();
            }
        }
        private void DesactiveButton()
        {
            if (btnSelection != null)
            {
                btnSelection.ForeColor = Color.DimGray;
                btnSelection.IconColor = Color.DimGray;
            }
        }
        public void AbrirFormInPanel(object FormNieto)
        {
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            Form fh = (Form)FormNieto;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fh);
            this.plContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void btnRegEntrada_Click(object sender, EventArgs e)
        {
            ActiveButton(btnRegEntrada);
            AbrirFormInPanel(new frmEntrada());
        }

        private void btnRegSalidas_Click(object sender, EventArgs e)
        {
            ActiveButton(btnRegSalidas);
            AbrirFormInPanel(new frmSalidas());
        }
    }
}
