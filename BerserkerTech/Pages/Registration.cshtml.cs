using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.User;
using BerserkerTech.Models.ViewModels.User;
using BerserkerTech.Services.ComputerLogic;
using BerserkerTech.Services.OrderLogic;
using BerserkerTech.Services.UserLogic;
using BerserkerTech.Services.UserLogic.SharedServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BerserkerTech.Pages
{
    
    public class RegistrationModel : PageModel
    {
        [BindProperty]
        public UserDTO User { get; set; }
        [BindProperty]
        public List<Request> requests { get; set; }
        [BindProperty]
        public string? Error { get; set; }
        
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        public RegistrationModel(IUserService userServse, IRoleService roleService)
        {
            this.User = new UserDTO();
            _userService = userServse;
            _roleService = roleService;
        }
        public void OnGet()
        {
            string loggedUserEmail = HttpContext.Session.GetString("user_email");
            if (loggedUserEmail != null)
            {
                User = _userService.GetUserByEmail(loggedUserEmail);
             
            }
           
        }
        public void OnPost()
        {
             
            if (User.Password.Count() >= 4 && 
                User.FirstName.Count() >= 2 &&
                User.SecondName.Count() >= 2 &&
               IsValidEmail(User.Email))
            {
                var user = _userService.GetUserByEmail(User.Email);
                if (user.Email != null)
                {
                    Error = "This user has an account already";
                }
                else
                {
                    User.Role_Name = "Client";
                    _userService.AddUser(User);
                    User = new UserDTO();
                    Error = @"Account created, now you can Log in";
                }
            }
            else
            {
                Error = @"All the fields are requierd
                      Check if your email is right and that your password is more than 4 simbols";
            }
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
