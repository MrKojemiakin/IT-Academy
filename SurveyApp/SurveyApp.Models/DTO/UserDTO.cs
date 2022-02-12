using SurveyApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Models.DTO
{
    public class UserDTO

    {
        public UserDTO()
        {

        }
        public UserDTO(User user)
        {
            Id = user.Id;
            Login= user.Login;
            Password= user.Password;
            IsAdmin= user.IsAdmin;
        }
        public int Id { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        
    }
}
