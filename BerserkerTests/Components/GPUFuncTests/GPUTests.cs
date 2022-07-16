using BerserkerTech.Models.DTOs.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.GPUFuncTests
{
    [TestClass]
    public class GPUTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            GPU gpu = new GPU(1, 200, "RTX 3070", "MSI",
            "5888", "1.73GHz", "Nvidia", "8", "14ghz", 200);

            Assert.AreEqual(1, gpu.Quantity_Available);
            Assert.AreEqual(200, gpu.PowerDraw);
            Assert.AreEqual("RTX 3070", gpu.Model);
            Assert.AreEqual("MSI", gpu.Brand);
            Assert.AreEqual("1.73GHz", gpu.Core_Speed);
            Assert.AreEqual("5888", gpu.Core_Count);
            Assert.AreEqual("Nvidia", gpu.Manufacturer);
            Assert.AreEqual("8", gpu.Memory_Capacity);
            Assert.AreEqual("14ghz", gpu.Memory_Speed);
        }
        [TestMethod]
        public void ToStringTest()
        {
            GPU gpu = new GPU(1, 200, "RTX 3070", "MSI",
            "5888", "1.73GHz", "Nvidia", "8", "14ghz", 200);

            Assert.AreEqual(gpu.ToString(), $"{gpu.Brand} {gpu.Manufacturer} {gpu.Model} {gpu.Memory_Capacity}GB In stock: {gpu.Quantity_Available}");
        }
    }
}
