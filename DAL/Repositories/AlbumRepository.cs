﻿using DAL.Entities.Concrate;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AlbumRepository : BaseRepository<Album>
    {
        public AlbumRepository(PlakDükkanıDBContext context) : base(context)
        {
        }
    }
}
