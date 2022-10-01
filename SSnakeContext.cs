using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SSnake
{
    internal class SSnakeContext : DbContext
    {
        public DbSet<Record> Records { get; set; } = null!;
        public SSnakeContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SSnakeDB.db");
        }
    }
}
