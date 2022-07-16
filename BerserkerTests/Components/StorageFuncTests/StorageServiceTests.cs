using BerserkerTech.Models.DTOs.Components.Storage;
using BerserkerTech.Services.ComponentLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.StorageFuncTests
{
    [TestClass]
    public class StorageServiceTests
    {
        [TestMethod]
        public void AddStorageTest()
        {
            StorageService service = new StorageService();
            Storage stor = new Storage(1, 100, "Evo 860", "Samsung", "250gb", "2300mhz", "SSD", 15);
            service.Add(stor);

            Assert.AreEqual(stor.ToString(), service.GetOne(stor.Id).ToString());
        }
        [TestMethod]
        public void DeleteStorageTest()
        {
            StorageService service = new StorageService();
            Storage stor = (Storage)service.GetOneByModelAndBrand("Samsung", "Evo 860");

            service.Delete(stor.Id);
            Assert.AreEqual(service.GetOne(stor.Id), null);
        }
        [TestMethod]
        public void DeleteStorageWrongTest()
        {
            StorageService service = new StorageService();
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
            StorageService service = new StorageService();
            Storage stor = new Storage(1, 100, "Evo 860", "Samsung", "250gb", "2300mhz", "SSD", 15);

            service.Add(stor);
            stor.Model = "Other model";
            service.Update(stor);

            Assert.AreEqual(stor.ToString(), service.GetOne(stor.Id).ToString());
        }
        [TestMethod]
        public void UpdateStorageWrongTest()
        {
            StorageService service = new StorageService();
            Storage stor = new Storage(1, 100, "Evo 860", "Samsung", "250gb", "2300mhz", "SSD", 15);

            service.Add(stor);
            stor.Id = "111111111111";
            service.Update(stor);

            Assert.AreEqual(null, service.GetOne("111111111111"));
        }
    }
}
