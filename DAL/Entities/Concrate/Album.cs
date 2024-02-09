using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concrate
{
    public class Album
    {
        

        public int Id { get; set; }
        public string AlbumAdi { get; set; }
        public string Sanatci { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal IndirimOrani { get; set; }
        public bool SatisDurumu { get; set; }
        public DateTime ModifiedDate  { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
