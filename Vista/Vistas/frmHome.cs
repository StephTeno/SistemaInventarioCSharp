using FontAwesome.Sharp;
using MODELO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Vistas.Hijos;

namespace Vista.HOME
{
    public partial class frmHome : Form
    {
        IconButton btnSelection;
        Usuario u;
        public frmHome(Usuario us)
        {
            InitializeComponent();
            u = us;
            btnProfile.Text = us.Username;
        }

        private void ManagePermissions()
        {
            if (u.Tipo == Positions.Administrador)
            {
                btnInvoice.Enabled = false;
                btnInvoice.Visible = false;
            }
            if (u.Tipo == Positions.Bodeguero)
            {
                btnInvoice.Enabled = false;
                btnAdmin.Enabled = false;
                btnHistorial.Enabled = false;
                btnInvoice.Visible = false;
                btnAdmin.Visible = false;
                btnHistorial.Visible = false;
            }
            if (u.Tipo == Positions.Cajero)
            {
                btnInventory.Enabled = false;
                btnAdmin.Enabled = false;
                btnHistorial.Enabled = false;
                btnInventory.Visible = false;
                btnAdmin.Visible = false;
                btnHistorial.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.RoyalBlue;
        }

        private void btnMinus_MouseEnter(object sender, EventArgs e)
        {
            btnMinus.BackColor = Color.RoyalBlue;
        }

        private void btnMinus_MouseLeave(object sender, EventArgs e)
        {
            btnMinus.BackColor = Color.FromArgb(40, 86, 160);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(40, 86, 160);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            ManagePermissions();
            ti.Enabled = true;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            AbrirFormInPanel(new frmDashboard());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (flpSidebar.Width == 200)
            {
                flpSidebar.Width = 70;
            }
            else
            {
                flpSidebar.Width = 200;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ddmProfile.Show(btnProfile, 0, btnProfile.Height);
        }

        public void AbrirFormInPanel(object FormHijo)
        {
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            Form fh = (Form)FormHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fh);
            this.plContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void ActiveButton(object button)
        {
            if (button != null)
            {
                DesactiveButton();
                btnSelection = (IconButton)button;
                btnSelection.BackColor = Color.White;
                btnSelection.ForeColor = Color.CornflowerBlue;
                btnSelection.IconColor = Color.CornflowerBlue;
            }
        }
        private void DesactiveButton()
        {
            if (btnSelection != null)
            {
                btnSelection.BackColor = Color.FromArgb(235, 239, 241);
                btnSelection.IconColor = Color.Gray;
                btnSelection.ForeColor = Color.Gray;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmDashboard());
            ActiveButton(btnInicio);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmAccountAdmin());
            ActiveButton(btnAdmin);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmInventario());
            ActiveButton(btnInventory);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            btnProfile_Click(sender, e);
        }

        private void ItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCatalogue);
            AbrirFormInPanel(new frmCatalogo());
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            ActiveButton(btnInvoice);
            AbrirFormInPanel(new frmFacturar());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHistorial);
            AbrirFormInPanel(new frmHistory());
        }

        private void ti_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            lblFechaYHora.Text = hoy.ToString("f");
        }
    }

    public struct Positions
    {
        public const int Administrador = 1;
        public const int Bodeguero = 2;
        public const int Cajero = 3;
    }

}
