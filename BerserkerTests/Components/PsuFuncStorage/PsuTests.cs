using BerserkerTech.Models.DTOs.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.PsuFuncStorage
{
    [TestClass]
    public class PsuTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            PSU psu = new PSU(1, 100, "Focus GX-850", "Seasonic","80 plus",850);

            Assert.AreEqual(psu.Model, "Focus GX-850");
            Assert.AreEqual(psu.Brand, "Seasonic");
            Assert.AreEqual(psu.Price, 100);
            Assert.AreEqual(psu.Quantity_Available, 1);
            Assert.AreEqual(psu.Max_power, 850);
            Assert.AreEqual(psu.Certificate, "80 plus");
        }
        [TestMethod]
        public void ToStringTest()
        {
            PSU psu = new PSU(1, 100, "Focus GX-850", "Seasonic", "80 plus", 850);

            Assert.AreEqual(psu.ToString(), $"{psu.Brand} {psu.Model} In stock: {psu.Quantity_Available}");
        }
    }
}
