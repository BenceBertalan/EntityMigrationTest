using EntityMigrationTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EntityMigrationTest.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }
    }
}
