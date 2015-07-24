using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Test
{
    /// <summary>
    /// class for database interaction
    /// </summary>
    class PawnshopDbContext:DbContext
    {
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
