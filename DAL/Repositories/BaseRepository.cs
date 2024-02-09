using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly PlakDükkanıDBContext _context;
        protected DbSet<T> _table;

        public BaseRepository(PlakDükkanıDBContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public void Create(T item)
        {
            _table.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _table.Find(id);
            _table.Remove(data);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public T GetById(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }

        public List<T> GetFilter(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList(); ;
        }

        public void Update(int id)
        {
            var item = _table.Find(id);
            _context.Entry<T>(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        
    }

   
}
