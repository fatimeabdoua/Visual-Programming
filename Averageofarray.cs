using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAppli2
{
    internal class MyArray
    {

        double getAverage(int[] arr, int size)
        {
         
            int sum = 0;

            for(int i = 0; i<size; i++)
            {
                sum = sum + arr[i];
            }

            double avg = (double)sum / size;

            return avg;
        }
      

        static void Main(string[] args)
        {
            MyArray app = new MyArray();

            int[] arr = { 1000, 2, 3, 17, 50 };

            double avg = app.getAverage(arr, 5);

            Console.WriteLine("the average is :" + avg);

            Console.ReadLine();

        }
    }
}
