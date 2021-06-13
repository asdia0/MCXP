namespace MCXP.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void LevelsAndPoints_Level30()
        {
            int experience = 1395;

            (int, int) actual = MCXP.Calculator.GetLevelsAndPoints(experience);

            Assert.AreEqual((30, 0), actual, $"Received {actual}.");
        }

        [TestMethod]
        public void LevelsAndPoints_Level30And10Points()
        {
            int experience = 1405;

            (int, int) actual = MCXP.Calculator.GetLevelsAndPoints(experience);

            Assert.AreEqual((30, 10), actual, $"Received {actual}.");
        }
    }
}
