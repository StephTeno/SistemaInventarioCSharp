using CONTROLLER.Repositorios;
using Microsoft.EntityFrameworkCore;
using MODELO.Data;
using MODELO.Models;
using System.Windows.Forms;

namespace CONTROLLER
{
    public class ControllerCliente
    {
        RepoCliente repo;
        int id;

        public void Eliminar(int pos, DataGridView dgvDatos, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = int.Parse(row.Cells[0].Value.ToString());
                    Cliente c = Encontrar(id);
                    repo.Remove(c);
                }
            }
        }

        public void RellenarData(DataGridView dgvDatos)
        {
            //dgvDatos.DataSource = repo.GetAll();
        }

        public void AgregarDatos(string nombre ...)
        {
            Cliente c = new Cliente();
            repo.Registrar(c);
        }
        public void ActualizarDatos(Cliente c)
        {
            repo.Update(c);
        }

        public Cliente Encontrar(int id)
        {
            Cliente c = repo.Get(s => s.IdCliente ==id, tracked: false);
            return c;
        }


    }
}