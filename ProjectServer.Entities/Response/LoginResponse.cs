using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServer.Entities.Request
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public DateTime JoinedAt { get; set; }
        public string Avater { get; set; }
    }
    public class LoginResponse
    {
        public string Token { get; set; }
        public PersonalDetails PersonalDetails { get; set; }
     
      
    
}
}
