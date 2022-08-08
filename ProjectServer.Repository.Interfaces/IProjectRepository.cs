using ProjectServer.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer.Repository.Interfaces
{
    public interface IProjectRepository
    {
        UserDTO GetUser(string password, string email);
       
        }
}
