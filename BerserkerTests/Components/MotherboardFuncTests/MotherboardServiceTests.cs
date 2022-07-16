using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.MotherboardFuncTests
{
    [TestClass]
    public class MotherboardServiceTests
    {
        [TestMethod]
        public void AddMotherboardTest()
        {
            MotherboardService service = new MotherboardService();
            Motherboard mb = new Motherboard(1, 200, "x570", "Gigabite", "am4",
                       "zen2,zen", 4, 128, 2, "DDR4", 5);
            service.Add(mb);

            Assert.AreEqual(mb.ToString(), service.GetOne(mb.Id).ToString());
        }
        [TestMethod]
        public void DeleteMotherboardTest()
        {
            MotherboardService service = new MotherboardService();
            Motherboard mb = (Motherboard)service.GetOneByModelAndBrand("Gigabite", "x570");
            service.Delete(mb.Id);

            Assert.AreEqual(service.GetOne(mb.Id), null);
        }
        [TestMethod]
        public void DeleteMotherboardWrongTest()
        {
            MotherboardService service = new MotherboardService();
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
        public void UpdateMotherboardTest()
        {
            MotherboardService service = new MotherboardService();
            Motherboard mb = new Motherboard(1, 200, "x570", "Gigabite", "am4",
                       "zen2,zen", 4, 128, 2, "DDR4", 5);

            service.Add(mb);
            mb.Model = "Other model";
            service.Update(mb);

            Assert.AreEqual(mb.ToString(), service.GetOne(mb.Id).ToString());
        }
        [TestMethod]
        public void UpdateMotherboardWrongTest()
        {
            MotherboardService service = new MotherboardService();
            Motherboard mb = new Motherboard(1, 200, "x570", "Gigabite", "am4",
                       "zen2,zen", 4, 128, 2, "DDR4", 5);

            service.Add(mb);
            mb.Id = "111111111111";
            service.Update(mb);

            Assert.AreEqual(null, service.GetOne("111111111111"));
        }
    }
}

