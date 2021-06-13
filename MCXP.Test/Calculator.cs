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

        [TestMethod]
        public void AddXP_Level30Plus10()
        {
            int experience = 1395;
            int diff = 10;

            (int, int) actual = MCXP.Calculator.AddXP(experience, diff);

            Assert.AreEqual((30, 10), actual, $"Received {actual}.");
        }

        [TestMethod]
        public void SubtractXP_Level30Minus10()
        {
            int experience = 1395;
            int diff = 10;

            (int, int) actual = MCXP.Calculator.SubtractXP(experience, diff);

            Assert.AreEqual((29, 97), actual, $"Received {actual}.");
        }

        [TestMethod]
        public void LevelsAndPointsToXP_Level30()
        {
            int levels = 30;
            int points = 0;

            long actual = MCXP.Calculator.LevelsAndPointsToXP(levels, points);

            Assert.AreEqual(1395, actual, $"Received {actual}.");
        }

        [TestMethod]
        public void LevelsAndPointsToXP_Level30And10Points()
        {
            int levels = 30;
            int points = 10;

            long actual = MCXP.Calculator.LevelsAndPointsToXP(levels, points);

            Assert.AreEqual(1405, actual, $"Received {actual}.");
        }

        [TestMethod]
        public void XPDiff_Level27to30()
        {
            (int, int) currentXP = (27, 0);
            (int, int) diff = (30, 0);

            long actual = MCXP.Calculator.XPDiff(currentXP, diff);

            Assert.AreEqual(306, actual, $"Received {actual}.");
        }
    }
}
