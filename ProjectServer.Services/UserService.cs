using ProjectServer.Entities.Request;
using ProjectServer.Repository.Interfaces;
using ProjectServer.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer.Services
{
    public class UserService : IUserService
    {
        private readonly IProjectRepository _projectRepository;
        public UserService(IProjectRepository userService)
        {
            _projectRepository = userService;
        }
        public LoginResponse Login(LoginRequest request)
        {
            _projectRepository.GetUser(request.UserMail, request.Password);
            return new LoginResponse
            {
                Token = "aaaaa",
                PersonalDetails = new PersonalDetails()
                {
                    Avater = null,
                    JoinedAt = DateTime.Now,
                    Name = "miri",
                    Team = "shoshie"

                }

            };
        }
    }
    
}
