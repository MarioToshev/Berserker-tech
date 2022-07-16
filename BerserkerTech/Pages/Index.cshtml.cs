using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.ViewModels.User;
using BerserkerTech.Services.UserLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerserkerTech.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public UserDTO User { get; set; }
        public UserService userService;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            this.User = new UserDTO();
            userService = new UserService(configuration);
        }

        public void OnGet()
        {
            string loggedUserEmail = HttpContext.Session.GetString("user_email");
            if (loggedUserEmail != null)
            {
                User = userService.GetUserByEmail(loggedUserEmail);
            }
        }
        public void OnPost()
        {
        }
    }
}