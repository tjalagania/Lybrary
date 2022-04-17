using Lybrary.LybrarbyDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Lybrary
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CON_STRING = "Data Source = Lybrary.db";
        protected override void OnStartup(StartupEventArgs e)
        {

            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CON_STRING).Options;
            LbDbContext context = new LbDbContext(options);
            context.Database.Migrate();

            base.OnStartup(e);
        }
    }
}
