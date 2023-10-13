using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Authentication
{
    public class AuthenticateResponse 
    {
        public int UserId { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }

        public AuthenticateResponse(User user)
        {
            UserId = user.UserId;
            UserType = user.UserType;
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;
            Password = user.Password;
            EmailAddress = user.EmailAddres;
        }



    }
}
