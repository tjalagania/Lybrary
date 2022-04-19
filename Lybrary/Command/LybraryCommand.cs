using Lybrary.Navigation;
using Lybrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.Command
{
    public class LybraryCommand : BaseCommand
    {
        
        private readonly NavigationStore navS;
        private readonly Func<Task<Modelbase>> modelBase;

        public LybraryCommand(NavigationStore navS,Func<Task<Modelbase>> modelBase)
        {
            this.navS = navS;
            this.modelBase = modelBase;
        }
        public override async void Execute(object? parameter)
        {
            navS.CurrentView = await modelBase();
        }
    }
}
