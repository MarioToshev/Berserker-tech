using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.PsuFuncStorage
{
    [TestClass]
    public class PsuServiceTests
    {
        [TestMethod]
        public void AddStorageTest()
        {
            PsuService service = new PsuService();
            PSU psu = new PSU(1, 100, "Focus GX-850", "Seasonic", "80 plus", 850);
            service.Add(psu);

            Assert.AreEqual(psu.ToString(), service.GetOne(psu.Id).ToString());
        }
        [TestMethod]
        public void DeleteStorageTest()
        {
            PsuService service = new PsuService();
            PSU psu = (PSU)service.GetOneByModelAndBrand("Seasonic", "Focus GX-850"); 

            service.Delete(psu.Id);
            Assert.AreEqual(service.GetOne(psu.Id), null);
        }
        [TestMethod]
        public void DeleteStorageWrongTest()
        {
            PsuService service = new PsuService();
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
        public void UpdateStorageTest()
        {
            PsuService service = new PsuService();
            PSU psu = new PSU(1, 100, "Focus GX-850", "Seasonic", "80 plus", 850);

            service.Add(psu);
            psu.Model = "Other model";
            service.Update(psu);

            Assert.AreEqual(psu.ToString(), service.GetOne(psu.Id).ToString());
        }
        [TestMethod]
        public void UpdateStorageWrongTest()
        {
            PsuService service = new PsuService();
            PSU psu = new PSU(1, 100, "Focus GX-850", "Seasonic", "80 plus", 850);

            service.Add(psu);
            psu.Id = "111111111111";
            service.Update(psu);

            Assert.AreEqual(null, service.GetOne("111111111111"));
        }
    }
}
