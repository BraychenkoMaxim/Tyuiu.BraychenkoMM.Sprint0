using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BraychenkoMM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BraychenkoMM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            string name = "Максим";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Максим", res);
        }
    }
}
