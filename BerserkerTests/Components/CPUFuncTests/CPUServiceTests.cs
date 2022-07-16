using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.CPUFuncTests
{
    [TestClass]
    public class CPUServiceTests
    {
        [TestMethod]
        public void AddCpuTest()
        {
            CpuService service = new CpuService();
            CPU cpu = new CPU("Model", "Brand", 1, 1, "2", "4ghz", "am4", "zen2", 200);
            service.Add(cpu);

            Assert.AreEqual(cpu.ToString(), service.GetOne(cpu.Id).ToString());
        }
        [TestMethod]
        public void DeleteCpuTest()
        {
            CpuService service = new CpuService();
            CPU cpu = (CPU)service.GetOneByModelAndBrand("Brand","Model");
            service.Delete(cpu.Id);

            Assert.AreEqual(service.GetOne(cpu.Id), null);
        }
        [TestMethod]
        public void DeleteCpuWrongTest()
        {
            CpuService service = new CpuService();
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
        public void UpdateCpuTest()
        {
            CpuService service = new CpuService();
            CPU cpu = new CPU("Model1", "Brand1", 1, 1, "2", "4ghz", "am4", "zen2", 200);

            service.Add(cpu);
            cpu.Model = "Other model";
            service.Update(cpu);

            Assert.AreEqual(cpu.ToString(), service.GetOne(cpu.Id).ToString());
        }
        [TestMethod]
        public void UpdateCpuWrongTest()
        {
            CpuService service = new CpuService();
            CPU cpu = new CPU("Model", "Brand", 1, 1, "2", "4ghz", "am4", "zen2", 200);

            service.Add(cpu);
            cpu.Id = "111111111111";
            service.Update(cpu);

            Assert.AreEqual(null, service.GetOne("111111111111"));
        }
    }
}
