using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net.Teirlinck.Utils.Mathnet;

namespace Utils.Mathnet.Tests
{
    [TestClass]
    public class SequenceTests
    {
        [TestMethod]
        public void TestIsMonotonic()
        {
            Assert.IsTrue((new double[] { 0, 0, 0, 0 }).IsMonotonic());
            Assert.IsTrue((new int[] { -1, 0, 0, 3, 4, 4, 5 }).IsMonotonic());
            Assert.IsFalse((new int[] { -1, 0, 0, 3, 2, 4, 5 }).IsMonotonic());
            Assert.IsTrue((new double[] { -1.5, 0, 0.5, 3, 4, 4.2, 5 }).IsMonotonic());
            Assert.IsTrue((new double[] { 5, 4.2, 4, 3, 0.5, 0, -1.5 }).IsMonotonic());
            Assert.IsTrue((new double[] { 5, 4, 4, 3, 0.5, 0, -1.5 }).IsMonotonic());
            Assert.IsFalse((new double[] { 5, 4, 4, 3, 0.5, 0, double.NaN }).IsMonotonic());
        }

        [TestMethod]
        public void TestIsStrictlyMonotonic()
        {
            Assert.IsFalse((new double[] { 0, 0, 0, 0 }).IsStrictlyMonotonic());
            Assert.IsFalse((new int[] { -1, 0, 0, 3, 4, 4, 5 }).IsStrictlyMonotonic());
            Assert.IsFalse((new int[] { -1, 0, 0, 3, 2, 4, 5 }).IsStrictlyMonotonic());
            Assert.IsTrue((new double[] { -1.5, 0, 0.5, 3, 4, 4.2, 5 }).IsStrictlyMonotonic());
            Assert.IsTrue((new double[] { 5, 4.2, 4, 3, 0.5, 0, -1.5 }).IsStrictlyMonotonic());
            Assert.IsFalse((new double[] { 5, 4.2, 4, 3, 0.5, 0, double.NaN }).IsStrictlyMonotonic());
            Assert.IsFalse((new double[] { 5, 4, 4, 3, 0.5, 0, -1.5 }).IsStrictlyMonotonic());
        }
    }
}
