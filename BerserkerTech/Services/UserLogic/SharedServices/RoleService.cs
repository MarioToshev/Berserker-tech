using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.User;
using BerserkerTech.Services.UserLogic.SharedServices.Interfaces;

namespace BerserkerTech.Services.UserLogic
{
    public class RoleService : IRoleService
    {
        private readonly DatabaseComunication _databaseComunication;

        public RoleService() 
        {
            _databaseComunication = new DatabaseComunication();
        }
        public void AddRole(Role role)
        {
            string query = @"insert into roles(Id,Role_name)
                             values(@Id, @Role_name)";
            _databaseComunication.InsertData(query,new Dictionary<string, dynamic> 
            {
                {"@Id",role.Id},
                {"@Role_name",role.Role_name}
            });
        }
        public Role GetRole(string roleName)
        {
            string roleQuery = @"Select * from roles where Role_Name = @Role_Name";

            return _databaseComunication.Get<Role>(roleQuery, new Dictionary<string, dynamic>
            {
                {"@Role_Name",roleName},
            })[0];
        }

        //public Role GetUserRole(string userId)
        //{
        //    string userQuery = @"Select Role_Id from users where Id = @Id";

        //    UserDTO user = _databaseComunication.Get<UserDTO>(userQuery, new Dictionary<string, dynamic>
        //    {
        //        {"@Id",userId},
        //    })[0];

        //    string roleQuery = @"Select * from roles where Id = @Id";

        //    return _databaseComunication.Get<Role>(roleQuery, new Dictionary<string, dynamic>
        //    {
        //        {"@Id",user.Role_Name},
        //    })[0];

        //}

        public void Remove(string id)
        {
            var query = @"delete from roles where Id = @Id;";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id", id}
            });
        }
    }
}
