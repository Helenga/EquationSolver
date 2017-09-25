using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EquationSolver.EquationSolver;

namespace EquationSolverTests
{
    [TestClass]
    public class ParseEquationTests
    {
        [TestMethod]
        public void ThreeFloatCoefficientsShouldBeDistracted()
        {
            string[] rightInputs = new string[3] 
            {
                "2x^2+2x+3",
                "-1x^2  -7x +   2",
                "3*x2 - 8x  +31"
            };
            float[][] expectedCoefficients = new float[][] 
            {
                new float[] { 2f, 2f, 3f },
                new float[] { -1f, -7f, 2f },
                new float[] { 3f, -8f, 31f }
            };
            for (var i = 0; i < rightInputs.Length; i++)
            {
                float[] coefficients = ParseEquation(rightInputs[i]);
                for (var k = 0; k < coefficients.Length; k++)
                {
                    Assert.AreEqual(expectedCoefficients[i][k], coefficients[k]);
                }
            }
        } 
    }
}
