using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Model;
using Wpf.Services;

namespace Wpf.Command.LoginCommand
{
    public class LoginCommand : ILoginCommand
    {
        private readonly DataContext _context;

        public LoginCommand(DataContext context)
        {
            _context = context;
        }

        public async Task<User> Authenticate(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (user == null)
            {
                return null; 
            }

            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                
                return user;
            }

            return null;

        }
    }
}
