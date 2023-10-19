using CONTROLLER.Repositorios;
using Microsoft.EntityFrameworkCore;
using MODELO.Data;
using MODELO.Models;

namespace CONTROLLER
{

    public class ControllerUsers
    {
        RepoUsuario r = new RepoUsuario();
        RepoTipos t = new RepoTipos();

        public ControllerUsers() { }

        public void AgregarDatos(Usuario c)
        {
            r.Registrar(c);
        }
        public List<TipoUsuario> RellenarCombobox()
        {
            return t.GetTypesUsers();
        }
        public void RellenarData(DataGridView dgvDatos)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = r.GetAll();
        }
        public Usuario Encontrar(string username)
        {
            Usuario c = r.Get(s => s.Username == username, tracked: false);
            return c;
        }
    }

    public class ControllerProveedor
    {
        RepoProve repo = new RepoProve();
        int id;
        public ControllerProveedor() { }
        public void RellenarData(DataGridView dgvDatos)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = repo.GetAll();
        }
    }


    public class ControllerCliente
    {
        RepoCliente repo = new RepoCliente();
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
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = repo.GetAll();
        }

        public void AgregarDatos(string nombre)
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