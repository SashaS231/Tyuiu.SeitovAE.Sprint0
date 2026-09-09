

using Tyuiu.SeitovAE.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SeitovAE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Саша";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет...., Саша", res);
        }
    }
}
