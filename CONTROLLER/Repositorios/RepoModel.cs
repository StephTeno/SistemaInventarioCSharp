using MODELO.Data;
using MODELO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLER.Repositorios
{
    public class RepoCliente : Repositorio<Cliente>
    {
        private readonly ESInventarioContext _db;
        public RepoCliente(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(Cliente c)
        {
            _db.Clientes.Update(c);
            Save();
        }
    }
    public class RepoProve : Repositorio<Proveedore>
    {
        private readonly ESInventarioContext _db;
        public RepoProve(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(Proveedore c)
        {
            _db.Proveedores.Update(c);
            Save();
        }
    }

    public class RepoEntrada : Repositorio<Entrada>
    {
        private readonly ESInventarioContext _db;
        public RepoEntrada(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(Entrada c)
        {
            _db.Entradas.Update(c);
            Save();
        }
    }

    public class RepoCategoriaProd : Repositorio<CategoriaProd>
    {
        private readonly ESInventarioContext _db;
        public RepoCategoriaProd(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(CategoriaProd c)
        {
            _db.CategoriaProds.Update(c);
            Save();
        }
    }

    public class RepoDetalleEntrada : Repositorio<DetalleEntradum>
    {
        private readonly ESInventarioContext _db;
        public RepoDetalleEntrada(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(DetalleEntradum c)
        {
            _db.DetalleEntrada.Update(c);
            Save();
        }
    }

    public class RepoFactura : Repositorio<Factura>
    {
        private readonly ESInventarioContext _db;
        public RepoFactura(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(Factura c)
        {
            _db.Facturas.Update(c);
            Save();
        }
    }

    public class RepoInventario : Repositorio<Inventario>
    {
        private readonly ESInventarioContext _db;
        public RepoInventario(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(Inventario c)
        {
            _db.Inventarios.Update(c);
            Save();
        }
    }

    public class RepoDepartamento : Repositorio<Departamento>
    {
        private readonly ESInventarioContext _db;
        public RepoDepartamento(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(Departamento c)
        {
            _db.Departamentos.Update(c);
            Save();
        }
    }

    public class RepoMunicipio : Repositorio<Municipio>
    {
        private readonly ESInventarioContext _db;
        public RepoMunicipio(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(Municipio c)
        {
            _db.Municipios.Update(c);
            Save();
        }
    }

    public class RepoProducto : Repositorio<Producto>
    {
        private readonly ESInventarioContext _db;
        public RepoProducto(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(Producto c)
        {
            _db.Productos.Update(c);
            Save();
        }
    }

    public class RepoSalida : Repositorio<Salida>
    {
        private readonly ESInventarioContext _db;
        public RepoSalida(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(Salida c)
        {
            _db.Salidas.Update(c);
            Save();
        }
    }

    public class RepoUsuario : Repositorio<Usuario>
    {
        private readonly ESInventarioContext _db;
        public RepoUsuario(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(Usuario c)
        {
            _db.Usuarios.Update(c);
            Save();
        }
    }

    public class RepoDetalleFactura : Repositorio<DetalleEntradum>
    {
        private readonly ESInventarioContext _db;
        public RepoDetalleFactura(ESInventarioContext db) : base(db) { _db = db; }

        public void Update(DetalleEntradum c)
        {
            _db.DetalleEntrada.Update(c);
            Save();
        }
    }

}
