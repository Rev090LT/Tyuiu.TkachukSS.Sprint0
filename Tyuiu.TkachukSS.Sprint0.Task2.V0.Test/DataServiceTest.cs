using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.TkachukSS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataSerivceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Семён";
            var res = DataSerivce.GetMessage(name);

            Assert.AreEqual("Привет, Семён", res);
        }
    }
}
