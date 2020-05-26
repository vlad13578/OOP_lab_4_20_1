using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OOP_lab_4_20_1.Program.Hrystyna.Rating = 95;

            Assert.AreEqual(OOP_lab_4_20_1.Program.Hrystyna.StudentRating(), "\nВiтаємо вiдмiнника");
        }

        [TestMethod]
        public void TestMethod2()
        {
            OOP_lab_4_20_1.Program.Hrystyna.Rating = 80;

            Assert.AreEqual(OOP_lab_4_20_1.Program.Hrystyna.StudentRating(), "\nМожна вчитись краще");
        }

        [TestMethod]
        public void TestMethod3()
        {
            OOP_lab_4_20_1.Program.Hrystyna.Rating = 60;

            Assert.AreEqual(OOP_lab_4_20_1.Program.Hrystyna.StudentRating(), "\nВарто бiльше уваги придiляти навчанню");
        }
    }
}
