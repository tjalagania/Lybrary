using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.LybrarbyDbContext
{
    public class LibraryDbContextFactory
    {
        private readonly string _connectionString;
        public LibraryDbContextFactory(string connectioString)
        {
            _connectionString = connectioString;
        }
        public LbDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;
            return new LbDbContext(options);

        }
    }
}
