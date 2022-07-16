using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.GPUFuncTests
{
    [TestClass]
    public class GPUServicesTests
    {
        [TestMethod]
        public void AddGpuTest()
        {
            GpuService service = new GpuService();
            GPU gpu = new GPU(1, 200, "RTX 3070", "MSI",
            "5888", "1.73GHz", "Nvidia", "8", "14ghz", 200);
            service.Add(gpu);

            Assert.AreEqual(gpu.ToString(), service.GetOne(gpu.Id).ToString());
        }
        [TestMethod]
        public void DeleteGpuTest()
        {
            GpuService service = new GpuService();
            GPU gpu = (GPU)service.GetOneByModelAndBrand("MSI", "RTX 3070");
            service.Delete(gpu.Id);

            Assert.AreEqual(service.GetOne(gpu.Id), null);
        }
        [TestMethod]
        public void DeleteGpuWrongTest()
        {
            GpuService service = new GpuService();
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
        public void UpdateGpuTest()
        {
            GpuService service = new GpuService();
            GPU gpu = new GPU(1, 200, "RTX 3070", "MSI",
            "5888", "1.73GHz", "Nvidia", "8", "14ghz", 200);

            service.Add(gpu);
            gpu.Model = "Other model";
            service.Update(gpu);

            Assert.AreEqual(gpu.ToString(), service.GetOne(gpu.Id).ToString());
        }
        [TestMethod]
        public void UpdateGpuWrongTest()
        {
            GpuService service = new GpuService();
            GPU gpu = new GPU(1, 200, "RTX 3070", "MSI",
            "5888", "1.73GHz", "Nvidia", "8", "14ghz", 200);

            service.Add(gpu);
            gpu.Id = "111111111111";
            service.Update(gpu);

            Assert.AreEqual(null, service.GetOne("111111111111"));
        }
    }
}
