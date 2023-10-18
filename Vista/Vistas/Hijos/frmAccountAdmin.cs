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
using Vista.Vistas.Nietos;

namespace Vista.Vistas.Hijos
{
    public partial class frmAccountAdmin : Form
    {
        private IconButton btnSelection;
        private Panel BordInf;

        private void Inicio()
        {
            ActiveButton(btnAllUser);
            AbrirFormInPanel(new frmUsers());
        }
        public frmAccountAdmin()
        {
            InitializeComponent();
            BordInf = new Panel();
            BordInf.Size = new Size(150, 5);
            plOptions.Controls.Add(BordInf);
            Inicio();
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

        private void btnAllUser_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        private void btnNoti_Click(object sender, EventArgs e)
        {
            ActiveButton(btnNoti);
            AbrirFormInPanel(new frmNotification());
        }

        private void btnCatAndCal_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCatAndCal);
            AbrirFormInPanel(new frmOrgProduct());
        }

        private void btnUmbStock_Click(object sender, EventArgs e)
        {
            ActiveButton(btnUmbStock);
            AbrirFormInPanel(new frmUmbStock());
        }

        private void btnUbicAlma_Click(object sender, EventArgs e)
        {
            ActiveButton(btnUbicAlma);
            AbrirFormInPanel(new frmUbiAlmacenes());
        }
    }
}
