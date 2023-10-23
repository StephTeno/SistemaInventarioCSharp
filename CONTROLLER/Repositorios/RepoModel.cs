using Microsoft.EntityFrameworkCore;
using MODELO.Data;
using MODELO.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLER.Repositorios
{
    public class RepoCliente
    {
        public RepoCliente(){}

        public Cliente Get(Expression<Func<Cliente, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<Cliente> query = context.Clientes;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public ArrayList GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var ls = from p in context.Clientes
                           select new { p.IdCliente, p.Pnomb, p.Snomb, p.Pape, p.Sape, p.Celular};
                ArrayList lst = new ArrayList();

                foreach(var p in ls)
                {
                    lst.Add(p);
                }
                return lst;
            }
        }

        public List<Cliente> GetClientes()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                return context.Clientes.ToList();
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }
        public void Registrar(Cliente c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Clientes.Add(c);
                Save();
            }
        }

        public void Remove(Cliente c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                if (c != null)
                {
                    context.Clientes.Remove(c);
                    Save();
                }
                else { return; }
            }
        }

        public void Update(Cliente c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Clientes.Update(c);
                Save();
            }
        }
    }
    public class RepoProve
    {
        public RepoProve(){}
        public List<Proveedore> GetProveedores()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                return context.Proveedores.ToList();
            }
        }
        public Proveedore Get(Expression<Func<Proveedore, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<Proveedore> query = context.Proveedores;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public ArrayList GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var ls = from p in context.Proveedores
                         select new { p.Ruc, p.Empresa, p.Representante, p.CargoPro, p.Telefono, p.Correo};
                ArrayList lst = new ArrayList();

                foreach (var p in ls)
                {
                    lst.Add(p);
                }
                return lst;
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }
        public void Registrar(Proveedore c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Proveedores.Add(c);
                Save();
            }
        }

        public void Remove(Proveedore c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                if (c != null)
                {
                    context.Proveedores.Remove(c);
                    Save();
                }
                else { return; }
            }
        }


        public void Update(Proveedore c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Proveedores.Update(c);
                Save();
            }
        }
    }
    public class RepoEntrada
    {
        public Entrada Get(Expression<Func<Entrada, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<Entrada> query = context.Entradas;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public List<Entrada> GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var lst = (from p in context.Entradas
                           select p).ToList();
                return lst;
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }
        public void Registrar(Entrada c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Entradas.Add(c);
                Save();
            }
        }

        public void Remove(Entrada c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                if (c != null)
                {
                    context.Entradas.Remove(c);
                    Save();
                }
                else { return; }
            }
        }
        public RepoEntrada(){}

        public void Update(Entrada c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Entradas.Update(c);
                Save();
            }
        }
    }
    public class RepoCategoriaProd
    {
        public RepoCategoriaProd() { }
        public CategoriaProd Get(Expression<Func<CategoriaProd, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<CategoriaProd> query = context.CategoriaProds;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public List<CategoriaProd> GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var lst = (from p in context.CategoriaProds
                           select p).ToList();
                return lst;
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }
    }
    public class RepoDetalleEntrada
    {
        public DetalleEntradum Get(Expression<Func<DetalleEntradum, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<DetalleEntradum> query = context.DetalleEntrada;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public List<DetalleEntradum> GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var lst = (from p in context.DetalleEntrada
                           select p).ToList();
                return lst;
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }
        public void Registrar(List<DetalleEntradum> c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.DetalleEntrada.AddRange(c);
                Save();
            }
        }

        public void Remove(DetalleEntradum c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                if (c != null)
                {
                    context.DetalleEntrada.Remove(c);
                    Save();
                }
                else { return; }
            }
        }
        public RepoDetalleEntrada() { }

        public void Update(DetalleEntradum c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.DetalleEntrada.Update(c);
                Save();
            }
        }
    }
    public class RepoFactura
    {
        public RepoFactura() { }
        public Factura Get(Expression<Func<Factura, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<Factura> query = context.Facturas;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public List<Factura> GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var lst = (from p in context.Facturas
                           select p).ToList();
                return lst;
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }
        public void Registrar(Factura c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Facturas.Add(c);
                Save();
            }
        }

        public void Remove(Factura c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                if (c != null)
                {
                    context.Facturas.Remove(c);
                    Save();
                }
                else { return; }
            }
        }

        public void Update(Factura c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Facturas.Update(c);
                Save();
            }
        }
    }

    public class RepoInventario
    {
        public RepoInventario() { }
        public Inventario Get(Expression<Func<Inventario, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<Inventario> query = context.Inventarios;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public List<Inventario> GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var lst = (from p in context.Inventarios
                           select p).ToList();
                return lst;
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }
        public void Registrar(Inventario c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Inventarios.Add(c);
                Save();
            }
        }

        public void Remove(Inventario c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                if (c != null)
                {
                    context.Inventarios.Remove(c);
                    Save();
                }
                else { return; }
            }
        }

        public void Update(Inventario c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Inventarios.Update(c);
                Save();
            }
        }
    }

    public class RepoMunicipio
    {
        public RepoMunicipio() { }

        public List<Municipio> GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                return context.Municipios.ToList();
            }
        }
    }

    public class RepoProducto
    {
        public RepoProducto() { }

        public Producto Get(Expression<Func<Producto, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<Producto> query = context.Productos;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public List<Producto> GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var lst = (from p in context.Productos
                           select p).ToList();
                return lst;
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }
        public void Registrar(Producto c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Productos.Add(c);
                Save();
            }
        }

        public void Remove(Producto c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                if (c != null)
                {
                    context.Productos.Remove(c);
                    Save();
                }
                else { return; }
            }
        }

        public void Update(Producto c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Productos.Update(c);
                Save();
            }
        }
    }

    public class RepoSalida
    {
        public RepoSalida() { }
        public Salida Get(Expression<Func<Salida, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<Salida> query = context.Salidas;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public List<Salida> GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var lst = (from p in context.Salidas
                           select p).ToList();
                return lst;
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }
        public void Registrar(Salida c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Salidas.Add(c);
                Save();
            }
        }

        public void Remove(Salida c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                if (c != null)
                {
                    context.Salidas.Remove(c);
                    Save();
                }
                else { return; }
            }
        }

        public void Update(Salida c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.Salidas.Update(c);
                Save();
            }
        }
    }

    public class RepoUsuario
    {
        public RepoUsuario() { }

        public Usuario Get(Expression<Func<Usuario, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<Usuario> query = context.Usuarios;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public void Remove(Usuario c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                if (c != null)
                {
                    context.Usuarios.Remove(c);
                    Save();
                }
                else { return; }
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }

        public ArrayList GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var ls = from p in context.Usuarios
                         select new { p.Username, p.Tipo };
                ArrayList lst = new ArrayList();

                foreach (var p in ls)
                {
                    lst.Add(p);
                }
                return lst;
            }
        }


    }

    public class RepoTipos
    {
        public RepoTipos() { }
        public List<TipoUsuario> GetTypesUsers()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                return context.TipoUsuarios.ToList();
            }
        }
    }

    public class RepoDetalleFactura
    {
        public RepoDetalleFactura() { }
        public DetalleFactura Get(Expression<Func<DetalleFactura, bool>>? filter = null, bool tracked = true)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                IQueryable<DetalleFactura> query = context.DetalleFacturas;
                if (!tracked)
                {
                    query = query.AsNoTracking();
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return query.FirstOrDefault();
            }
        }

        public List<DetalleFactura> GetAll()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                var lst = (from p in context.DetalleFacturas
                           select p).ToList();
                return lst;
            }
        }

        public void Save()
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.SaveChanges();
            }
        }
        public void Registrar(DetalleFactura c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.DetalleFacturas.Add(c);
                Save();
            }
        }

        public void Remove(DetalleFactura c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                if (c != null)
                {
                    context.DetalleFacturas.Remove(c);
                    Save();
                }
                else { return; }
            }
        }
        public void Update(DetalleFactura c)
        {
            using (ESInventarioContext context = new ESInventarioContext())
            {
                context.DetalleFacturas.Update(c);
                Save();
            }
        }
    }

}
