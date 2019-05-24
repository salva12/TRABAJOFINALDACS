using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using CapaAccesoAntecedentes.Models;

namespace CapaAccesoAntecedentes.Repositorio
{
   public class RepositorioAntecedentes<T>:InterfaceAntecedentes<T> where T : class
    {
         
        internal DbContext _context;

        public RepositorioAntecedentes()
        {
            //  using (var dbc = new InternacContext()) {
            //      _context = dbc;
            //};

        }

        public RepositorioAntecedentes(DbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            using (var dataContext = new AntContext())
            {
                dataContext.Set<T>().Add(entity);
                dataContext.SaveChanges();
            }

        }

        public void Delete(T entity)
        {
            using (var dataContext = new AntContext())
            {
                dataContext.Set<T>().Remove(entity);
                dataContext.SaveChanges();
            }
        }

        public void Edit(T entity)
        {
            using (var dataContext = new AntContext())
            {

                dataContext.Entry(entity).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            using (var dataContext = new AntContext())

            {
                IQueryable<T> query = dataContext.Set<T>().Where(predicate);
                return query;
            }
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            //dataContext.SaveChanges();
        }
    }

}
