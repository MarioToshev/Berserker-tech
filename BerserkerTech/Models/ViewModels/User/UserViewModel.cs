using BerserkerTech.Models.DTOs.User;
using System.ComponentModel.DataAnnotations;

namespace BerserkerTech.Models.ViewModels.User
{
    public class UserViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        public string Role_Name { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {SecondName} {Email} {Role_Name}";
        }
    }
}
