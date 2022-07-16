using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic;
using BerserkerTech.Services.ComputerLogic;
using BerserkerTech.Services.OrderLogic;
using BerserkerTech.Services.UserLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerserkerTech.Pages
{
    public class BuildComputerModel : PageModel
    {
        [BindProperty]
        public Computer computer { get; set; }
        private readonly  MainComponentService _mainComponentService;
        private readonly ComputerService _computerService;
        private readonly RequestService _requestService;
        private readonly UserService _userService;


        public string Message { get; private set; }

        public BuildComputerModel()
        {
            Message = "";
            computer = new Computer();
            _mainComponentService = new MainComponentService();
            _computerService = new ComputerService();
            _requestService = new RequestService();
            _userService = new UserService();
        }
        //Save computer returns a message with missing parts, Save btn with description should be present on the site
        //log out should make the pc null again
        public void OnGet(string info)
        {
            
            if (info == null)
            {
                computer = _computerService.GetComputer();
            }
            else
            {
                string componentId = info.Split(',').ToList()[0];
                string componentType = info.Split(',').ToList()[1];

                switch (componentType)
                {
                    case "CPU":
                        _computerService.UpdateComputer(_mainComponentService._cpuService.GetOne(componentId));
                        computer = _computerService.GetComputer();
                        break;
                    case "Motherboard":
                        _computerService.UpdateComputer(_mainComponentService._motherboardService.GetOne(componentId));
                        computer = _computerService.GetComputer();
                        break ;
                    case "GPU":
                        _computerService.UpdateComputer(_mainComponentService._gpuService.GetOne(componentId));
                        computer = _computerService.GetComputer();
                        break;
                    case "PSU":
                        _computerService.UpdateComputer(_mainComponentService._psuService.GetOne(componentId));
                        computer = _computerService.GetComputer();
                        break;
                    case "Storage":
                        _computerService.UpdateComputer(_mainComponentService._storageService.GetOne(componentId));
                        computer = _computerService.GetComputer();
                        break;
                    case "RAM":
                        _computerService.UpdateComputer(_mainComponentService._ramService.GetOne(componentId));
                        computer = _computerService.GetComputer();
                        break;
                }
            }
        }
        public void OnPost()
        {
            string userEmail = HttpContext.Session.GetString("user_email");
            if (userEmail != null)
            {
                Message = _computerService.SaveComputer();
               
                if (Message == "")
                {
                    UserDTO user = _userService.GetUserByEmail(userEmail);
                    _requestService.CreateRequest(user.Id, _computerService.GetComputer().Id);
                    _computerService.ClearComputer();
                    Message = "Request sent succesfully";
                }
                
            }
            else
            {
                Message = "Create an account first";
            }
           

           
        }
    }
}
