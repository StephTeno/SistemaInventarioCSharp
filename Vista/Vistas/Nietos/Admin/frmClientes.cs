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
using MODELO.Models;
using Vista.Vistas.BisNietos;

namespace Vista.Vistas.Nietos
{
    public partial class frmClientes : Form
    {
        ControllerCliente cliente = new ControllerCliente();

        Cliente pr = new Cliente();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cliente.RellenarData(dgvClient);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMetClientes m = new frmMetClientes(btnAdd.Text);
            m.ShowDialog();
            cliente.RellenarData(dgvClient);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMetClientes m = new frmMetClientes(btnDelete.Text);
            m.cl = pr;
            m.ShowDialog();
            cliente.RellenarData(dgvClient);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmMetClientes m = new frmMetClientes(btnEdit.Text);
            m.cl = pr;
            m.ShowDialog();
            cliente.RellenarData(dgvClient);
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvClient.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    pr = cliente.Encontrar(id);
                }
            }
        }
    }
}
