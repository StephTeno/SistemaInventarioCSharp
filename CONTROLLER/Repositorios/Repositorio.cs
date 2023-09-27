using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using MODELO.Data;
using MODELO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLER.Repositorios
{
    public class Repositorio<T> where T : class
    {
        private readonly ESInventarioContext _db;
        private DbSet<T> dbSet;

        public Repositorio(ESInventarioContext db)
        {
            _db = db;
            dbSet = db.Set<T>();
        }
        public List<T> GetAll()
        {
            var lst = (from p in dbSet
                       select p).ToList();
            return lst;
        }

        public T Get(Expression<Func<T, bool>>? filter = null, bool tracked = true)
        {
            IQueryable<T> query = dbSet;
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
        public void Remove(T entity)
        {
            if (entity != null)
            {
                dbSet.Remove(entity);
                Save();
            }
            else { return; }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Registrar(T entity)
        {
            dbSet.Add(entity);
            Save();
        }
    }
}
