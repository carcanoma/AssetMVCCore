using AssetMVCCore.Data.Enitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetMVCCore.Data
{
    public class AssetDBContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
    }
}
