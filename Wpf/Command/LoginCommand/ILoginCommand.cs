using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Model;

namespace Wpf.Command.LoginCommand
{
    public interface ILoginCommand
    {
        Task<User>Authenticate(string username, string password);

    }
}
