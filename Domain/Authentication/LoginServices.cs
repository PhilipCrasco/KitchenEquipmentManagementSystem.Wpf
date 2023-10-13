using Domain.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Authentication
{
    public class LoginServices : ILoginServices
    {
        private readonly DataContext _context;
        //private readonly IConfiguration _configuration;

        public LoginServices(DataContext context )
        {
            _context = context;
        
        }


        public async Task<AuthenticateResponse> AuthenticateAsync(AuthenticateRequest request)
        {
            var user =  _context.Users.SingleOrDefault(x => x.UserName == request.Username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.Password))
                return null;

            return new AuthenticateResponse(user);
        }




    }
}
