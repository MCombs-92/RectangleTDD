using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleTest;

namespace RectangleTDD {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void TestForValidCOnstruct() {
            var rect = new Rectangle(-1, 3);
            Assert.IsNotInstanceOfType(rect, typeof(Rectangle));

        }


        [TestMethod]
        public void TestArea() {
            var length = 12;
            var width = 20;
            var actual = Rectangle.GetArea(length, width);
            Assert.AreEqual(240, actual);
        }

        [TestMethod]
        public void TestPerim() {
            var length = 12;
            var width = 20;
            var actual = Rectangle.GetPerim(length, width);
            Assert.AreEqual(64, actual);
        }
    }
}
