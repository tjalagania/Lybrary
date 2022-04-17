using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.LybrarbyDbContext
{
    public class LbDbContextDesingFactory : IDesignTimeDbContextFactory<LbDbContext>
    {
        public LbDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder().UseSqlite("Data Source=Lybrary").Options;
            return new LbDbContext(options);

        }
    }
}
