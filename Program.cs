using System;

namespace QuadraticEquationRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number of equations: ");
            n = int.Parse(Console.ReadLine());

            double a, b, c;
            double minRoot = double.MaxValue;
            double maxRoot = double.MinValue;
            int twoRealRoots = 0;
            int oneRealRoot = 0;
            int noRealRoots = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the coefficients of equation " + i + ":");
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = double.Parse(Console.ReadLine());

                double discriminant = Math.Pow(b, 2) - 4 * a * c;
                if (discriminant > 0)
                {
                    twoRealRoots++;
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("The roots of equation " + i + " are real and distinct: " + root1 + " and " + root2);
                    minRoot = Math.Min(root1, root2);
                    maxRoot = Math.Max(root1, root2);
                }
                else if (discriminant == 0)
                {
                    oneRealRoot++;
                    double root = -b / (2 * a);
                    Console.WriteLine("The roots of equation " + i + " are real and equal: " + root);
                    minRoot = root;
                    maxRoot = root;
                }
                else
                {
                    noRealRoots++;
                    Console.WriteLine("The roots of equation " + i + " are complex and imaginary.");
                }
            }

            Console.WriteLine("The minimum root among all calculated roots is: " + minRoot);
            Console.WriteLine("The maximum root among all calculated roots is: " + maxRoot);
            Console.WriteLine("Number of equations with two real roots: " + twoRealRoots);
            Console.WriteLine("Number of equations with one real root: " + oneRealRoot);
            Console.WriteLine("Number of equations with no real roots: " + noRealRoots);
        }
    }
}
