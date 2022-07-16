using BerserkerTech.Models.DTOs.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.RamFuncTests
{
    [TestClass]
    public class RamTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            RAM rm = new RAM(1, 100, "Ripjaws-V", "G.Skill", "3000mhz", "DDR4", "16gb", 5);

            Assert.AreEqual(rm.Model, "Ripjaws-V");
            Assert.AreEqual(rm.Brand, "G.Skill");
            Assert.AreEqual(rm.Price, 100);
            Assert.AreEqual(rm.Quantity_Available, 1);
            Assert.AreEqual(rm.PowerDraw, 5);
            Assert.AreEqual(rm.Capacity, "16gb");
            Assert.AreEqual(rm.Ddr_Gen, "DDR4");
            Assert.AreEqual(rm.Speed, "3000mhz");
        }
        [TestMethod]
        public void ToStringTest()
        {
            RAM ram = new RAM(1, 100, "Ripjaws-V", "G.Skill", "3000mhz", "DDR4", "16gb", 5);

            Assert.AreEqual(ram.ToString(), $"{ram.Brand} {ram.Model} {ram.Capacity}GB In stok: {ram.Quantity_Available}");
        }
    }
}
