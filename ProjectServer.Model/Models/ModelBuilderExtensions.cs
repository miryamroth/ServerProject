using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer.Model.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "William",
                    Password="12345",
                    Email="mm0548425635@gmail.com",
                    Token="1234578"
                },
                new User
                {
                    Id = 2,
                    Name = "William",
                    Password = "12345",
                    Email = "mm0548425635@gmail.com",
                    Token = "1234578"
                }
            );
          
        }
    }
}
