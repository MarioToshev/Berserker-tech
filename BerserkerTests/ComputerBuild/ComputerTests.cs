using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Models.DTOs.Components.Storage;
using BerserkerTech.Services.ComponentLogic;
using BerserkerTech.Services.ComputerLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.ComputerBuild
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void AddComputerTest()
        {
            ComputerService pcService = new ComputerService();
            MainComponentService mainComponentService = new MainComponentService();

            Computer pc = new Computer();
            //JUST FOR THE TEST I KNOW ITS UGLY
            //I dont create PCs like that in the actual application

            pc.CPU = (CPU)mainComponentService._cpuService.GetOneByModelAndBrand("Brand", "Model");
            pc.GPU = (GPU)mainComponentService._gpuService.GetOneByModelAndBrand("MSI", "RTX 3070");
            pc.Motherboard = (Motherboard)mainComponentService._motherboardService.GetOneByModelAndBrand("Gigabite", "x570");
            pc.RAM = (RAM)mainComponentService._ramService.GetOneByModelAndBrand("G.Skill", "Ripjaws-V");
            pc.PSU = (PSU)mainComponentService._psuService.GetOneByModelAndBrand("Seasonic", "Focus GX-850");
            pc.Storage = (Storage)mainComponentService._storageService.GetOneByModelAndBrand("Samsung", "Evo 860");
            pc.RamQuantity = 2;

            pcService.SetComputer(pc);
            var result = pcService.TryBuildComputer();

            Assert.AreEqual(result,"");
        }
        [TestMethod]
        public void AddComputerTest_UncompadableRam()
        {
            ComputerService pcService = new ComputerService();
            MainComponentService mainComponentService = new MainComponentService();

            Computer pc = new Computer();


            mainComponentService._ramService.Add(new RAM(1, 100, "Ripjaws-X", "G.Skill", "2000mhz", "DDR3", "16gb", 5));
            pc.CPU = (CPU)mainComponentService._cpuService.GetOneByModelAndBrand("Brand", "Model");
            pc.GPU = (GPU)mainComponentService._gpuService.GetOneByModelAndBrand("MSI", "RTX 3070");
            pc.Motherboard = (Motherboard)mainComponentService._motherboardService.GetOneByModelAndBrand("Gigabite", "x570");
            pc.RAM = (RAM)mainComponentService._ramService.GetOneByModelAndBrand("G.Skill", "Ripjaws-X");
            pc.PSU = (PSU)mainComponentService._psuService.GetOneByModelAndBrand("Seasonic", "Focus GX-850");
            pc.Storage = (Storage)mainComponentService._storageService.GetOneByModelAndBrand("Samsung", "Evo 860");
            pc.RamQuantity = 2;

            pcService.SetComputer(pc);
            var result = pcService.TryBuildComputer();

            Assert.AreEqual(result, "Ram and motherboard are not compadable");
        }
        [TestMethod]
        public void AddComputerTest_UncompadableCPU()
        {
            ComputerService pcService = new ComputerService();
            MainComponentService mainComponentService = new MainComponentService();

            Computer pc = new Computer();


            // mainComponentService._cpuService.Add(new CPU("I9 9900F", "Intel", 10, 1000, "8/16", "4ghz", "LGA1151", "coffee lake", 95));
            pc.CPU = (CPU)mainComponentService._cpuService.GetOneByModelAndBrand("Intel", "I9 9900F");
            pc.GPU = (GPU)mainComponentService._gpuService.GetOneByModelAndBrand("MSI", "RTX 3070");
            pc.Motherboard = (Motherboard)mainComponentService._motherboardService.GetOneByModelAndBrand("Gigabite", "x570");
            pc.RAM = (RAM)mainComponentService._ramService.GetOneByModelAndBrand("G.Skill", "Ripjaws-V");
            pc.PSU = (PSU)mainComponentService._psuService.GetOneByModelAndBrand("Seasonic", "Focus GX-850");
            pc.Storage = (Storage)mainComponentService._storageService.GetOneByModelAndBrand("Samsung", "Evo 860");
            pc.RamQuantity = 2;

            pcService.SetComputer(pc);
            var result = pcService.TryBuildComputer();

            Assert.AreEqual(result, "Cpu and motherboard are not compadable");
        }
        [TestMethod]
        public void AddComputerTest_NotEnoughPower()
        {
            ComputerService pcService = new ComputerService();
            MainComponentService mainComponentService = new MainComponentService();

            Computer pc = new Computer();


           // mainComponentService._psuService.Add(new PSU(1, 100, "Eco power 200", "Segotep", "none", 100));
            pc.CPU = (CPU)mainComponentService._cpuService.GetOneByModelAndBrand("Brand", "Model");
            pc.GPU = (GPU)mainComponentService._gpuService.GetOneByModelAndBrand("MSI", "RTX 3070");
            pc.Motherboard = (Motherboard)mainComponentService._motherboardService.GetOneByModelAndBrand("Gigabite", "x570");
            pc.RAM = (RAM)mainComponentService._ramService.GetOneByModelAndBrand("G.Skill", "Ripjaws-V");
            pc.PSU = (PSU)mainComponentService._psuService.GetOneByModelAndBrand("Segotep", "Eco power 200");
            pc.Storage = (Storage)mainComponentService._storageService.GetOneByModelAndBrand("Samsung", "Evo 860");
            pc.RamQuantity = 2;

            pcService.SetComputer(pc);
            var result = pcService.TryBuildComputer();

            Assert.AreEqual(result, "Power is not enough");
        }
        [TestMethod]
        public void UpdateComputerTest()
        {
            ComputerService pcService = new ComputerService();
            MainComponentService mainComponentService = new MainComponentService();

            Computer pc = new Computer();


             var component = (PSU)mainComponentService._psuService.GetOneByModelAndBrand("Segotep", "Eco power 200");
            pc.CPU = (CPU)mainComponentService._cpuService.GetOneByModelAndBrand("Brand", "Model");
            pc.GPU = (GPU)mainComponentService._gpuService.GetOneByModelAndBrand("MSI", "RTX 3070");
            pc.Motherboard = (Motherboard)mainComponentService._motherboardService.GetOneByModelAndBrand("Gigabite", "x570");
            pc.RAM = (RAM)mainComponentService._ramService.GetOneByModelAndBrand("G.Skill", "Ripjaws-V");
            pc.PSU = (PSU)mainComponentService._psuService.GetOneByModelAndBrand("Seasonic", "Focus GX-850");
            pc.Storage = (Storage)mainComponentService._storageService.GetOneByModelAndBrand("Samsung", "Evo 860");
            pc.RamQuantity = 2;

            pcService.SetComputer(pc);
            pcService.UpdateComputer(component);

            Assert.AreEqual(pcService.GetComputer().PSU, component);
        }
        [TestMethod]
        public void GetPriceTest()
        {
            ComputerService pcService = new ComputerService();
            MainComponentService mainComponentService = new MainComponentService();

            Computer pc = new Computer();


         
            pc.CPU = (CPU)mainComponentService._cpuService.GetOneByModelAndBrand("Brand", "Model");
            pc.GPU = (GPU)mainComponentService._gpuService.GetOneByModelAndBrand("MSI", "RTX 3070");
            pc.Motherboard = (Motherboard)mainComponentService._motherboardService.GetOneByModelAndBrand("Gigabite", "x570");
            pc.RAM = (RAM)mainComponentService._ramService.GetOneByModelAndBrand("G.Skill", "Ripjaws-V");
            pc.PSU = (PSU)mainComponentService._psuService.GetOneByModelAndBrand("Seasonic", "Focus GX-850");
            pc.Storage = (Storage)mainComponentService._storageService.GetOneByModelAndBrand("Samsung", "Evo 860");
            pc.RamQuantity = 2;

            pcService.SetComputer(pc);
            

            Assert.AreEqual(pcService.GetTotalPrice(), 801);
        }
        [TestMethod]
        public void ClearPcTest()
        {
            ComputerService pcService = new ComputerService();

            Computer pc = new Computer();
            pc.Id = "1";

            pcService.SetComputer(pc);
            pcService.ClearComputer();

            Assert.AreNotEqual(pcService.GetComputer().Id, "1");
        }
    }
}
