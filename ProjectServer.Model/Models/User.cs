using System;
using System.Collections.Generic;

namespace ProjectServer.Model.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
        public string Token { get; set; } 
        public string Name { get; set; }
    }
}
