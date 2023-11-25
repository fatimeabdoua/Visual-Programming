using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoriel
{
    internal class Program
    {
        public int fact(int k)
        {
            if (k == 0 || k == 1)
            {
                return 1;
            }

            else
            {
                return k * fact(k - 1);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            int res = p.fact(n);

            Console.WriteLine("the factoriel of the number " + n + " is : " + res);

            Console.ReadLine();
        }
    }
}
