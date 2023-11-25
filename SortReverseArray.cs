using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAppli3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = arr1;

            Console.WriteLine("the original arayy:");

            foreach(int i in arr1)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Array.Reverse(temp);

            Console.WriteLine("the reversed array is:");

            foreach (int i in temp){

                Console.Write(i + " ");

            }
            Console.WriteLine();

            Array.Sort(arr1);

            Console.WriteLine("the sorted array is:");

            foreach(int i in arr1)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

     


            Console.ReadLine();
        }
    }
}
