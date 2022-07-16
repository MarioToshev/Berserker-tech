using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.RamFuncTests
{
    [TestClass]
    public class RamServicesTests
    {
        [TestMethod]
        public void AddRamTest()
        {
            RamService service = new RamService();
            RAM ram = new RAM(1, 100, "Ripjaws-V", "G.Skill", "3000mhz", "DDR4", "16gb", 5);
            service.Add(ram);

            Assert.AreEqual(ram.ToString(), service.GetOne(ram.Id).ToString());
        }
        [TestMethod]
        public void DeleteRamTest()
        {
            RamService service = new RamService();
            RAM ram = (RAM)service.GetOneByModelAndBrand("G.Skill", "Ripjaws-V");
           
            service.Delete(ram.Id);
            Assert.AreEqual(service.GetOne(ram.Id), null);
        }
        [TestMethod]
        public void DeleteRamWrongTest()
        {
            RamService service = new RamService();
            //non existing
            try
            {
                service.Delete("1");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Invalid Cpu id");
            }

        }
        [TestMethod]
        public void UpdateRamTest()
        {
            RamService service = new RamService();
            RAM ram = new RAM(1, 100, "Ripjaws-V", "G.Skill", "3000mhz", "DDR4", "16gb", 5);

            service.Add(ram);
            ram.Model = "Other model";
            service.Update(ram);

            Assert.AreEqual(ram.ToString(), service.GetOne(ram.Id).ToString());
        }
        [TestMethod]
        public void UpdateRamWrongTest()
        {
            RamService service = new RamService();
            RAM ram = new RAM(1, 100, "Ripjaws-V", "G.Skill", "3000mhz", "DDR4", "16gb", 5);

            service.Add(ram);
            ram.Id = "111111111111";
            service.Update(ram);

            Assert.AreEqual(null, service.GetOne("111111111111"));
        }
    }
}
