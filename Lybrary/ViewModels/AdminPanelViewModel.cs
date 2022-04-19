using Lybrary.Command;
using Lybrary.LybrarbyDbContext;
using Lybrary.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.ViewModels
{
    public class AdminPanelViewModel: Modelbase
    {
        public AdminPanelViewModel(LibraryDbContextFactory factory,NavigationStore navStore)
            :base(factory,navStore)
        {

        }
        private string _username;
        public string UserName
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        
    }
}
