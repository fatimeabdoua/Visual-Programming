using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    internal class Program
    {
        int FindMax(int num1, int num2)
        {
            int max;

            if (num1> num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }

            return max;
        }

        class Test {
            static void Main(string[] args)
            {
                int num1 = 5;
                int num2 = 8;

                int max;

                Program n = new Program();

                max = n.FindMax(num1, num2);

                Console.WriteLine("the greatest num is:" + max);

                Console.ReadLine();

            }
        }
        
    }
}
