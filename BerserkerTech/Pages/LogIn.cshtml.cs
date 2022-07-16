using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.ViewModels.User;
using BerserkerTech.Services.UserLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerserkerTech.Pages
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public string Error { get; set; }
        [BindProperty]
        public UserDTO User { get; set; }
        private readonly IUserService _userService;
        public LogInModel(IUserService userService)
        {
            this.User = new UserDTO();
            _userService = userService;
        }
        public void OnGet()
        {
            Error = "";
            string loggedUserEmail = HttpContext.Session.GetString("user_email");
            if (loggedUserEmail != null)
            {
                User = _userService.GetUserByEmail(loggedUserEmail);
            }
        }
        public IActionResult OnPost()
        {
            if (User.Email != null && User.Password != null)
            {
                bool userIsCorrect = _userService.UserCredentialsCorrect(User);
                if (userIsCorrect)
                {
                    HttpContext.Session.SetString("user_email", User.Email);
                    return Redirect("Registration");
                }
                else
                {
                    Error =  "Invalid User";
                    return Page();
                }
            }
            else
            {
                Error = "Fields are empty";
                return Page();
            }

        }
    }
}
