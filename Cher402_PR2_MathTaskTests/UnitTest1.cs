using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cherednichenko402_Test_PR2_MathTask;
using Cherednichenko402_Test_PR2_Cylinder;

namespace Cher402_PR2_MathTaskTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            //исходные данные
            int a = 3;
            int b = 5;
            int expected = 15;

            //Получаю значение м помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            //сравнение ожиданемого результата с полученным
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void RectangleAreaCylinderReturned()
        {
            double r = 5;
            double h = 20;
            double expected = 1571;

            Cylinder a = new Cylinder();
            double actual = a.RectangleArea(r, h);
            ;

            Assert.AreEqual(expected, Math.Round(actual));
        }
    }
}
