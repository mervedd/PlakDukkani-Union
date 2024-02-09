using DAL.Context;
using DAL.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KullaniciRepository : BaseRepository<Kullanici>
    {
        public KullaniciRepository(PlakDükkanıDBContext context) : base(context)
        {
        }
    }
}
