using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EquationSolver
{
    public static class EquationSolver
    {
        public static bool EquationIsCorrect(string input)
        {
            input = Regex.Replace(input, @"\s", "");
            string pattern = @"[-]?\d{1,6}([.]|[,])?\d*[\*]?[a-z]{1}[\^]?[2]{1}([-]|[+])?\d{1,6}[.]|[,]?\d*[\*]?[a-z]{1}([-]|[+])?\d{1,6}([.]|[,])?\d*";
            Regex regex = new Regex(pattern);
            bool match = regex.IsMatch(input);
            return match;
        }

        public static float[] ParseEquation(string input)
        {
            input = Regex.Replace(input, @"\s", "");
            input = Regex.Replace(input, @"(x\^2)|(x2)", "x");
            string coefficient_pattern = @"[-]?\d{1,6}[.,]?\d*";
            float[] coefficients = new float[3];
            Regex regex = new Regex(coefficient_pattern);
            int i = 0;
            foreach (Match match in regex.Matches(input))
            {
                float coefficient = Single.Parse(match.ToString());
                coefficients[i] = coefficient;
                i++;
            }
            return coefficients;
        }

        public static float CalculateDiscriminant(float[] coefficients)
        {
            float a = coefficients[0];
            float b = coefficients[1];
            float c = coefficients[2];
            float discriminant = b * b - 4 * a * c;
            return discriminant;
        }

        public static float[] FindRoots(float discriminant, float[] coefficients)
        {
            Queue<float> roots = new Queue<float>();
            float a = coefficients[0];
            float b = coefficients[1];
            float c = coefficients[2];
            if (discriminant < 0)
            {
                return roots.ToArray();
            }
            else
            {
                float root1 = (-b + (float)Math.Sqrt(discriminant)) / 2 * a;
                roots.Enqueue(root1);
                if (discriminant != 0)
                {
                    float root2 = (-b - (float)Math.Sqrt(discriminant)) / 2 * a;
                    roots.Enqueue(root2);
                }
            }
            return roots.ToArray();
        }
    }
}
