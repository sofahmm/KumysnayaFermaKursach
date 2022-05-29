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
        public void TestMethodCheckIdHorse()
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
            Assert.AreEqual(expected.ID, actual.ID);//исправлено
        }

        [TestMethod]
        public void TestMethodCheckNameCategory()
        {
            ProductCategory expected = new ProductCategory
            {
                ID = 2,
                Name = "Кумыс"
            };
            ProductCategory actual = ToGetData.GetProductCategory("Кумыс");
            Assert.AreEqual(expected.Name, actual.Name);
        }
    }
}
