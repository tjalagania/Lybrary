using lybrarbyModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.LybrarbyDbContext
{
    public class LbDbContext : DbContext
    {
        public LbDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Artical> Artists { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<Copy> Copys { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Author>Authors { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Credential>Credentials { get; set; }
    }
}
