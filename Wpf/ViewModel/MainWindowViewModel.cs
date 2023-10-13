
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Command.LoginCommand;
using Wpf.Model;
using Wpf.Services;
using Wpf.ViewModel.Login;

namespace Wpf.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly User _user;

        public string UserType => _user.UserType;
        public string Username
        {
            get => _user.UserName;
            set
            {
                if (_user.UserName != value)
                {
                    _user.UserName = value;
                    OnPropertyChanged(); 
                }
            }
        }

        public MainWindowViewModel(User user)
        {
            _user = user;
        }

    }
}
