using SurveyApp.Models.DTO;

namespace SurveyApp.Interfaces.BL
{
    public interface IUserService
    {
        int AddUser(UserDTO userDTO);
        bool LoginUser(string login, string password);
    }
}