using Lybrary.LybrarbyDbContext;
using Lybrary.Navigation;
using Lybrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.ViewModels
{
    public class MainViewModel: Modelbase
    {
        private readonly LibraryDbContextFactory? _factory;
        private readonly NavigationStore? nav;

        public Modelbase CurrentView { get; set; }
       

        public MainViewModel(LibraryDbContextFactory factory,NavigationStore nav)
            :base(factory,nav)
        {
            Nav.CurrentView = new LoginViewModel(factory,nav);
            CurrentView = Nav.CurrentView;
            Nav.ChangeView += changeview;
        }

        private void changeview()
        {
            CurrentView = Nav.CurrentView;
            OnPropertyChanged(nameof(CurrentView));
        }
    }
}
