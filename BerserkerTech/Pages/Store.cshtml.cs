using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BerserkerTech.Pages
{
    public class StoreModel : PageModel
    {
        public List<ComputerComponent> components { get; set; }
        public MainComponentService mainComponentService { get; set; }
      
        [BindProperty]
        public string Type { get; set; }

        public StoreModel()
        {
            mainComponentService = new MainComponentService();
            components = new List<ComputerComponent>();
        }
        public void OnGet()
        {
            if (components.Count == 0)
            {
                Type = "CPU";
                components.AddRange(mainComponentService._cpuService.GetAll());
            }
        }
        public void OnPost(string componentType)
        {
            components.Clear();
            switch (componentType)
            {
                case "CPU":
                    components.AddRange(mainComponentService._cpuService.GetAllAvailable());
                    Type = "CPU";
                    break;
                case "Motherboard":
                    components.AddRange(mainComponentService._motherboardService.GetAllAvailable());
                    Type = "Motherboard";
                    break;
                case "GPU":
                    components.AddRange(mainComponentService._gpuService.GetAllAvailable());
                    Type = "GPU";
                    break;
                case "PSU":
                    components.AddRange(mainComponentService._psuService.GetAllAvailable());
                    Type = "PSU";
                    break;
                case "Storage":
                    components.AddRange(mainComponentService._storageService.GetAllAvailable());
                    Type = "Storage";
                    break;
                case "RAM":
                    components.AddRange(mainComponentService._ramService.GetAllAvailable());
                    Type = "RAM";
                    break;
                default:
                    components.AddRange(mainComponentService._cpuService.GetAllAvailable());
                    Type = "CPU";
                    break;
            }
        }
    }
}
