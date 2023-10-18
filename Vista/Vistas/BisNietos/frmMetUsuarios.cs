using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Vistas.BisNietos
{
    public partial class frmMetUsuarios : Form
    {
        string Tipo = String.Empty;
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Metodo para agregar
            this.Close();
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
    }
}
