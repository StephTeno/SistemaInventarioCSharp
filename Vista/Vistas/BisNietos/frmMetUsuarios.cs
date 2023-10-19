using CONTROLLER;
using CustomControls.RJControls;
using CustomMessageBox;
using MODELO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Vista.Controles_personalizados;

namespace Vista.Vistas.BisNietos
{
    public partial class frmMetUsuarios : Form
    {
        string Tipo = String.Empty;
        ControllerUsers u = new ControllerUsers();
        public frmMetUsuarios(string tipo = "Agregar")
        {
            InitializeComponent();
            Tipo = tipo;
        }

        public void Metodo()
        {
            switch (Tipo)
            {
                case "Agregar":
                    btnAdd.Visible = true;
                    break;
                case "Eliminar":
                    btnDelete.Visible = true;
                    btnDelete.Location = new Point(243, 18);
                    break;
                case "Editar":
                    btnEdit.Visible = true;
                    btnEdit.Location = new Point(243, 18);
                    break;
                default:
                    break;
            }
        }

        private void MetUsuarios_Load(object sender, EventArgs e)
        {
            Metodo();
            Combo(cbCargo);
        }

        private void Combo(RJComboBox cb)
        {
            var lst = u.RellenarCombobox();

            if (lst.Count > 0)
            {
                cb.DisplayMember = "Nombre";
                cb.ValueMember = "IdTipoUser";
                cb.DataSource = lst;
            }
        }

        public bool TodosLosTextBoxLlenos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is RJTextBox)
                {
                    RJTextBox textBox = (RJTextBox)control;
                    if (string.IsNullOrWhiteSpace(textBox.Texts))
                    {
                        return false; // Devuelve false si un TextBox está vacío o contiene solo espacios en blanco
                    }
                }
            }
            return true; // Si no se encuentra ningún TextBox vacío, devuelve true
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TodosLosTextBoxLlenos())
            {
                Usuario us = new Usuario();
                us.Username = txtUser.Texts;
                us.Tipo = cbCargo.SelectedIndex;
                us.Contrasena = txtContrasena.Texts;
                u.AgregarDatos(us);
                this.Close();
            }
            else
            {
                RJMessageBox.Show("Llene todos los datos por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Metodo para modificar
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Metodo para eliminar
            this.Close();
        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
