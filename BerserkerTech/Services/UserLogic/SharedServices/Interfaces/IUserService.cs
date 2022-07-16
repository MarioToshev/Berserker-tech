using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.User;
using BerserkerTech.Models.ViewModels.User;

namespace BerserkerTech.Services.UserLogic
{
    public interface IUserService
    {
        public void AddUser(UserDTO user);
       // public void UpdateUser(UserViewModel user);
      //  public void DeleteUser(string Id);
        //public void GetAllUsers();
        public UserDTO GetOneUser(string Id);
        public bool UserCredentialsCorrect(UserDTO user);
        public UserDTO GetUserByEmail(string email);
    }
}
