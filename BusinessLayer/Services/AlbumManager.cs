using DAL.Context;
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
    public  class AlbumManager
    {
        AlbumRepository _albumRepository;

        public AlbumManager(AlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
        public void create(Album item)
        {
            _albumRepository.Create(item);
        }
        public void Update(int id) {
            _albumRepository.Update(id);
        }
        public void Delete(int id )
        {
            _albumRepository.Delete(id);
        }
        public List<Album> GetAll()
        {
            return _albumRepository.GetAll();
        }
        public  Album GetById(Expression<Func<Album, bool>> expression)
        {
            return _albumRepository.GetById(expression);
        }
        public List<Album> GetFilter(Expression<Func<Album, bool>> expression)
        {
            return _albumRepository.GetFilter(expression);
        }
    }
}
