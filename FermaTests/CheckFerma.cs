using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Core.MyDb;
using Core.DB;
using KumysnayaFermaConsole;

namespace FermaTests
{
    [TestClass]
    public class CheckFerma
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange.
            Poroda expected = new Poroda
            {
                ID = 1,
                Name = "Бурятская"
            };

            //Act.

            Poroda actual = ToGetData.GetPoroda(1);
            //Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}
