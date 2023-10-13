using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Wpf.Command;
using Wpf.ErrorHandler.RegistrationErrorHandler;
using Wpf.Model;
using Wpf.Services.Unitofwork;
using Wpf.View.Login;
using Wpf.ViewModel.Login;

namespace Wpf.ViewModel.Registration
{
    public class RegistrationViewModel : ViewModelBase
    {

        private readonly IUnitofwork _unitofwork;
        private string _Username;
        private string _Password;    
        private string _Email;
        private string _Firstname;
        private string _Lastname;
        private readonly RegistrationErrorHandler _registrationErrorHandler;



        public string UserName 
        { 
            get => _Username; 
            set => SetProperty(ref _Username, value);
        
        }

        public string Password
        {
            get => _Password;
            set => SetProperty(ref _Password, value);
        }

        public string Email
        {
            get => _Email;
            set => SetProperty(ref _Email, value);
        }

        public string FirstName
        {
            get => _Firstname;
            set => SetProperty(ref _Firstname, value);
        }

        public string LastName
        {
            get => _Lastname;
            set => SetProperty(ref _Lastname, value);
        }


        public ICommand RegisterUserCommand { get; }
        public ICommand LogInModuleCommand { get; }




        public RegistrationViewModel(IUnitofwork unitofwork)
        {
            _unitofwork = unitofwork;

            RegisterUserCommand = new RelayCommand(async _ => await RegisterNewUser());
            LogInModuleCommand = new RelayCommand(_ => LogInModule());

            _registrationErrorHandler = new RegistrationErrorHandler();
        }

        public void LogInModule()
        {
            var loginPageViewModel = new LoginViewModel(_unitofwork);

            var loginPageView = new LoginView();
            loginPageView.DataContext = loginPageViewModel;

            var mainWindow = Application.Current.MainWindow;
            mainWindow.Content = loginPageView;
        }

        private async Task RegisterNewUser()
        {

            User user = new User
            {
                FirstName = FirstName,
                LastName = LastName,
                EmailAddres = Email,
                UserName = UserName,
                Password = Password,          
            };


            if(user.FirstName == null || user.FirstName == string.Empty)
            {
              _registrationErrorHandler.FullNameNull();
            }
            else if (user.LastName == null || user.LastName == string.Empty)
            {
                _registrationErrorHandler.LastNameNull();   
            }
            else if (user.EmailAddres == null || user.EmailAddres == string.Empty)
            {
                _registrationErrorHandler.EmailNull();
            }
            else if (user.UserName == null || user.UserName == string.Empty)
            {
                _registrationErrorHandler.UserNameNull();
            }
            else if (user.Password == null || user.Password == string.Empty)
            {
                _registrationErrorHandler.PasswordNull();
            }
            else
            {

                await _unitofwork.Registration.AddUserRegistration(user);
                _registrationErrorHandler.RegistrationSuccess();

                FirstName = string.Empty;
                LastName = string.Empty;
                Email = string.Empty; 
                UserName = string.Empty;
                Password = string.Empty; 

            }



        }


    }
}
