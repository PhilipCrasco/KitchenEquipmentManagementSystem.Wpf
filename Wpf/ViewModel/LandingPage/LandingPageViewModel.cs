using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Model;

namespace Wpf.ViewModel.LandingPage
{
    public class LandingPageViewModel : ViewModelBase
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
                    OnPropertyChanged(); // Notify that the property has changed
                }
            }
        }



        public LandingPageViewModel(User user)
        {

            _user = user;
            
        }



    }
}
