using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EquationSolver.EquationSolver;

namespace EquationSolverTests
{
    [TestClass]
    public class CalculateDiscriminantTests
    {
        [TestMethod]
        public void DiscriminantShouldBeCalculatedCorrectly()
        {
            float[][] coefficients = new float[][]
            {
                new float[] { 1f, 3f, -4f },
                new float[] { 1f, -8f, 72f },
                new float[] { 1f, -6f, 9f }
            };
            float[] expectedDiscriminants = new float[] { 25f, -224f, 0f };
            for (var i = 0; i < expectedDiscriminants.Length; i++)
            {
                float discriminant = CalculateDiscriminant(coefficients[i]);
                Assert.AreEqual(expectedDiscriminants[i], discriminant);
            }
        }
    }
}
