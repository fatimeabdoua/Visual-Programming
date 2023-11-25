using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasingbyvalue
{
    internal class Program
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            int a = 100;
            int b = 200;

            Console.WriteLine("before swap , the value of a : {0}", a);
            Console.WriteLine("before swap , the value of b : {0}", b);


            p.swap(ref a, ref b);

            Console.WriteLine("after swap , the value of a : {0}", a);
            Console.WriteLine("after swap , the value of a : {0}", b);

            Console.ReadLine();


        }
    }
}
