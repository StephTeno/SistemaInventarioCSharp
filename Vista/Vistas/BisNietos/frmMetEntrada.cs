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
    public partial class frmMetEntrada : Form
    {
        string Tipo = String.Empty;
        public frmMetEntrada(string tipo = "Agregar")
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
        private void frmMetEntrada_Load(object sender, EventArgs e)
        {
            Metodo();
        }
    }
}
