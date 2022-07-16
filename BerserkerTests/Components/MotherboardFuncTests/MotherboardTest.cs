using BerserkerTech.Models.DTOs.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.MotherboardFuncTests
{
    [TestClass]
    public class MotherboardTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Motherboard mb = new Motherboard(1,200,"x570","Gigabite","am4",
                       "zen2,zen",4,128,2,"DDR4",5);


            Assert.AreEqual(mb.Model, "x570");
            Assert.AreEqual(mb.Brand, "Gigabite");
            Assert.AreEqual(mb.Price, 200);
            Assert.AreEqual(mb.Quantity_Available,1);
            Assert.AreEqual(mb.RamGenSupport, "DDR4");
            Assert.AreEqual(mb.Supported_CPU_Models, "zen2,zen");
            Assert.AreEqual(mb.PowerDraw, 5);
            Assert.AreEqual(mb.Ram_Slots, 4);
            Assert.AreEqual(mb.Socket, "am4");
            Assert.AreEqual(mb.Max_Ram_Capacity, 128);
            Assert.AreEqual(mb.NvmeSlots, 2);
        }
        [TestMethod]
        public void ToStringTest()
        {
            Motherboard mb = new Motherboard(1, 200, "x570", "Gigabite", "am4",
                       "zen2,zen", 4, 128, 2, "DDR4", 5);

            Assert.AreEqual(mb.ToString(), $"{mb.Brand} {mb.Model} In stock: {mb.Quantity_Available}");
        }
    }
}
