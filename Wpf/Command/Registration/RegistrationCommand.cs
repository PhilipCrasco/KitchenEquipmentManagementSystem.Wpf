using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Model;
using Wpf.Services;

namespace Wpf.Command.Registration
{
    public class RegistrationCommand : IRegistrationCommand
    {
        private readonly DataContext _context;

        public RegistrationCommand(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> AddUserRegistration(User user)
        {

            User users = new User
            {


                UserType = "Admin",
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Password = BCrypt.Net.BCrypt.HashPassword(user.Password),
                EmailAddres = user.EmailAddres,
            };

            await _context.AddAsync(users);
            await _context.SaveChangesAsync();

            return true;

        }
    }
}
