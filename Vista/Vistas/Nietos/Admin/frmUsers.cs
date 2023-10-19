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

namespace Vista.Vistas.Nietos
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMetUsuarios m = new frmMetUsuarios(btnAdd.Text);
            m.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMetUsuarios m = new frmMetUsuarios(btnDelete.Text);
            m.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmMetUsuarios m = new frmMetUsuarios(btnEdit.Text);
            m.ShowDialog();
        }
    }
}
