using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathNet.Numerics.Statistics;

namespace Utils.Mathnet.Tests
{
    [TestClass]
    public class QuantileTests
    {
        [TestMethod]
        public void TestQuantile()
        {
            double[] samples = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            double q25 = samples.Quantile(0.25);

            Assert.IsTrue(q25 > 2 && q25 < 3);
        }

        [TestMethod]
        public void TestQuartile()
        {
            double[] samples = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            double q25 = samples.LowerQuartile();

            Assert.IsTrue(q25 > 2 && q25 < 3);

            double upperQuartile = samples.UpperQuartile();

            Assert.IsTrue(upperQuartile > 7);
        }
    }
}
