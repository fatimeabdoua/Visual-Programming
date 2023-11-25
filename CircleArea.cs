using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;

            Console.WriteLine("enter the radius:");

            double r = Convert.ToDouble(Console.ReadLine());

            double area = r * r * pi;

            Console.WriteLine("the area of the cercle is:" + area);

            Console.ReadLine();
        
        }
    }
}
