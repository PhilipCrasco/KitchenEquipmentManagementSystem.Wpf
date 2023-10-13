using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Wpf.Command.LoginCommand;
using Wpf.Command.Registration;

namespace Wpf.Services.Unitofwork
{
    public interface IUnitofwork
    {

         ILoginCommand Login { get; }
        IRegistrationCommand Registration { get; }
    }
}
