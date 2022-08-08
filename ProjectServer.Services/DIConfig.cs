using Microsoft.Extensions.DependencyInjection;
using ProjectServer.Repository;
using ProjectServer.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer.Services
{
    public static class DIConfig
    {

        public static void AddDIServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddDIReository();
        }


    }
}
