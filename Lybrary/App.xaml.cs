using Lybrary.common;
using Lybrary.LybrarbyDbContext;
using Lybrary.LybrarbyDbContext.Services;
using Lybrary.Navigation;
using Lybrary.ViewModels;
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
            LibraryDbContextFactory factory = new LibraryDbContextFactory(CON_STRING);
            using (LbDbContext context = factory.CreateDbContext())
            {
                context.Database.Migrate();
            }


            NavigationStore navStore = new NavigationStore();
            MainWindow m = new MainWindow()
            {
                DataContext = new MainViewModel(factory,navStore)
            };
            m.Show();
            base.OnStartup(e);
        }
    }
}
