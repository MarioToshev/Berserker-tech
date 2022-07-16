using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using System.ComponentModel;

namespace BerserkerTech.Services.ComponentLogic.Interfaces
{
    public interface IComponentService
    {
        public void Add(ComputerComponent component);
        public void Update(ComputerComponent component);
        public void Delete(string Id);
        public ComputerComponent GetOneByModelAndBrand(string Brand, string Model);
    }
}
