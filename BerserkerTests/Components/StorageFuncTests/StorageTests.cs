using BerserkerTech.Models.DTOs.Components.Storage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerserkerTests.Components.StorageFuncTests
{
    [TestClass]
    public class StorageTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Storage sto = new Storage(1, 100, "Evo 860", "Samsung", "250gb", "2300mhz", "SSD", 15);

            Assert.AreEqual(sto.Model, "Evo 860");
            Assert.AreEqual(sto.Brand, "Samsung");
            Assert.AreEqual(sto.Price, 100);
            Assert.AreEqual(sto.Quantity_Available, 1);
            Assert.AreEqual(sto.PowerDraw, 15);
            Assert.AreEqual(sto.Speed, "2300mhz");
            Assert.AreEqual(sto.Capacity, "250gb");
            Assert.AreEqual(sto.Type, "SSD");
        }
        [TestMethod]
        public void ToStringTest()
        {
            Storage sto = new Storage(1, 100, "Ripjaws-V", "G.Skill", "3000mhz", "DDR4", "16gb", 5);

            Assert.AreEqual(sto.ToString(), $"{sto.Brand} {sto.Model} {sto.Capacity}GB In stock: {sto.Quantity_Available}");
        }
    }
}
