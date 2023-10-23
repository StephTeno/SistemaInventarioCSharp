using CONTROLLER;
using CustomControls.RJControls;
using CustomMessageBox;
using MODELO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using Vista.Controles_personalizados;

namespace Vista.Vistas.BisNietos
{
    public partial class frmMetClientes : Form
    {
        ControllerCliente c = new ControllerCliente();
        public Cliente cl = new Cliente();
        ControllerLocalidad l = new ControllerLocalidad();
        string Tipo = string.Empty;
        int ti;
        bool ac;
        public frmMetClientes(string tipo)
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
                    btnDelete.Location = new Point(376, 18);
                    LlenarTextBoxs();
                    break;
                case "Editar":
                    btnEdit.Visible = true;
                    btnEdit.Location = new Point(376, 18);
                    LlenarTextBoxs();
                    break;
                default:
                    break;
            }
        }
        public void LlenarTextBoxs()
        {
            txtSNom.Texts = cl.Snomb;
            txtPNom.Texts = cl.Pnomb;
            txtPAp.Texts = cl.Pape;
            txtSAp.Texts = cl.Sape;
            txtCedula.Texts = cl.Cedula;
            txtCelular.Texts = cl.Celular;
            txtCorreo.Texts = cl.Correo;
        }
        private void Combo(RJComboBox cbLocalidad)
        {
            var lst = l.RellenarCombobox();

            if (lst.Count > 0)
            {
                cbLocalidad.DisplayMember = "Municipio1";
                cbLocalidad.ValueMember = "IdMun";
                cbLocalidad.DataSource = lst;
            }
        }
        static bool validateEmail(string email)
        {
            if (email == null)
            {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email))
            {
                return true;
            }
            else
            {
                return false;
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

        private void cmbLocalidad_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ti = 1+cmbLocalidad.SelectedIndex;
            label9.Text = ti.ToString();
        }

        private void frmMetClientes_Load(object sender, EventArgs e)
        {
            Metodo();
            Combo(cmbLocalidad);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TodosLosTextBoxLlenos())
            {
                if (validateEmail(txtCorreo.Texts))
                {
                    lblECo.Visible = false;
                    cl.Snomb = txtSNom.Texts;
                    cl.Pnomb = txtPNom.Texts;
                    cl.Pape = txtPAp.Texts;
                    cl.Sape = txtSAp.Texts;
                    cl.Cedula = txtCedula.Texts;
                    cl.Municipio = ti;
                    cl.Celular = txtCelular.Texts;
                    cl.Correo = txtCorreo.Texts;
                    this.Close();
                }
                else
                {
                    lblECo.Visible = true;
                }
            }
            else
            {
                RJMessageBox.Show("Llene todos los datos por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TodosLosTextBoxLlenos())
            {
                if (validateEmail(txtCorreo.Texts))
                {
                    lblECo.Visible = false;
                    cl.Snomb = txtSNom.Texts;
                    cl.Pnomb = txtPNom.Texts;
                    cl.Pape = txtPAp.Texts;
                    cl.Sape = txtSAp.Texts;
                    cl.Cedula = txtCedula.Texts;
                    cl.Municipio = ti;
                    cl.Celular = txtCelular.Texts;
                    cl.Correo = txtCorreo.Texts;
                    this.Close();
                }
                else
                {
                    lblECo.Visible = true;
                }
            }
            else
            {
                RJMessageBox.Show("Llene todos los datos por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = RJMessageBox.Show("¿Estas seguro en eliminar el Cliente?", "Eliminar", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                c.Eliminar(cl);
                this.Close();
            }
            else if (d == DialogResult.No) { this.Close(); }
        }
    }
}
