using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Models.DTOs.Components.Storage;

namespace BerserkerTech.Services.ComponentLogic
{
    public class MainComponentService
    {
        public readonly CpuService _cpuService;
        public readonly GpuService _gpuService;
        public readonly MotherboardService _motherboardService;
        public readonly PsuService _psuService;
        public readonly RamService _ramService;
        public readonly StorageService _storageService;

        public MainComponentService()
        {
            _cpuService = new CpuService();
            _gpuService = new GpuService();
            _motherboardService = new MotherboardService();
            _psuService = new PsuService();
            _ramService = new RamService();
            _storageService = new StorageService();
        }

      
    }
}
