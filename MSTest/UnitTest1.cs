using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q8_lib;
using System;
using System.Collections.Generic;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //���� ���������� ������� �����
        public void TestMethod1()
        {
            double r = 3;
            Circle circle = new Circle { Radius = r };
            Assert.AreEqual(2*Math.PI*r, GeometryLib.AreaofShapes(circle));
        }
        [TestMethod]
        //���� �������� �������� �� ����������� �������������
        public void TestMethod2()
        {
            List<double> sides = new List<double>() { 3, 4, 5 };
            Triangle triangle = new Triangle { Sides = sides };            
            Assert.AreEqual(true, triangle.IsRightTriangle());
        }
        [TestMethod]
        //���� �������� �������� �� ����������� �������������
        public void TestMethod3()
        {
            List<double> sides = new List<double>() { 4, 3, 5 };
            Triangle triangle = new Triangle { Sides = sides };
            Assert.AreEqual(true, triangle.IsRightTriangle());
        }

    }
}
