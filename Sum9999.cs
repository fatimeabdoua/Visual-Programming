using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum9999
{
    internal class Program
    {
        public class PrintSum
        {
            int num;

            public PrintSum(int num)
            {
                this.num = num;
            }

            public void CalculateCum() {

                int sum = 0, s = 9;

                for(int i = 0; i < num; i ++)
                {
                    sum = sum + s;
                    Console.Write(" {0} + " , s);

                    s = s * 10 + 9;

                }
                Console.WriteLine();
                Console.WriteLine("sum of series = " + sum);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the term");
            int n = Convert.ToInt32(Console.ReadLine());

            PrintSum  p = new PrintSum(n);
            p.CalculateCum();

            Console.ReadLine();
                 
        }
    }
}
