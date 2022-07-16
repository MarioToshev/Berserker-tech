namespace BerserkerTech.Models.DTOs.User
{
    public class Role
    {
        private string id;
        private string roleName;

        public Role(string roleName)
        {
            Id = Guid.NewGuid().ToString(); ;
            Role_name = roleName;

        }
        public Role(){}

        public string Role_name
        {
            get { return roleName; }
            set { roleName = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
