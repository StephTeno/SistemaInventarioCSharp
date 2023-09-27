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

}
