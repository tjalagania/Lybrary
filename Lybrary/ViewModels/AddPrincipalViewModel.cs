using Lybrary.common;
using Lybrary.LybrarbyDbContext;
using Lybrary.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.ViewModels
{
    public class AddPrincipalViewModel : Modelbase
    {
        public Array Rooles
        {
            get => Enum.GetValues(typeof(Roole));
         }
        public AddPrincipalViewModel(LibraryDbContextFactory factory, NavigationStore nav) : base(factory, nav)
        {
        }
    }
}
