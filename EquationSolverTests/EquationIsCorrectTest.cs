using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EquationSolver.EquationSolver;

namespace EquationSolverTests
{
    [TestClass]
    public class EquationIsCorrectTest
    {
        [TestMethod]
        public void FalseShouldBeReturnedIfWrongIputFormat()
        {
            string[] wrongInputs = new string[]
            {
                "1x^3 + 1x - 1",
                "-3x-1"
                //"1x - x^2"
                
            };
            foreach (var input in wrongInputs)
            {
                Assert.IsFalse(EquationIsCorrect(input) == false);
            }
        }
    }
}
