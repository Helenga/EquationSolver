using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EquationSolver.EquationSolver;

namespace SolverApp
{
    class SolverApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float[] roots;
                float[] coefficients = new float[3];
                float discriminant;
                string input = GetEquation();
                while (!EquationIsCorrect(input))
                {
                    Console.WriteLine("Equation is not correct. Try again.");
                    input = GetEquation();
                }
                // pass equation to ParseEquation, get coefficients
                coefficients = ParseEquation(input);
                // pass coefficients to CalculateDiscriminant, get discriminant
                discriminant = CalculateDiscriminant(coefficients);
                // pass discriminant to FindRoots, get array of Roots
                roots = FindRoots(discriminant, coefficients);
                // pass roots to PrintResult
                PrintResult(roots);
            }  
        }

        static string GetEquation()
        {
            Console.WriteLine("Enter an equation like this: a*x^2+b*x+c");
            string input = Console.ReadLine();
            return input;
        }

        static void PrintResult(float[] roots)
        {
            if (roots.Length == 0)
            {
                Console.WriteLine("No roots");
            }
            else
            {
                Console.WriteLine("Roots are: ");
                foreach (var root in roots)
                {
                    Console.WriteLine(root);
                }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
