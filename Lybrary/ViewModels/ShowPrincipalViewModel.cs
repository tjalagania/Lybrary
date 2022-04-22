using Lybrary.common;
using Lybrary.LybrarbyDbContext;
using Lybrary.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.ViewModels
{
    public class ShowPrincipalViewModel : Modelbase
    {
        private ObservableCollection<Principal>? _principal;
        public ObservableCollection<Principal> Principals
        {
            get => _principal;
            set
            {
                _principal = value;
                OnPropertyChanged(nameof(Principal));
            }
        }
        public ShowPrincipalViewModel(LibraryDbContextFactory factory, NavigationStore nav) : base(factory, nav)
        {
        }
    }
}
