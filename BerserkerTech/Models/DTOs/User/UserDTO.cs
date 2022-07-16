using BerserkerTech.Models.DTOs.User;
using System.ComponentModel.DataAnnotations;

namespace BerserkerTech.Models.DTOs
{
    public class UserDTO
    {
        private string id;
        private string firstNae;
        private string secondName;
        private string password;
        private string email;
        private string address;
        private string role_name;
        public Role role { get; set; }



        private Cart cart;

        public UserDTO(Cart cart, string password, string lastName, string firstName, string id, string role_id)
        {
            Cart = cart;
            Password = password;
            SecondName = lastName;
            FirstName = firstName;
            Id = id;
            Role_Name = role_id;
        }
        public UserDTO()
        {
            id = Guid.NewGuid().ToString();
            role = new Role();
        }
      
        public string? Role_Name 
        {
            get { return role_name; }
            set { role_name = value; }

        } 
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Cart Cart
        {
            get { return cart; }
            set { cart = value; }
        }
       
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
      
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
       
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
    
        public string FirstName
        {
            get { return firstNae; }
            set { firstNae = value; }
        }
        public string? Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
