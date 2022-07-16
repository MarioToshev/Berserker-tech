using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;

namespace BerserkerTech.Services.ComputerLogic.Interfaces
{
    public interface IComputerService
    {
        public string SaveComputer();
        public string TryBuildComputer();
        public void UpdateComputer(ComputerComponent component);
        public Computer GetComputer();
        public double GetTotalPrice();
    }
}
