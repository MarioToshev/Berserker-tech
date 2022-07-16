using BerserkerTech.Models.DTOs.User;

namespace BerserkerTech.Services.UserLogic.SharedServices.Interfaces
{
    public interface IRoleService
    {
        public void AddRole(Role role);
        //public Role GetUserRole(string userId);
        public void Remove(string id);
        public Role GetRole(string roleName);
    }
}
