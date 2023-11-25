using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageof3Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter three numbers");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3;

            double avg = (double)sum / 3;

            Console.WriteLine("the average is:" + avg);

            Console.ReadLine();
        }
    }
}
