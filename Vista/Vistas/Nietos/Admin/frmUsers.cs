using CONTROLLER;
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
using Vista.Vistas.BisNietos;

namespace Vista.Vistas.Nietos
{
    public partial class frmUsers : Form
    {
        ControllerUsers c = new ControllerUsers();
        Usuario u = new Usuario();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMetUsuarios m = new frmMetUsuarios(btnAdd.Text);
            m.ShowDialog();
            c.RellenarData(dgvUsers);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMetUsuarios m = new frmMetUsuarios(btnDelete.Text);
            m.us = u;
            m.ShowDialog();
            c.RellenarData(dgvUsers);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmMetUsuarios m = new frmMetUsuarios(btnEdit.Text);
            m.us = u;
            m.ShowDialog();
            c.RellenarData(dgvUsers);
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            c.RellenarData(dgvUsers);
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    string id = row.Cells[0].Value.ToString();
                    u=c.EncontrarUsername(id);
                }
            }
        }
    }
}
