using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreMvc.Models
{
    public class WarehouseContext:DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options):base(options)
        {
        }
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}
