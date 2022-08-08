using ProjectServer.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer.Services.interfaces
{
    public interface IUserService
    {
        LoginResponse Login(LoginRequest request);
    }
}
