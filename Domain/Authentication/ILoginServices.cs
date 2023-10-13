using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Authentication
{
    public interface ILoginServices
    {
        Task<AuthenticateResponse> AuthenticateAsync(AuthenticateRequest request);

    }
}
