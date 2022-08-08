using Microsoft.Extensions.DependencyInjection;
using ProjectServer.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer.Repository
{
    public static class DIConfig
    {
        public static void AddDIReository(this IServiceCollection services)
        {
            services.AddScoped<IProjectRepository, ProjectRepository>();
        }
    }
}
