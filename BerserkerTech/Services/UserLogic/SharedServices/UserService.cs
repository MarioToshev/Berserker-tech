using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.User;
using BerserkerTech.Models.ViewModels.User;
using MySql.Data.MySqlClient;

namespace BerserkerTech.Services.UserLogic
{
    public class UserService : IUserService

    {
        private readonly IConfiguration _configuration;
        private DatabaseComunication _databaseComunication;


        public UserService(IConfiguration configuration)
        {
            _configuration = configuration;
            _databaseComunication = new DatabaseComunication();
        }
        public UserService()
        {
            _databaseComunication = new DatabaseComunication();
        }

        public void AddUser(UserDTO user)
        {
            string query =
            @"INSERT INTO Users(Id, FirstName, SecondName, Email, Password,Role_Id)
                 VALUES(@Id ,@FirstName,@SecondName,@Email,@Password,
                 (select Id from roles where Role_name = @RoleName));";

            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>()
                {
                    { "@Id", user.Id},
                    { "@FirstName", user.FirstName},
                    { "@SecondName", user.SecondName},
                    { "@Email", user.Email},
                    {"@Address", user.Address},
                    {"@Password", user.Password},
                    {"@RoleName", user.Role_Name}
                 });
        }



        public UserDTO GetUserByEmail(string email)
        {
            try
            {
                var query = @"Select * from users where Email = @Email";
                return _databaseComunication.Get<UserDTO>(query, new Dictionary<string, dynamic>
            {
                {"@Email", email}
            })[0];
            }
            catch (Exception)
            {

                return new UserDTO();
            }

        }
        public UserDTO GetOneUser(string email)
        {
            var query = @"Select u.Id,u.FirstName,u.SecondName,u.Password,u.PhoneNumber,u.Address, u.Email, r.Role_Name from users u
                          inner join roles r on u.Role_Id = r.Id
                          where u.Email = @Email;";
            return _databaseComunication.Get<UserDTO>(query, new Dictionary<string, dynamic>
            {
                { "@Email",email}
            })[0];
        }
        public List<UserViewModel> GetAllUsers()
        {
            var query = @"Select u.FirstName,u.SecondName,u.PhoneNumber,u.Address, u.Email, r.Role_Name from users u
                          inner join roles r on u.Role_Id = r.Id;";
            return _databaseComunication.Get<UserViewModel>(query, new Dictionary<string, dynamic>
            {
            });
        }
        public bool UserCredentialsCorrect(UserDTO userLoggingIn)
        {
            string query =
                "Select * from Users where Email = @Email";

            UserDTO userFromBase =
           _databaseComunication.Get<UserDTO>(query, new Dictionary<string, dynamic>
           {
               {"@Email", userLoggingIn.Email}
           })[0];

            if (userLoggingIn.Password == userFromBase.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ChangeRole(string roleName, string email)
        {
            var query = @"SET SQL_SAFE_UPDATES = 0;
                         update users 
                         set Role_Id = (Select Id from roles where Role_name = @RoleName)
                         where Email = @Email;
                         SET SQL_SAFE_UPDATES = 1;";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                 {"@RoleName", roleName},
                 {"@Email", email}
            });
        }

    }
}
