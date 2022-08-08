using AutoMapper;
using Microsoft.Extensions.Configuration;
using ProjectServer.Entities.DTO;
using ProjectServer.Model;
using ProjectServer.Model.Models;
using ProjectServer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer.Repository
{
    public class ProjectRepository: IProjectRepository
    {
        //public ProjectLocalDBContext _context;


        public ProjectRepository()
        {
           // this.config = iconfig;
          //  this._context = context;
        }

        public UserDTO GetUser(string password, string email)
        {
            using (ProjectLocalDBContext context = new ProjectLocalDBContext())
            {
                var u = context.Users.ToList();
                return null;
            }
           
        }
    }
}
