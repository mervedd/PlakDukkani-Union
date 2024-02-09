
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Create(T item);
        void Update(int id);
        void Delete(int id);
        List<T> GetAll();
        T GetById(Expression<Func<T, bool>> expression);
        List<T> GetFilter(Expression<Func<T, bool>> expression);
    }
}
