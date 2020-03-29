using System;

namespace Лаб_3_ДВВ2
{
    class Program
    {
        static void Main(string[] args)
        {
            char exit = ' ';
            while (exit != 'n')
            {
                double a, b, c, d, x1, x2;
                Console.WriteLine("Enter a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter c: ");
                c = Convert.ToDouble(Console.ReadLine());

                d = b * b - 4 * a * c;

                if (d < 0)
                {
                    x1 = -b / (2 * a);
                    x2 = Math.Sqrt(Math.Abs(d)) / (2 * a);
                    Console.WriteLine("\n X1 = {0} + {1}j, \t X2 = {0} - {1}j", x1, x2);
                }

                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("\n X1 = {0}, \t X2 = {0}", x1);
                }

                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("\n X1 = {0}, \t X2 = {1}", x1, x2);
                }

                Console.WriteLine("\nTry again? \t y - yes, n - no");
                exit = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
