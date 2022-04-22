using Lybrary.LybrarbyDbContext;
using Lybrary.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.ViewModels
{
    public class ExceptionViewModel:Modelbase
    {
        public ExceptionViewModel(LibraryDbContextFactory factory, NavigationStore nav) : base(factory, nav)
        {
        }

        private string _msg;
        public string Message
        {
            get => _msg;
            set
            {
                _msg = value;
                OnPropertyChanged(value);
            }
        }

    }
}
