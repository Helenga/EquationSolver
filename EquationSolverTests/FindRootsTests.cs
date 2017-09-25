using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EquationSolver.EquationSolver;

namespace EquationSolverTests
{
    [TestClass]
    public class FindRootsTests
    {
        [TestMethod]
        public void IfDiscriminantIsLessThanZeroNoRootsShouldBeReturned()
        {
            float[] expectedRoots = new float[0];
            float discriminant = -224f;
            float[] coefficients = new float[] { 1f, -8f, 72f };
            float[] roots = FindRoots(discriminant, coefficients);
            for (var i = 0; i < roots.Length; i++)
            {
                Assert.AreEqual(expectedRoots[i], roots[i]);
            }
            
        }

        [TestMethod]
        public void IfDiscriminantEqualsZeroOneRootShouldBeReturned()
        {
            float[] expectedRoots = new float[1] { 3f };
            float discriminant = 0f;
            float[] coefficients = new float[] { 1f, -6f, 9f };
            float[] roots = FindRoots(discriminant, coefficients);
            for (var i = 0; i < roots.Length; i++)
            {
                Assert.AreEqual(expectedRoots[i], roots[i]);
            }
        }
        
        [TestMethod]
        public void IfDiscriminantIsGreaterThanZeroTwoRootsShouldBeReturned()
        {
            float[] expectedRoots = new float[2] { 1f, -4f };
            float discriminant = 25f;
            float[] coefficients = new float[] { 1f, 3f, -4f };
            float[] roots = FindRoots(discriminant, coefficients);
            for (var i = 0; i < roots.Length; i++)
            {
                Assert.AreEqual(expectedRoots[i], roots[i]);
            }
        }
    }
}
