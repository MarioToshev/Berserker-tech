using BerserkerTech.Models.ViewModels.Request.Computer;
using BerserkerTech.Models.ViewModels.User;

namespace BerserkerTech.Models.ViewModels.Request
{
    public class RequestViewModel
    {
        public ComputerViewModel Computer{ get; set; }
        public string Status { get; set; }
        public UserViewModel Builder { get; set; }
        public UserViewModel Client { get; set; }
    }
}
