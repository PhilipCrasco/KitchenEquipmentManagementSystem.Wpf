using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Model;

namespace Wpf.Command.Registration
{
    public interface IRegistrationCommand
    {

        Task<bool> AddUserRegistration(User user);

    }
}
