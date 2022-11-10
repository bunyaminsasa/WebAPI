using Alice.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice.DataAccess
{
    public class MSSQLDbContext : DbContext
    {
        public MSSQLDbContext()
        {
        }

        public MSSQLDbContext(DbContextOptions<MSSQLDbContext> opt) : base(opt)
        {

        }


        public DbSet<Ogrenci> Ogrenci { get; set; }

    }
}
