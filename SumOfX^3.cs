using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofX_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, sum, ctr, p, term;
            int i, n;

            Console.Write("enter the value of x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            term = 1;
            sum = 0;
            for (i = 1, p = 1; i < n + 1; i++)
            {
                ctr = Math.Pow(x, p);
                sum = sum + ctr * term;
                term = term * (-1);
                p = p + 2;
            }
            Console.Write("\nThe sum = {0}\nNumber of terms = {1}\n The value of x = {2}\n", sum, n, x);
            Console.ReadLine();
        }
    }
}
