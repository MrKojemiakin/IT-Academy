using SurveyApp.Interfaces.BL;
using SurveyApp.Interfaces.Data;
using SurveyApp.Models.DTO;
using SurveyApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.BL.Services
{
    public class UserService : IUserService
    {
        public static UserDTO CurrentUser;
        private readonly IGenericRepository genericRepository;

        public UserService(IGenericRepository genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public bool LoginUser(string login, string password)
        {
            var user = genericRepository.Get<User>().FirstOrDefault(x => x.Login == login);
            if (user != null)
            {
                CurrentUser = new UserDTO(user);
                return CurrentUser.Password == password;
            }
            CurrentUser = null;
            return false;
        }

        public int AddUser(UserDTO userDTO)
        {
            var user = new User()
            {
                IsAdmin = userDTO.IsAdmin,
                Login = userDTO.Login,
                Password = userDTO.Password,
            };
            genericRepository.Create<User>(user);
           
            return user.Id;
        }
    }
}
