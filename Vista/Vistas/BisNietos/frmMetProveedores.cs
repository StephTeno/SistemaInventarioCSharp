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
using Vista.Controles_personalizados;

namespace Vista.Vistas.BisNietos
{
    public partial class frmMetProveedores : Form
    {
        ControllerProveedor p = new ControllerProveedor();
        public Proveedore pr = new Proveedore();
        ControllerLocalidad l = new ControllerLocalidad();
        string Tipo = String.Empty;
        int ti;
        public frmMetProveedores(string tipo = "Agregar")
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

            txtRUC.Texts = pr.Ruc;
            txtEmpresa.Texts = pr.Empresa;
            txtRepresentante.Texts = pr.Representante;
            txtCargo.Texts = pr.CargoPro;
            txtCelular.Texts = pr.Telefono;
            txtCorreo.Texts = pr.Correo;
        }
        private void Combo(RJComboBox cb)
        {
            var lst = l.RellenarCombobox();

            if (lst.Count > 0)
            {
                cb.DisplayMember = "Municipio1";
                cb.ValueMember = "IdMun";
                cb.DataSource = lst;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TodosLosTextBoxLlenos())
            {
                if (validateEmail(txtCorreo.Texts))
                {
                    lblECo.Visible = false;
                    pr.Ruc = txtRUC.Texts;
                    pr.Empresa = txtEmpresa.Texts;
                    pr.Representante = txtRepresentante.Texts;
                    pr.CargoPro = txtCargo.Texts;
                    pr.Municipio = ti;
                    pr.Telefono = txtCelular.Texts;
                    pr.Correo = txtCorreo.Texts;
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

        private void frmMetProveedores_Load(object sender, EventArgs e)
        {
            Metodo();
            Combo(cmbLocalidad);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCelular__TextChanged(object sender, EventArgs e)
        {
            if (txtCelular.Texts.Length > 8)
                lblECe.Visible = true;
            else
            {
                lblECe.Visible = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TodosLosTextBoxLlenos())
            {
                if (validateEmail(txtCorreo.Texts))
                {
                    lblECo.Visible = false;
                    pr.Ruc = txtRUC.Texts;
                    pr.Empresa = txtEmpresa.Texts;
                    pr.Representante = txtRepresentante.Texts;
                    pr.CargoPro = txtCargo.Texts;
                    pr.Municipio = ti;
                    pr.Telefono = txtCelular.Texts;
                    pr.Correo = txtCorreo.Texts;
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

        private void cmbLocalidad_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ti = 1 + cmbLocalidad.SelectedIndex;
            label9.Text = ti.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = RJMessageBox.Show("¿Estas seguro en eliminar el Proveedor?", "Eliminar", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                p.Eliminar(pr);
                this.Close();
            }
            else if (d == DialogResult.No) { this.Close(); }
        }
    }
}
