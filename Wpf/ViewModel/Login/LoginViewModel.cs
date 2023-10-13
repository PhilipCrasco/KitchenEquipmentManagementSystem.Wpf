
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Wpf.Command;
using System.Security;
using System.Diagnostics;
using Wpf.Services;
using Wpf.Model;
using Microsoft.EntityFrameworkCore;
using Wpf.Command.LoginCommand;
using Wpf.View.Login;
using Wpf.View.LandingPage;
using Wpf.ViewModel.LandingPage;
using Wpf.Services.Unitofwork;
using Wpf.ErrorHandler.LoginErrorHandler;
using Wpf.View.Registration;
using Wpf.ViewModel.Registration;

namespace Wpf.ViewModel.Login
{
    public class LoginViewModel : ViewModelBase
    {
        //private readonly ILoginCommand _loginCommand;
        private readonly IUnitofwork _unitofwork;
        private string _username;
        private string _password;
        private string _errorMessage;
        private readonly LoginErrorHandler _loginErrorHandler;


        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        public ICommand LoginCommand { get; }
        public ICommand RegistrationCommand { get; }

        public LoginViewModel(IUnitofwork unitofwork)
        {
            _unitofwork = unitofwork;
            _loginErrorHandler = new LoginErrorHandler();
            LoginCommand = new RelayCommand(async _ => await LoginAsync());
            RegistrationCommand = new RelayCommand( _ => RegistrationModule());
        }

        public void RegistrationModule()
        {

            var registrationPageViewModel = new RegistrationViewModel(_unitofwork);

            var registrationPageView = new RegistrationView();
            registrationPageView.DataContext = registrationPageViewModel;

            var mainWindow = Application.Current.MainWindow;
            mainWindow.Content = registrationPageView;



            
        }

        public async Task LoginAsync()
        {
            try
            {
                var user = await _unitofwork.Login.Authenticate(Username, Password);
                if (user != null)
                {
                    var landingPageViewModel = new LandingPageViewModel(user);

                    var landingPageView = new LandingPageView();
                    landingPageView.DataContext = landingPageViewModel;

                    var mainWindow = Application.Current.MainWindow;
                    mainWindow.Content = landingPageView;

                    //var mainWindowViewModel = new MainWindowViewModel(user);
                    //App.Current.MainWindow.DataContext = mainWindowViewModel;

                    _loginErrorHandler.LoginSuccess(user.FirstName , user.LastName);
                   
                }
                else
                {
                    _loginErrorHandler.LoginFailed(); 
                  
                }
        }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
}


    }
}

