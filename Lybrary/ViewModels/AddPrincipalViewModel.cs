using Lybrary.Command;
using Lybrary.common;
using Lybrary.LybrarbyDbContext;
using Lybrary.LybrarbyDbContext.Services;
using Lybrary.Navigation;
using System.ComponentModel;
using System.Net.Mail;
using System.Windows.Input;

namespace Lybrary.ViewModels
{
    public class AddPrincipalViewModel : Modelbase, IDataErrorInfo
    {

        public string Error
        {
            get
            {
               
                return "Is Not Valid";
            }

        }
       
        #region ModelFields
        private Principal _pricipal;
        private bool _isValid = false;
        public bool IsValid
        {
            get { return _isValid; }
            set
            {
                _isValid = value;
            }
        }
        public Principal Librarian {

            get => _pricipal;

            set
            {
                _pricipal = value;
                OnPropertyChanged(nameof(Librarian));
            }
        }

        private string _error = "";
        private string _merror = "";
        public string MError
        {
            get => _merror;
            set
            {
                _merror = value;
                OnPropertyChanged(nameof(MError));
            }
           
        }

        public string ErrorMessage
        {
            get => _error;
            set
            {
                _error = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public string Name
        {
            get => Librarian.Name;
            set
            {
                Librarian.Name = value; ;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Phone
        {
            get => Librarian.Phone;
            set
            {

                Librarian.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }
        public string Email
        {
            get => Librarian.Email;
            set
            {

                if (MailAddress.TryCreate(value, out MailAddress? mail))
                {
                    Librarian.Email = mail.Address;
                    emailValid = true;
                    OnPropertyChanged(nameof(Email));

                }
            }
        }
        private bool emailValid = true;
        public string Password
        {
            get => Librarian.Password;
            set {
                Librarian.Password = value;    
            }
        }
        public string ConfimPassword
        {
            get;set;
        }
        public string UserName
        {
            get => Librarian.UserName;
            set
            {
                Librarian.UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        #endregion
        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Name):
                        if (string.IsNullOrWhiteSpace(Name))
                        {
                            ErrorMessage = $"Username Can't Empty";

                            return ErrorMessage;
                        }

                        break;
                    case (nameof(Phone)):
                        if (string.IsNullOrWhiteSpace(Phone))
                        {


                            return "Phone Can't be empti";
                        }


                        break;
                    case nameof(Email):
                        if (string.IsNullOrWhiteSpace(Email))
                        {
                            emailValid = false;
                            return "Email is not be empty";
                        }
                        else if (!MailAddress.TryCreate(Email, out MailAddress? mail))
                        {
                            emailValid = false;
                            return "Email is not valid";

                        }

                        break;
                    case nameof(UserName):
                        if (string.IsNullOrWhiteSpace(UserName))
                        {

                            return "UserName can't be null";
                        }
                        break;
                    case nameof(Password):
                        if (string.IsNullOrWhiteSpace(Password))
                        {
                            return "Password Can't be null";
                        }
                        break;

                        
                }

                return string.Empty;
            }
        }
        #region commnads
        public ICommand AddPrincipalCommand { get; }
        public ICommand EnterTextBoxCommand { get; }
        private void EnterTextBoxMethod(object obj)
        {
            MError = "";
        }
        private  void AddPrincipalMethod(object obj)
        {
            if (string.IsNullOrWhiteSpace(Name)
                 || string.IsNullOrWhiteSpace(Phone)
                 || string.IsNullOrWhiteSpace(UserName)
                 || string.IsNullOrWhiteSpace(Email)
                 
                 || string.IsNullOrWhiteSpace(Password)
                 )
            {
                MError = "Please fill in all the fields, double-click to return to the field";
                return;
            }
            if (!emailValid)
            {
                MError = "Email Address Is not valid, double-click to return to the field";
                return;
            }
            if (!Librarian.ConfirmPassword(Password, ConfimPassword))
            {
                MError = "Password is not equals ConfimPassword, double-click to return to the field";
                return;
            }
            UserManager usmanager = new UserManager(Factory);
            usmanager.SetDbObject(Librarian);

            MError = "Operation Successfull";
            Name = Email = Password = UserName = Phone = ConfimPassword = "";
        }
        #endregion

        public AddPrincipalViewModel(LibraryDbContextFactory factory, NavigationStore nav,Roole roole) : base(factory, nav)
        {
            
            switch (roole)
            {
                case Roole.Lybrarian:
                    Librarian = new Libraryan();
                    break;
                case Roole.Student:
                    Librarian = new Student();
                    break;
            }
            AddPrincipalCommand = new WithoutNavCommand(AddPrincipalMethod);
            EnterTextBoxCommand = new WithoutNavCommand(EnterTextBoxMethod);
        }

        
    }
}
