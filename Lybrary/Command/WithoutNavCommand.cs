using Lybrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.Command
{
    public class WithoutNavCommand : BaseCommand
    {
        private readonly Func<object,bool> _modelbase;
        private readonly Action<object> _execute;

        public WithoutNavCommand(Action<Object>execute,Func<object,bool>modelbase=null)
        {
            _modelbase = modelbase;
            _execute = execute;
        }
        public override void Execute(object? parameter) => _execute(parameter);
    }
}
