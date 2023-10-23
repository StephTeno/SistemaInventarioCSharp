using CONTROLLER.Repositorios;
using Microsoft.EntityFrameworkCore;
using MODELO.Data;
using MODELO.Models;
using System.Collections;

namespace CONTROLLER
{

    public class ControllerEntrada
    {
        RepoEntrada r = new RepoEntrada();
        RepoDetalleEntrada d = new RepoDetalleEntrada();
        RepoProducto pd = new RepoProducto();
        public ControllerEntrada() { }


        public void AgregarProducto(Producto c)
        {
            pd.Registrar(c);
        }

        public void AgregarDatos(Entrada c)
        {
            r.Registrar(c);
        }
        public void AgregarDetalles(List<DetalleEntradum> c)
        {
            d.Registrar(c);
        }


    }
    public class ControllerFactura
    {
        RepoFactura r = new RepoFactura();
        public ControllerFactura() { }

        public void AgregarDatos(Factura c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Facturas.Add(c);
                context.SaveChanges();
            }
        }
        public string EncontrarUltima()
        {
            List<Factura> f = r.GetAll();
            var i = (from p in f
                     orderby p.IdFactura descending
                     select p.IdFactura).FirstOrDefault();
            if (i == null)
                return "0";
            return i.ToString();
        }
        public void AgregarDetalles(List<DetalleFactura> c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.DetalleFacturas.AddRange(c);
                context.SaveChanges();
            }
        }

    }
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

        public void Eliminar(Usuario c)
        {
            r.Remove(c);
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

    public class ControllerLocalidad
    {
        RepoMunicipio repo = new RepoMunicipio();
        public ControllerLocalidad() { }
        public List<Municipio> RellenarCombobox()
        {
            return repo.GetAll();
        }
    }

    public class ControllerProveedor
    {
        RepoProve repo = new RepoProve();
        string id;
        public ControllerProveedor() { }
        public void RellenarData(DataGridView dgvDatos)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = repo.GetAll();
        }

        public void Eliminar(Proveedore c)
        {
            repo.Remove(c);
        }

        public List<Proveedore> RellenarCombobox()
        {
            return repo.GetProveedores();
        }

        public void AgregarDatos(Proveedore c)
        {
            repo.Registrar(c);
        }
        public void ActualizarDatos(Proveedore c)
        {
            repo.Update(c);
        }

        public Proveedore Encontrar(string id)
        {
            Proveedore c = repo.Get(s => s.Ruc == id, tracked: false);
            return c;
        }
    }


    public class ControllerCliente
    {
        RepoCliente repo = new RepoCliente();
        int id;

        public void Eliminar(Cliente c)
        {
            repo.Remove(c);
        }

        public List<Cliente>RellenarCombobox()
        {
            return repo.GetClientes();
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