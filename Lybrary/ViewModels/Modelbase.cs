using Lybrary.LybrarbyDbContext;
using Lybrary.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.ViewModels
{
    public class Modelbase : INotifyPropertyChanged
    {
        public  LibraryDbContextFactory Factory { get; set; }
        public NavigationStore Nav { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public Modelbase(LibraryDbContextFactory factory, NavigationStore nav)
        {
            Factory = factory;
           Nav = nav;
        }
        public virtual void OnPropertyChanged([CallerMemberName]string propertName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertName));
        }
    }
}
