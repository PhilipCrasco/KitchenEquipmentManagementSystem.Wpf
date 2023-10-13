using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Command.LoginCommand;
using Wpf.Command.Registration;

namespace Wpf.Services.Unitofwork
{
    public class Unitofwork : IUnitofwork
    {

        private readonly DataContext _context;
        public ILoginCommand Login { get; set; }
        public IRegistrationCommand Registration { get; set; }

        public Unitofwork(DataContext context)
        {

            _context = context;

            Login = new LoginCommand(_context);
            Registration = new RegistrationCommand(_context);   
        }


    }
}
