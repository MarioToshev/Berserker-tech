using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.ViewModels.User;

namespace BerserkerTech.Services.UserLogic.DesktopOnlyService
{
    public class DesktopLogInService
    {
        private static UserDTO _loggedUser;
        private DatabaseComunication _databaseComunication;
        private readonly RoleService _roleService;
        private readonly UserService _userService;



        public DesktopLogInService()
        {
            _databaseComunication = new DatabaseComunication();
            _userService = new UserService();
            _roleService = new RoleService();
        }
        public bool LogIn(string email, string password)
        {
           var user = _userService.GetOneUser(email);
            if (user != null)
            {
                if (user.Password == password &&( user.Role_Name == "Builder" || user.Role_Name == "Admin"))
                {
                    _loggedUser = new UserDTO();
                    _loggedUser = user;
                }
                return true;
            }
            return false;
        }
        public UserDTO GetLoggedUser()
        {
            return _loggedUser;
        }
        public void LogOut()
        {
            _loggedUser = null;
        }
    }
}
