using DAL.Entities.Concrate;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class KullaniciManager
    {
        KullaniciRepository _kullaniciRepository;
        

        public KullaniciManager(KullaniciRepository kullaniciRepository)
        {
            _kullaniciRepository = kullaniciRepository;
        }
        public void Create( Kullanici item)
        {

            _kullaniciRepository.Create(item);
        }
        public void Update(int id)
        {
            _kullaniciRepository.Update(id);
        }
        public void Delete(int id)
        {
            _kullaniciRepository.Delete(id);
        }
        public List<Kullanici> GetAll()
        {
            return _kullaniciRepository.GetAll();
        }
        public Kullanici GetById(Expression<Func<Kullanici, bool>> expression)
        {
            return _kullaniciRepository.GetById(expression);
        }
        public List<Kullanici> GetFilter(Expression<Func<Kullanici, bool>> expression)
        {
            return _kullaniciRepository.GetFilter(expression);
        }
    }
}
