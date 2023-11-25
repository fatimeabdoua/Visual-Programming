using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootofquadradic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the third number:");
            int c = Convert.ToInt32(Console.ReadLine());

            double x1, x2;
            double delta = b * b - 4 * a * c;

            if (delta == 0)
            {
                Console.WriteLine("the root are eaquals");
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("x1 = x2 =  " + x1);
            }

            else if (delta > 0)
            {
                Console.WriteLine("the root are not equals");

                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("x1 = " + x1 + "x2 = " + x2);
            }

            else
            {
                Console.WriteLine("delta is negatif there is no root.");
            }

            Console.ReadLine();
        }
    }
}
