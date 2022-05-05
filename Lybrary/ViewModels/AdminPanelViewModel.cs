using Lybrary.Command;
using Lybrary.common;
using Lybrary.LybrarbyDbContext;
using Lybrary.LybrarbyDbContext.Services;
using Lybrary.Navigation;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Lybrary.ViewModels
{
    public class AdminPanelViewModel : Modelbase
    {
        private Modelbase? _curretnView;
        public Modelbase? CurrentView
        {
            get => _curretnView;
            set
            {
                _curretnView = value;
                OnPropertyChanged(nameof(CurrentView));
            }

        }
        #region Commands
        public ICommand? ShowListPrincipalCommand { get; }
       
        private async void showListMethod(object obj)
        {
            if (obj is Roole roole)
            {
                UserManager usm = new UserManager(Factory);
                ShowPrincipalViewModel shpr = new ShowPrincipalViewModel(Factory, null);
                shpr.Principals = new ObservableCollection<Principal>();
                await foreach(var rp in  usm.GetAllLibraryan(roole))
                {
                    shpr.Principals.Add(rp);
                }
               
                if (shpr.Principals.Count > 0)
                    CurrentView = shpr;
                else
                {
                    string msg = "";
                    switch (roole)
                    {
                        case Roole.Lybrarian:
                            msg = "The Libraryans";
                            break;
                        case Roole.Student:
                            msg = "The Students";
                            break;
                    }
                    var excv = new ExceptionViewModel(null, null);
                    excv.Message = msg;
                    CurrentView = excv;
                }
                   
                OnPropertyChanged(nameof(CurrentView));

            }
        }
        public ICommand? ShowAddPrincipalCommand { get; }
        private void ShowAddPrincipalMethod(object obj)
        {
            Roole roole = (Roole)obj;
            CurrentView = new AddPrincipalViewModel(Factory, null,roole);
        }
        #endregion
        public AdminPanelViewModel(LibraryDbContextFactory factory, NavigationStore navStore)
            : base(factory, navStore)
        {
            
            ShowListPrincipalCommand = new WithoutNavCommand(showListMethod);
            ShowAddPrincipalCommand = new WithoutNavCommand(ShowAddPrincipalMethod);
        }

        

        private string? _username;
        public string? UserName
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
