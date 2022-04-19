using Lybrary.Command;
using Lybrary.common;
using Lybrary.LybrarbyDbContext;
using Lybrary.LybrarbyDbContext.Services;
using Lybrary.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Lybrary.ViewModels
{
    public class LoginViewModel: Modelbase
    {

        private string? _username;
        private string? _password;

        public ICommand AuthCommand { get; }
        public string UserName
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }
        public   LoginViewModel(LibraryDbContextFactory factory, NavigationStore nav)
            :base(factory,nav)
        {
            AuthCommand = new LybraryCommand(nav, ChangeModel );
        }
        
        private async Task<Modelbase> ChangeModel()
        {
            if(string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(UserName))
            {
                MessageBox.Show("შეავსეთ ყველა ველი", "გაფრთხილება", MessageBoxButton.OK, MessageBoxImage.Warning);
                return this;
            }
            UserManager usmanager = new UserManager(Factory);
            var principal = await usmanager.GetDboject(UserName, Password);
            if(principal == null)
            {
                MessageBox.Show("ვერ მოიძებნა მომხარებელი");
                return this;
            }
            AdminPanelViewModel admpvm = new(Factory, Nav);
            admpvm.UserName = UserName;
            return admpvm;
        
        }
    }
}
