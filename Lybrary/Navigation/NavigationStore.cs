using Lybrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.Navigation
{
    public class NavigationStore
    {
        private Modelbase? _modelBase;
        public event Action? ChangeView;
        public Modelbase CurrentView
        {
            get => _modelBase;
            set
            {
                _modelBase = value;
                OnChangeView();
            }
        }
        private void OnChangeView()
        {
            ChangeView?.Invoke();
        }
    }
}
