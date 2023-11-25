using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of c");
            c = Convert.ToInt32(Console.ReadLine());


            if (a == b && b == c)
            {
                Console.WriteLine("eskenar ucgen");
            }

            else if (a == b || b == c || a == c ) {

                Console.WriteLine("ikizkenar ucgen");
            }
            else {
                Console.WriteLine("cesitkenar ucgen");
            }
            Console.ReadLine();
        }
    }
}
