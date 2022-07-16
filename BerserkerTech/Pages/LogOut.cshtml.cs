using BerserkerTech.Models.ViewModels.User;
using BerserkerTech.Services.UserLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerserkerTech.Pages
{
    public class LogOutModel : PageModel
    {
        public UserViewModel User { get; set; }
        private readonly IUserService _userService;
        public LogOutModel(IUserService userService)
        {
            this.User = new UserViewModel();
            _userService = userService;
        }
        public IActionResult OnGet()
        {
            HttpContext.Session.Remove("user_email");                                                                                                                                                                                                                                      
            return Redirect("Registration");
        }
    }
}
