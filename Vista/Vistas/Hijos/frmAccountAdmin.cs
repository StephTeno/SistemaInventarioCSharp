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

namespace Vista.Vistas.Hijos
{
    public partial class frmAccountAdmin : Form
    {
        private IconButton btnSelection;
        private Panel BordInf;
        public frmAccountAdmin()
        {
            InitializeComponent();
            BordInf = new Panel();
            BordInf.Size = new Size(150, 5);
            plOptions.Controls.Add(BordInf);
            ActiveButton(btnAllUser);
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ActiveButton(btnAddUser);
        }

        private void btnAllUser_Click(object sender, EventArgs e)
        {
            ActiveButton(btnAllUser);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEditUser);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            ActiveButton(btnDeleteUser);
        }
    }
}
