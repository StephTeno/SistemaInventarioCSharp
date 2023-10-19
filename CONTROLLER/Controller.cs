using CONTROLLER.Repositorios;
using Microsoft.EntityFrameworkCore;
using MODELO.Data;
using MODELO.Models;

namespace CONTROLLER
{
    public class ControllerProd
    {
        string id;
        Producto prod = new Producto();
        RepoProducto r = new RepoProducto();
        public ControllerProd() { }
        public void RellenarData(DataGridView dgvDatos)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = r.GetAll();
        }


        public Producto Encontrar(string id)
        {
            Producto c = r.Get(s => s.IdProd == id, tracked: false);
            return c;
        }

    }


    public class ControllerUsers
    {
        string id;
        RepoUsuario r = new RepoUsuario();
        RepoTipos t = new RepoTipos();

        public ControllerUsers() { }

        public void Eliminar( DataGridView dgvDatos, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = row.Cells[0].Value.ToString();
                    Usuario c = EncontrarUsername(id);
                    using (ESInventarioContext context = new ESInventarioContext())
                    {
                        if (c != null)
                        {
                            context.Usuarios.Remove(c);
                            context.SaveChanges();
                        }
                        else { return; }
                    }
                }
            }
        }

        public void ActualizarDatos(Usuario c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Usuarios.Update(c);
                context.SaveChanges();
            }
        }

        public void AgregarDatos(Usuario c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Usuarios.Add(c);
                context.SaveChanges();
            }
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
        public Usuario EncontrarUsername(string username)
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