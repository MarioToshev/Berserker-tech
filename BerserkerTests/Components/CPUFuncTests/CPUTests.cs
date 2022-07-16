using BerserkerTech.Models.DTOs.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.CPUFuncTests
{
    [TestClass]
    public class CPUTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            CPU cpu = new CPU("Model","Brand",1,1,"2","4ghz","am4","zen2",200);

            Assert.AreEqual("Model", cpu.Model);
            Assert.AreEqual("Brand", cpu.Brand);
            Assert.AreEqual(1, cpu.Quantity_Available);
            Assert.AreEqual(1, cpu.Price);
            Assert.AreEqual("2", cpu.Cores);
            Assert.AreEqual("4ghz", cpu.Speed);
            Assert.AreEqual("am4", cpu.Socket);
            Assert.AreEqual("zen2", cpu.Generation);
            Assert.AreEqual(200, cpu.PowerDraw);
        }
        [TestMethod]
        public void ToStringTest()
        {
            CPU cpu = new CPU("Model", "Brand", 1, 1, "2", "4ghz", "am4", "zen2", 200);

            Assert.AreEqual($"{cpu.Brand} {cpu.Model} In stock: {cpu.Quantity_Available}", cpu.ToString());
        }

    }
}
