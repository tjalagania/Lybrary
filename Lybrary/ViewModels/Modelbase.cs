using Lybrary.LybrarbyDbContext;
using Lybrary.Navigation;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
